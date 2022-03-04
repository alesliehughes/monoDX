// Post-processing step to allow for parameterless constructors on value types.
// This is part of the ABI of Managed DirectX but C# (until version 10) does not
// allow us to declare them.

using System;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

class FixupConstructors
{
	public static void Main (string[] args)
	{
		ReaderParameters mode = new ReaderParameters();
		mode.ReadWrite = true;

		foreach (string filename in args)
		{
			var assembly = AssemblyDefinition.ReadAssembly(filename, mode);

			bool changed = FixupAssembly(assembly);

			if (changed)
			{
				assembly.Write();
			}
		}
	}

	static bool FixupAssembly (AssemblyDefinition assembly)
	{
		bool changed = false;

		foreach (ModuleDefinition module in assembly.Modules)
		{
			if (FixupModule(module))
				changed = true;
		}

		return changed;
	}

	static bool IsPublicTypeDefinition (TypeDefinition typedef)
	{
		if (typedef.IsNested && !IsPublicTypeDefinition(typedef.DeclaringType))
			return false;
		if (typedef.IsPublic || typedef.IsNestedFamily || typedef.IsNestedFamilyOrAssembly ||
			typedef.IsNestedPublic)
			return true;
		return false;
	}

	static bool FixupTypeConstructor (ModuleDefinition module, TypeDefinition typedef)
	{
		if (!typedef.IsValueType)
			return false;

		MethodDefinition init_method = null;

		foreach (MethodDefinition method in typedef.Methods)
		{
			if (method.IsSpecialName && !method.IsStatic && method.Name == ".ctor" && method.Parameters.Count == 0)
			{
				return false;
			}
			if (method.Name == "ParameterlessInit" && !method.IsStatic && method.Parameters.Count == 0)
			{
				init_method = method;
			}
		}
		if (init_method == null)
			return false;

		TypeReference void_type = module.ImportReference(typeof(void));

		MethodDefinition new_ctor = new MethodDefinition(".ctor",
			MethodAttributes.Public|MethodAttributes.SpecialName|MethodAttributes.RTSpecialName|MethodAttributes.HideBySig,
			void_type);

		MethodBody new_body = new MethodBody(new_ctor);

		new_body.Instructions.Add(Instruction.Create(OpCodes.Ldarg_0));
		new_body.Instructions.Add(Instruction.Create(OpCodes.Call, init_method));
		new_body.Instructions.Add(Instruction.Create(OpCodes.Ret));

		new_ctor.Body = new_body;
		typedef.Methods.Add(new_ctor);

		return true;
	}

	static bool FixupConstFields (ModuleDefinition module, TypeDefinition typedef)
	{
		bool changed = false;

		foreach (FieldDefinition field in typedef.Fields)
		{
			if (!field.IsPublic)
				continue;

			CustomAttribute const_modifier_attr = null;

			foreach (var ca in field.CustomAttributes)
			{
				if (ca.Constructor.DeclaringType.Name == "IsConstModifier")
				{
					const_modifier_attr = ca;
				}
			}

			if (const_modifier_attr != null)
			{
				field.FieldType = new OptionalModifierType(const_modifier_attr.Constructor.DeclaringType, field.FieldType);
				field.CustomAttributes.Remove(const_modifier_attr);
				changed = true;
			}
		}

		return changed;
	}

	static bool FixupModule (ModuleDefinition module)
	{
		bool changed = false;

		foreach (TypeDefinition typedef in module.Types)
		{
			if (!IsPublicTypeDefinition(typedef))
				continue;

			if (FixupTypeConstructor (module, typedef))
				changed = true;

			if (FixupConstFields (module, typedef))
				changed = true;
		}
		return changed;
	}
}
