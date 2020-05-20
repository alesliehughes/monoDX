// Microsoft.DirectX.DirectPlay.IndicatedConnectAbortedEventArgs
using Microsoft.DirectX.DirectPlay;
using System;

public sealed class IndicatedConnectAbortedEventArgs : EventArgs
{
	public IndicatedConnectAbortedMessage Message;

	public IndicatedConnectAbortedEventArgs(IndicatedConnectAbortedMessage dpMessage)
	{
		Message = default(IndicatedConnectAbortedMessage);
		Message = dpMessage;
	}
}
