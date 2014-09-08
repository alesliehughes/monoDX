/*
 * The MIT License (MIT)
 *
 * Copyright (c) 2014 Alistair Leslie-Hughes
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
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.DirectX.DirectPlay
{
    public class Address : MarshalByRefObject, IDisposable, ICloneable
    {
        public const int DpnServerPort = 6073;
        public const int IndexInvalid = -1;
        public const int TraversalModeNone = 0;
        public const int TraversalModePortRequired = 1;
        public const int TraversalModePortRecommended = 2;
        public static string SeparatorKeyValue;
        public static string SeparatorUserdata;
        public static string SeparatorComponent;
        public static string EscapeChar;
        public static string Header;
        public static string KeyNatResolver;
        public static string KeyNatResolverUserString;
        public static string KeyApplicationInstance;
        public static string KeyTraversalMode;
        public static string KeyDevice;
        public static string KeyHostname;
        public static string KeyPort;
        public static string KeyProcessor;
        public static string KeyProgram;
        public static string KeyProvider;
        public static string KeyScope;
        public static string KeyBaud;
        public static string KeyFlowControl;
        public static string KeyParity;
        public static string KeyPhoneNumber;
        public static string KeyStopBits;
        public const int BaudRate9600 = 9600;
        public const int BaudRate14400 = 14400;
        public const int BaudRate19200 = 19200;
        public const int BaudRate38400 = 38400;
        public const int BaudRate56000 = 56000;
        public const int BaudRate57600 = 57600;
        public const int BaudRate115200 = 115200;
        public static string StopBitsOne;
        public static string StopBitsOneFive;
        public static string StopBitsTwo;
        public static string ParityNone;
        public static string ParityEven;
        public static string ParityOdd;
        public static string ParityMark;
        public static string ParitySpace;
        public static string FlowControlNone;
        public static string FlowControlXonXoff;
        public static string FlowControlControlRts;
        public static string FlowControlDtr;
        public static string FlowControlRtsDtr;
        public static string TcpIpProvider;
        public static string IpxProvider;
        public static string ModemProvider;
        public static string SerialProvider;
        public static readonly Guid ServiceProviderIpx;
        public static readonly Guid ServiceProviderModem;
        public static readonly Guid ServiceProviderSerial;
        public static readonly Guid ServiceProviderTcpIp;
        public static readonly Guid ServiceProviderBlueTooth;
        internal bool m_bDisposed;

        public event EventHandler Disposing {
            [MethodImpl(32)]
			add {
                throw new NotImplementedException ();
            }
            [MethodImpl(32)]
			remove {
                throw new NotImplementedException ();
            }
        }

        public bool Disposed {
            [return: MarshalAs(4)]
			get {
                throw new NotImplementedException ();
            }
        }

        public int NumberComponents {
            get {
                throw new NotImplementedException ();
            }
        }

        public IntPtr UserData {
            get {
                throw new NotImplementedException ();
            }
            set {
                throw new NotImplementedException ();
            }
        }

        public string Url {
            get {
                throw new NotImplementedException ();
            }
            set {
                throw new NotImplementedException ();
            }
        }

        public Guid Device {
            get {
                throw new NotImplementedException ();
            }
            set {
                throw new NotImplementedException ();
            }
        }

        public Guid ServiceProvider {
            get {
                throw new NotImplementedException ();
            }
            set {
                throw new NotImplementedException ();
            }
        }

        static Address ()
        {

        }

        [return: MarshalAs(4)]
        public bool Equals (Address address)
        {
            throw new NotImplementedException ();
        }

        [return: MarshalAs(4)]
        public override bool Equals (object compare)
        {
            throw new NotImplementedException ();
        }

        [return: MarshalAs(4)]
        public static bool operator == (Address left, Address right)
        {
            throw new NotImplementedException ();
        }

        [return: MarshalAs(4)]
        public static bool operator != (Address left, Address right)
        {
            throw new NotImplementedException ();
        }

        public override int GetHashCode ()
        {
            throw new NotImplementedException ();
        }

        public void Dispose ()
        {
            throw new NotImplementedException ();
        }

        public Address (IPEndPoint address)
        {
            throw new NotImplementedException ();
        }

        public Address (IPAddress address)
        {
            throw new NotImplementedException ();
        }

        public Address (string hostname, int port)
        {
            throw new NotImplementedException ();
        }

        public Address ()
        {
        }

        public void SetEqual (Address address)
        {
            throw new NotImplementedException ();
        }

        public void AddComponent (string keyName, byte[] value)
        {
            throw new NotImplementedException ();
        }

        public void AddComponent (string keyName, Guid value)
        {
            throw new NotImplementedException ();
        }

        public void AddComponent (string keyName, string value)
        {
            throw new NotImplementedException ();
        }

        public void AddComponent (string keyName, int iValue)
        {
            throw new NotImplementedException ();
        }

        public int GetComponentInteger (string keyName)
        {
            throw new NotImplementedException ();
        }

        public string GetComponentString (string keyName)
        {
            throw new NotImplementedException ();
        }

        public Guid GetComponentGuid (string keyName)
        {
            throw new NotImplementedException ();
        }

        public byte[] GetComponentBinary (string keyName)
        {
            throw new NotImplementedException ();
        }

        public void Clear ()
        {
            throw new NotImplementedException ();
        }

        public object Clone ()
        {
            throw new NotImplementedException ();
        }

        [MethodImpl(32)]
        protected void raise_Disposing (object i1, EventArgs i2)
        {

        }
    }
}
