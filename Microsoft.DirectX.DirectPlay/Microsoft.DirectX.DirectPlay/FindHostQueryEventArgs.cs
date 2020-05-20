// Microsoft.DirectX.DirectPlay.FindHostQueryEventArgs
using Microsoft.DirectX.DirectPlay;
using System;
using System.Runtime.InteropServices;

public sealed class FindHostQueryEventArgs : EventArgs
{
	private bool reject;

	public FindHostsQueryMessage Message;

	internal int ReturnValue
	{
		get
		{
			return reject ? (-2147467259) : 0;
		}
	}

	public bool RejectMessage
	{
		[return: MarshalAs(UnmanagedType.U1)]
		get
		{
			return reject;
		}
		[param: MarshalAs(UnmanagedType.U1)]
		set
		{
			reject = value;
		}
	}

	public FindHostQueryEventArgs(FindHostsQueryMessage dpMessage)
	{
		Message = default(FindHostsQueryMessage);
		Message = dpMessage;
		reject = false;
	}
}
