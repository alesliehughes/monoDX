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

namespace Microsoft.DirectX.DirectInput
{
	public enum PropertyType
	{
		Granularity = 3,
		TypeName = 26,
		VendorIdentityProductId = 24,
		ScanCode = 23,
		AppData = 22,
		CalibrationPoints = 21,
		KeyName = 20,
		LogicalRange = 19,
		PhysicalRange = 18,
		GetPortDisplayName = 16,
		JoystickId = 15,
		ProductName = 14,
		InstanceName = 13,
		GuidAndPath = 12,
		Calibration = 11,
		CalibrationMode = 10,
		AutoCenter = 9,
		ForceFeedbackLoad = 8,
		ForceFeedbackGain = 7,
		DeadZone = 5,
		Range = 4,
		AxisMode = 2,
		Saturation = 6,
		BufferSize = 1,
		UserName = 25
	}
}

