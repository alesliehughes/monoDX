
all: FixupConstructors.exe

FixupConstructors.exe: FixupConstructors.cs $(MONO_CECIL_DLL)
	csc $< -r:$(MONO_CECIL_DLL) -r:Microsoft.VisualC.dll -out:$@
