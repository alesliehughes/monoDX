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
using Microsoft.DirectX.PrivateImplementationDetails;
using System.ComponentModel;

namespace Microsoft.DirectX.Direct3D
{
	public sealed class AnimationController : IDisposable, ICloneable
	{
		public event EventHandler Disposing {
			
			add {
				throw new NotImplementedException ();
			}
			
			remove {
				throw new NotImplementedException ();
			}
		}

		[CLSCompliant(false)]
		public unsafe ID3DXAnimationController* UnmanagedComPointer {
			get {
				throw new NotImplementedException ();
			}
		}

		public float PriorityBlend {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public int NumberAnimationSets {
			get {
				throw new NotImplementedException ();
			}
		}

		public double Time {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxNumberEvents {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxNumberTracks {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxNumberAnimationSets {
			get {
				throw new NotImplementedException ();
			}
		}

		public int MaxNumberAnimationOutputs {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool Disposed {
			
			get {
				throw new NotImplementedException ();
			}
		}

		static AnimationController ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe AnimationController (ID3DXAnimationController* pUnk)
		{
			throw new NotImplementedException ();
		}

		public AnimationController (IntPtr unmanagedObject)
		{
			throw new NotImplementedException ();
		}

		public AnimationController (int maxNumberMatrices, int maxNumberAnimationSets, int maxNumberTracks, int maxNumberEvents)
		{
			throw new NotImplementedException ();
		}
	
		public override bool Equals (object compare)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator == (AnimationController left, AnimationController right)
		{
			throw new NotImplementedException ();
		}
		
		public static bool operator != (AnimationController left, AnimationController right)
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

		public void RegisterAnimationOutput (Frame animationFrame)
		{
			throw new NotImplementedException ();
		}

		public void RegisterAnimationOutput (AnimationOutput output)
		{
			throw new NotImplementedException ();
		}

		public void UnregisterAnimationOutput (Frame animationFrame)
		{
			throw new NotImplementedException ();
		}

		public void UnregisterAnimationOutput (AnimationOutput output)
		{
			throw new NotImplementedException ();
		}

		public void UnregisterAnimationOutput (string name)
		{
			throw new NotImplementedException ();
		}

		public void RegisterAnimationSet (AnimationSet animationSet)
		{
			throw new NotImplementedException ();
		}

		public void UnregisterAnimationSet (AnimationSet animationSet)
		{
			throw new NotImplementedException ();
		}

		public void AdvanceTime (double timeDelta)
		{
			throw new NotImplementedException ();
		}

		public void AdvanceTime (double timeDelta, HandleAnimationCallback callbackHandler)
		{
			throw new NotImplementedException ();
		}

		public void ResetTime ()
		{
			throw new NotImplementedException ();
		}

		public AnimationSet GetAnimationSet (string animationName)
		{
			throw new NotImplementedException ();
		}

		public AnimationSet GetAnimationSet (int index)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackAnimationSet (int track, AnimationSet animationSet)
		{
			throw new NotImplementedException ();
		}

		public AnimationSet GetTrackAnimationSet (int track)
		{
			throw new NotImplementedException ();
		}
		
		public void SetTrackPriority (int track, PriorityType priority)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackSpeed (int track, float speed)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackWeight (int track, float weight)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackPosition (int track, double position)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackEnable (int track, bool enable)
		{
			throw new NotImplementedException ();
		}

		public TrackDescription GetTrackDescription (int trackNumber)
		{
			throw new NotImplementedException ();
		}

		public void SetTrackDescription (int trackNumber, TrackDescription value)
		{
			throw new NotImplementedException ();
		}

		public int KeyTrackSpeed (int track, float newSpeed, double startTime, double duration, TransitionType method)
		{
			throw new NotImplementedException ();
		}

		public int KeyTrackWeight (int track, float newWeight, double startTime, double duration, TransitionType method)
		{
			throw new NotImplementedException ();
		}

		public int KeyTrackPosition (int track, double newPosition, double startTime)
		{
			throw new NotImplementedException ();
		}

		public int KeyTrackEnable (int track, bool newEnable, double startTime)
		{
			throw new NotImplementedException ();
		}

		public int KeyPriorityBlend (float newBlendWeight, double startTime, double duration, TransitionType method)
		{
			throw new NotImplementedException ();
		}

		public void UnkeyEvent (int eventHandle)
		{
			throw new NotImplementedException ();
		}

		public void UnkeyAllTrackEvents (int track)
		{
			throw new NotImplementedException ();
		}

		public void UnkeyAllPriorityBlends ()
		{
			throw new NotImplementedException ();
		}

		public int GetCurrentTrackEvent (int track, EventType eventType)
		{
			throw new NotImplementedException ();
		}

		public int GetCurrentPriorityBlend ()
		{
			throw new NotImplementedException ();
		}

		public int GetUpcomingTrackEvent (int track, int eventHandle)
		{
			throw new NotImplementedException ();
		}

		public int GetUpcomingPriorityBlend (int eventHandle)
		{
			throw new NotImplementedException ();
		}

		public void ValidateEvent (int eventHandle)
		{
			throw new NotImplementedException ();
		}
		
		public bool IsEventValid (int eventHandle)
		{
			throw new NotImplementedException ();
		}
		
		public bool IsEventValid (int eventHandle, out int result)
		{
			throw new NotImplementedException ();
		}

		public EventDescription GetEventDescription (int eventHandle)
		{
			throw new NotImplementedException ();
		}

		public AnimationController Clone (int maxNumberAnimationOutputs, int maxNumberAnimationSets, int maxNumberTracks, int maxNumberEvents)
		{
			throw new NotImplementedException ();
		}

		public object Clone ()
		{
			throw new NotImplementedException ();
		}

		[CLSCompliant(false)]
		public unsafe void UpdateUnmanagedPointer (ID3DXAnimationController* pInterface)
		{
			throw new NotImplementedException ();
		}

		[EditorBrowsable]
		public IntPtr GetObjectByValue (int uniqueKey)
		{
			throw new NotImplementedException ();
		}

	}
}


