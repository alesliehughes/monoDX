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
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.DirectPlay
{
	public class Peer : MarshalByRefObject, IDisposable
	{
		public bool Disposed
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public GroupMembersList GroupMembers
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public PlayersGroupsEnumerator Groups
		{
			get
			{
				throw new NotImplementedException ();
			}
		}

		public PlayersGroupsEnumerator Players
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
			set
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

		public event SessionTerminatedEventHandler SessionTerminated;

		public event SendCompleteEventHandler SendComplete;

		public event PlayerRemovedFromGroupEventHandler PlayerRemovedFromGroup;

		public event ReceiveEventHandler Receive;

		public event PeerInformationEventHandler PeerInformation;

		public event IndicatedConnectAbortedEventHandler IndicatedConnectAborted;

		public event IndicateConnectEventHandler IndicateConnect;

		public event HostMigratedEventHandler HostMigrated;

		public event GroupInformationEventHandler GroupInformation;

		public event FindHostResponseEventHandler FindHostResponse;

		public event FindHostQueryEventHandler FindHostQuery;

		public event PlayerDestroyedEventHandler PlayerDestroyed;

		public event GroupDestroyedEventHandler GroupDestroyed;

		public event GroupCreatedEventHandler GroupCreated;

		public event ConnectCompleteEventHandler ConnectComplete;

		public event AsyncOperationCompleteEventHandler AsyncOperationComplete;

		public event ApplicationDescriptionEventHandler ApplicationDescriptionChanged;

		public event PlayerAddedToGroupEventHandler PlayerAddedToGroup;

		public event PlayerCreatedEventHandler PlayerCreated;

		public override bool Equals(object compare)
		{
			throw new NotImplementedException ();
		}

		public static bool operator ==(Peer left, Peer right)
		{
			throw new NotImplementedException ();
		}

		public static bool operator !=(Peer left, Peer right)
		{
			throw new NotImplementedException ();
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public void Dispose(bool closeImmediate)
		{
		}

		public void Dispose()
		{
		}

		public Peer(Microsoft.DirectX.DirectPlay.InitializeFlags flags)
		{
		}

		public Peer()
		{
		}

		public void Host(ApplicationDescription applicationDescription, Address[] deviceAddress, object playerContext, HostFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address deviceAddress, object playerContext, HostFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address[] deviceAddress, HostFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address deviceAddress, HostFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address[] deviceAddress, object playerContext)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address deviceAddress, object playerContext)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address[] deviceAddress)
		{
			throw new NotImplementedException ();
		}

		public void Host(ApplicationDescription applicationDescription, Address deviceAddress)
		{
			throw new NotImplementedException ();
		}

		public void CancelAsyncOperation(int asyncHandle)
		{
			throw new NotImplementedException ();
		}

		public void CancelAsyncOperation(CancelFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, Microsoft.DirectX.DirectPlay.ConnectFlags flags, object playerContext, object userContext)
		{
			throw new NotImplementedException ();
		}

		public void Connect(ApplicationDescription applicationDescription, Address hostAddress, Address deviceInformation, NetworkPacket userConnectData, out int asyncHandle, Microsoft.DirectX.DirectPlay.ConnectFlags flags, object playerContext, object userContext)
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

		public void GetSendQueueInformation(int dpnidPlayer, out int numberMessages, out int numberBytes, GetSendQueueInformationFlags flags)
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

		public void CreateGroup(GroupInformation groupInformation, SyncFlags flags, object groupContext, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void CreateGroup(GroupInformation groupInformation, out int asyncHandle, SyncFlags flags, object groupContext, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void CreateGroup(GroupInformation groupInformation, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void CreateGroup(GroupInformation groupInformation, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void DestroyGroup(int groupID, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void DestroyGroup(int groupID, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void DestroyGroup(int groupID, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void DestroyGroup(int groupID, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void AddPlayerToGroup(int groupID, int clientID, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void AddPlayerToGroup(int groupID, int clientID, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void AddPlayerToGroup(int groupID, int clientID, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void AddPlayerToGroup(int groupID, int clientID, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void RemovePlayerFromGroup(int groupID, int clientID, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void RemovePlayerFromGroup(int groupID, int clientID, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void RemovePlayerFromGroup(int groupID, int clientID, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void RemovePlayerFromGroup(int groupID, int clientID, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public object GetPlayerContext(int playerID)
		{
			throw new NotImplementedException ();
		}

		public object GetGroupContext(int groupID)
		{
			throw new NotImplementedException ();
		}

		public Address GetPeerAddress(int playerID)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders([MarshalAs(UnmanagedType.U1)] bool getAll)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders(Guid guidServiceProvider, [MarshalAs(UnmanagedType.U1)] bool getAll)
		{
			throw new NotImplementedException ();
		}

		public ServiceProviderInformation[] GetServiceProviders(Guid guidServiceProvider, Guid guidApplication, [MarshalAs(UnmanagedType.U1)] bool getAll)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, GCHandle gcbuffer, int bufferSize, int timeOut, out int asyncHandle, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, GCHandle gcbuffer, int bufferSize, int timeOut, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, GCHandle gcbuffer, int bufferSize, int timeOut, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, GCHandle gcbuffer, int bufferSize, int timeOut, out int asyncHandle, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, NetworkPacket sendData, int timeOut, out int asyncHandle, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, NetworkPacket sendData, int timeOut, SendFlags flags, object context)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, NetworkPacket sendData, int timeOut, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SendTo(int playerID, NetworkPacket sendData, int timeOut, out int asyncHandle, SendFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void DestroyPeer(int playerID, NetworkPacket destroyData)
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

		public void TerminateSession(NetworkPacket terminateData)
		{
			throw new NotImplementedException ();
		}

		public void SetPeerInformation(PlayerInformation playerInformation, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetPeerInformation(PlayerInformation playerInformation, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetPeerInformation(PlayerInformation playerInformation, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void SetPeerInformation(PlayerInformation playerInformation, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public PlayerInformation GetPeerInformation(int playerID)
		{
			throw new NotImplementedException ();
		}

		public void SetGroupInformation(int groupID, GroupInformation groupInformation, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetGroupInformation(int groupID, GroupInformation groupInformation, out int asyncHandle, SyncFlags flags)
		{
			throw new NotImplementedException ();
		}

		public void SetGroupInformation(int groupID, GroupInformation groupInformation, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public void SetGroupInformation(int groupID, GroupInformation groupInformation, out int asyncHandle, SyncFlags flags, object asyncContext)
		{
			throw new NotImplementedException ();
		}

		public GroupInformation GetGroupInformation(int groupID)
		{
			throw new NotImplementedException ();
		}

		public Address[] GetLocalHostAddresses(LocalAddressFlags flags)
		{
			throw new NotImplementedException ();
		}

		public ConnectionInformation GetConnectionInformation(int playerID)
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

		protected void raise_PlayerCreated(object i1, PlayerCreatedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_PlayerAddedToGroup(object i1, PlayerAddedToGroupEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_ApplicationDescriptionChanged(object i1, EventArgs i2)
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

		protected void raise_GroupCreated(object i1, GroupCreatedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_GroupDestroyed(object i1, GroupDestroyedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_PlayerDestroyed(object i1, PlayerDestroyedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_FindHostQuery(object i1, FindHostQueryEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_FindHostResponse(object i1, FindHostResponseEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_GroupInformation(object i1, GroupInformationEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_HostMigrated(object i1, HostMigratedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_IndicateConnect(object i1, IndicateConnectEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_IndicatedConnectAborted(object i1, IndicatedConnectAbortedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_PeerInformation(object i1, PeerInformationEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Receive(object i1, Microsoft.DirectX.DirectPlay.ReceiveEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_PlayerRemovedFromGroup(object i1, PlayerRemovedFromGroupEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_SendComplete(object i1, SendCompleteEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_SessionTerminated(object i1, SessionTerminatedEventArgs i2)
		{
			throw new NotImplementedException ();
		}

		protected void raise_Disposing(object i1, EventArgs i2)
		{
			throw new NotImplementedException ();
		}

	}
}
