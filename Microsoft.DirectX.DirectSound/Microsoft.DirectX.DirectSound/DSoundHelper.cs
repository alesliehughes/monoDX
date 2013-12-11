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

namespace Microsoft.DirectX.DirectSound
{
	public sealed class DSoundHelper
	{
		public static readonly Guid StandardGargleGuid;
		public static readonly Guid StandardChorusGuid;
		public static readonly Guid StandardFlangerGuid;
		public static readonly Guid StandardEchoGuid;
		public static readonly Guid StandardDistortionGuid;
		public static readonly Guid StandardCompressorGuid;
		public static readonly Guid StandardInteractive3DLevel2ReverbGuid;
		public static readonly Guid StandardParamEqGuid;
		public static readonly Guid StandardWavesReverbGuid;
		public static readonly Guid CaptureEffectsClassAcousticEchoCancellation;
		public static readonly Guid CaptureEffectsMsAcousticEchoCancellation;
		public static readonly Guid CaptureEffectsSystemAcousticEchoCancellation;
		public static readonly Guid CaptureEffectsMsNoiseSuppression;
		public static readonly Guid CaptureEffectsClassNoiseSuppression;
		public static readonly Guid CaptureEffectsSystemNoiseSuppression;
		public static readonly Guid InterfaceEffectsChorus;
		public static readonly Guid InterfaceEffectsCompressor;
		public static readonly Guid InterfaceEffectsDistortion;
		public static readonly Guid InterfaceEffectsEcho;
		public static readonly Guid InterfaceEffectsFlanger;
		public static readonly Guid InterfaceEffectsGargle;
		public static readonly Guid InterfaceEffectsInteractive3DLevel2Reverb;
		public static readonly Guid InterfaceEffectsParamEq;
		public static readonly Guid InterfaceEffectsWavesReverb;
		public static readonly Guid InterfaceCaptureEffectsAcousticEchoCancellation;
		public static readonly Guid InterfaceCaptureEffectsNoiseSuppress;
		public static readonly Guid InterfaceBuffer;
		public static readonly Guid InterfaceSecondaryBuffer;
		public static readonly Guid Interface3DBuffer;
		public static readonly Guid Interface3DListener;
		public static readonly Guid InterfaceDirectSound;
		public static readonly Guid InterfaceDirectSoundCapture;
		public static readonly Guid InterfaceCaptureBuffer;
		public static readonly Guid InterfaceNotify;
		public static readonly Guid GuidAllObjects;
		public static readonly Guid Guid3DAlgorithmDefault;
		public static readonly Guid Guid3DAlgorithmNoVirtualization;
		public static readonly Guid Guid3DAlgorithmHrtfFull;
		public static readonly Guid Guid3DAlgorithmHrtfLight;
		public static readonly Guid DefaultPlaybackDevice;
		public static readonly Guid DefaultCaptureDevice;
		public static readonly Guid DefaultVoicePlaybackDevice;
		public static readonly Guid DefaultVoiceCaptureDevice;
		public static readonly float MinDistanceFactor;
		public static readonly float MaxDistanceFactor;
		public static readonly float DefaultDistanceFactor;
		public static readonly float MinRolloffFactor;
		public static readonly float MaxRolloffFactor;
		public static readonly float DefaultRolloffFactor;
		public static readonly float MinDopplerFactor;
		public static readonly float MaxDopplerFactor;
		public static readonly float DefaultDopplerFactor;
		public static readonly float DefaultMinDistance;
		public static readonly float DefaultMaxDistance;
		public static readonly float MinConeAngle;
		public static readonly float MaxConeAngle;
		public static readonly float DefaultConeAngle;
		public const int DefaultConeOutsideVolume = 0;
		public unsafe static object GetObjectFromInterfaceGuid(IntPtr lpVal, Guid iid, object source)
		{
			throw new NotImplementedException ();
		}

		static DSoundHelper()
		{
			throw new NotImplementedException ();
		}
	}
}

