/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2013 Alistair Leslie-Hughes
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
 * the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
 * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
 * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace Microsoft.DirectX.DirectInput
{
	public sealed class Device : MarshalByRefObject, IDisposable
	{
		public DeviceImageInformationHeader ImageInformation
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public EffectList CreatedEffects
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public ForceFeedbackStates ForceFeedbackState
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public DeviceInstance DeviceInformation
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public JoystickState CurrentJoystickState
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public MouseState CurrentMouseState
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public DeviceObjectList Objects
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public DeviceProperties Properties
		{
			get
			{
				throw new NotImplementedException ();
			}
		}
		public DeviceCaps Caps
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public Device(Guid deviceGuid)
		{
			throw new NotImplementedException ();
		}


		public override bool Equals(object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator ==(Device left, Device right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator !=(Device left, Device right)
		{
			throw new NotImplementedException ();
		}
		public override int GetHashCode()
		{
			throw new NotImplementedException ();
		}
		public void Dispose()
		{
			throw new NotImplementedException ();
		}
		public DeviceObjectList GetObjects(DeviceObjectTypeFlags flags)
		{
			throw new NotImplementedException ();
		}
		public void Acquire()
		{
			throw new NotImplementedException ();
		}
		public void Unacquire()
		{
			throw new NotImplementedException ();
		}
		public object GetDeviceState(Type customFormatType)
		{
			throw new NotImplementedException ();
		}
		public KeyboardState GetCurrentKeyboardState()
		{
			throw new NotImplementedException ();
		}
		public Key[] GetPressedKeys()
		{
			throw new NotImplementedException ();
		}
		public BufferedDataCollection GetBufferedData()
		{
			throw new NotImplementedException ();
		}
		public void SetDataFormat(DeviceDataFormat df)
		{
			throw new NotImplementedException ();
		}
		public void SetDataFormat(DataFormat df)
		{
			throw new NotImplementedException ();
		}
		public void SetEventNotification(WaitHandle deviceEvent)
		{
			throw new NotImplementedException ();
		}

		public void SetCooperativeLevel(Control parent, CooperativeLevelFlags flags)
		{
			throw new NotImplementedException ();
		}
		public void SetCooperativeLevel(IntPtr hwnd, CooperativeLevelFlags flags)
		{
			throw new NotImplementedException ();
		}
		public DeviceObjectInstance GetObjectInformation(int obj, ParameterHow how)
		{
			throw new NotImplementedException ();
		}
		public void RunControlPanel()
		{
			throw new NotImplementedException ();
		}
		public void RunControlPanel(Control owner)
		{
			throw new NotImplementedException ();
		}

		public EffectList GetEffects(string fileName, FileEffectsFlags flags)
		{
			throw new NotImplementedException ();
		}
		public EffectList GetEffects(EffectType effType)
		{
			throw new NotImplementedException ();
		}
		public EffectInformation GetEffectInformation(Guid rguid)
		{
			throw new NotImplementedException ();
		}
		public void SendForceFeedbackCommand(ForceFeedbackCommand command)
		{
			throw new NotImplementedException ();
		}
		public byte[] SendHardwareCommand(int command, byte[] data)
		{
			throw new NotImplementedException ();
		}
		public void Poll()
		{
			throw new NotImplementedException ();
		}
		public void WriteEffect(Stream stream, FileEffect[] fileEffect)
		{
			throw new NotImplementedException ();
		}
		public void WriteEffect(Stream stream, FileEffect[] fileEffect, FileEffectsFlags flags)
		{
			throw new NotImplementedException ();
		}
		public void WriteEffect(string fileName, FileEffect[] fileEffect)
		{
			throw new NotImplementedException ();
		}
		public void WriteEffect(string fileName, FileEffect[] fileEffect, FileEffectsFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void BuildActionMap(ActionFormat af, ActionMapControl flags)
		{
			throw new NotImplementedException ();
		}
		public void BuildActionMap(ActionFormat af, string userName, ActionMapControl flags)
		{
			throw new NotImplementedException ();
		}

		public SetActionMapReturnCodes SetActionMap(ActionFormat af, ApplyActionMap flags)
		{
			throw new NotImplementedException ();
		}
		public SetActionMapReturnCodes SetActionMap(ActionFormat af, string userName, ApplyActionMap flags)
		{
			throw new NotImplementedException ();
		}
	}
}

