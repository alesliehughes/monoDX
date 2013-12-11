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

namespace Microsoft.DirectX.DirectPlay
{
	public enum ResultCode
	{
		ConnectionLost = -2146074272,
		UserCancel = -2146073008,
		TimedOut = -2146073040,
		SessionFull = -2146073072,
		PlayerNotReachable = -2146073200,
		PlayerNotInGroup = -2146073216,
		PlayerLost = -2146073232,
		PlayerAlreadyInGroup = -2146073248,
		NotReady = -2146073280,
		NotHost = -2146073296,
		NotAllowed = -2146073312,
		NoResponse = -2146073328,
		NoHostPlayer = -2146073456,
		NoConnection = -2146073472,
		HostTerminatedSession = -2146074000,
		HostRejectedConnection = -2146074016,
		DoesNotExist = -2146074240,
		CannotCreatePlayer = -2146074320,
		CannotCreateGroup = -2146074336,
		CannotCancel = -2146074352,
		Aborted = -2146074576,
		Success = 0
	}
}

