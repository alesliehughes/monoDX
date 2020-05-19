/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2020 Alistair Leslie-Hughes
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
using Microsoft.DirectX;
using Microsoft.DirectX.DirectPlay;
using Microsoft.DirectX.DirectPlay.Lobby;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Microsoft.DirectX.DirectPlay
{
	public class Client : MarshalByRefObject, IDisposable
	{
		public bool Disposed
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public ApplicationDescription ApplicationDescription
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public Caps Caps
		{
			get
			{
				throw new NotImplementedException ();
			}
			set
			{
				throw new NotImplementedException ();
			}
		}

		public event EventHandler Disposing;

		public event ApplicationDescriptionEventHandler ApplicationDescriptionChanged;

		public event SessionTerminatedEventHandler SessionTerminated;

		public event ServerInformationEventHandler ServerInformation;

		public event SendCompleteEventHandler SendComplete;

		public event ReceiveEventHandler Receive;

		public event FindHostResponseEventHandler FindHostResponse;

		public event ConnectCompleteEventHandler ConnectComplete;

		public event AsyncOperationCompleteEventHandler AsyncOperationComplete;

		public event ClientInformationEventHandler ClientInformation;

		public override bool Equals(object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator ==(Microsoft.DirectX.DirectPlay.Client left, Microsoft.DirectX.DirectPlay.Client right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator !=(Microsoft.DirectX.DirectPlay.Client left, Microsoft.DirectX.DirectPlay.Client right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode()
		{
			throw new NotImplementedException ();
		}

		public void Dispose(bool closeImmediate)
		{
			throw new NotImplementedException ();
		}

		public void Dispose()
		{
			throw new NotImplementedException ();
		}

		public Client(Microsoft.DirectX.DirectPlay.InitializeFlags flags)
		{
		}

		public Client()
		{
		}

		public void CancelAsyncOperation(int asyncHandle)
		{
			throw new NotImplementedException ();
		}

		public void CancelAsyncOperation(CancelFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, Microsoft.DirectX.DirectPlay.ConnectFlags flags, object userContext)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, out int asyncHandle, Microsoft.DirectX.DirectPlay.ConnectFlags flags, object userContext)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, Microsoft.DirectX.DirectPlay.ConnectFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, out int asyncHandle, Microsoft.DirectX.DirectPlay.ConnectFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void GetSendQueueInformation(out int numberMessages, out int numberBytes, GetSendQueueInformationFlags flags)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderCaps GetSPCaps(Guid guidServiceProvider)
		{
			throw new NotImplementedException ();
		}

		public void SetSPCaps(Guid guidServiceProvider, ServiceProviderCaps value)
		{
			throw new NotImplementedException ();
		}

		public Address GetServerAddress()
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders(bool getAll)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders(Guid guidServiceProvider, bool getAll)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders(Guid guidServiceProvider, Guid guidApplication, bool getAll)
		{
			throw new NotImplementedException ();
		}

		public void Send(GCHandle gcbuffer, int bufferSize, int timeOut, out int asyncHandle, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void Send(GCHandle gcbuffer, int bufferSize, int timeOut, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void Send(GCHandle gcbuffer, int bufferSize, int timeOut, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Send(GCHandle gcbuffer, int bufferSize, int timeOut, out int asyncHandle, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Send(NetworkPacket sendData, int timeOut, out int asyncHandle, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void Send(NetworkPacket sendData, int timeOut, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void Send(NetworkPacket sendData, int timeOut, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Send(NetworkPacket sendData, int timeOut, out int asyncHandle, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void FindHosts(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userEnumData, int count, int retryInterval, int timeOut, FindHostsFlags flags, object userContext)
		{
			throw new NotImplementedException ();
		}

		public void FindHosts(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userEnumData, int count, int retryInterval, int timeOut, FindHostsFlags flags, out int asyncHandle, object userContext)
		{
			throw new NotImplementedException ();
		}

		public void FindHosts(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userEnumData, int count, int retryInterval, int timeOut, FindHostsFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void FindHosts(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userEnumData, int count, int retryInterval, int timeOut, FindHostsFlags flags, out int asyncHandle)
		{
			throw new NotImplementedException ();
		}

		public void SetClientInformation(PlayerInformation playerInformation, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetClientInformation(PlayerInformation playerInformation, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetClientInformation(PlayerInformation playerInformation, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void SetClientInformation(PlayerInformation playerInformation, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public PlayerInformation GetServerInformation()
		{
			throw new NotImplementedException ();
		}

		public ConnectionInformation GetConnectionInformation()
		{
			throw new NotImplementedException ();
		}

		public void RegisterLobby(int handle, Application lobbiedApplication)
		{
			throw new NotImplementedException ();
		}

		public void UnregisterLobby()
		{
			throw new NotImplementedException ();
		}

		protected void Finalize()
		{
			throw new NotImplementedException ();
		}

		protected void raise_ClientInformation(object i1, ClientInformationEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_AsyncOperationComplete(object i1, AsyncOperationCompleteEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_ConnectComplete(object i1, ConnectCompleteEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_FindHostResponse(object i1, FindHostResponseEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Receive(object i1, Microsoft.DirectX.DirectPlay.ReceiveEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_SendComplete(object i1, SendCompleteEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_ServerInformation(object i1, ServerInformationEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_SessionTerminated(object i1, SessionTerminatedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_ApplicationDescriptionChanged(object i1, EventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Disposing(object i1, EventArgs i2)
		{
			throw new NotImplementedException ();
		}
	}
}
