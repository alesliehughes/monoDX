/*
 * Copyright 2020 Rémi Bernon for CodeWeavers
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

#define COBJMACROS

#include <windows.h>
#include "d3d9.h"
#include "dinput.h"

#include "wine/debug.h"

WINE_DEFAULT_DEBUG_CHANNEL(monodx);

static HMODULE hmonodx;

static HMODULE d3d9;

static IDirect3D9 *(WINAPI *pDirect3DCreate9)(UINT version);

static HMODULE dinput;

static HRESULT (WINAPI *pDirectInput8Create)(HINSTANCE,DWORD,REFIID,void**,IUnknown*);

HMODULE load_library_static(const char* name, HMODULE* static_var)
{
    HMODULE result;

    if (*static_var)
        return *static_var;

    result = LoadLibraryA(name);

    if (result && InterlockedExchangePointer((void* volatile*)static_var, result))
    {
        // Another thread beat us to it.
        FreeLibrary(result);
    }

    return result;
}

void CDECL d3d9_Create(IDirect3D9 **iface)
{
    WINE_TRACE("iface %p\n", iface);
    *iface = NULL;
    if (!pDirect3DCreate9)
    {
        HMODULE module = load_library_static("d3d9", &d3d9);
        if (!module)
            return;
        pDirect3DCreate9 = (void*)GetProcAddress(module, "Direct3DCreate9");
        if (!pDirect3DCreate9)
            return;
    }
    *iface = pDirect3DCreate9(D3D_SDK_VERSION);
    WINE_TRACE("created %p\n", *iface);
}

void CDECL d3d9_Release(IDirect3D9 *iface)
{
    WINE_TRACE("iface %p\n", iface);
    IDirect3D9_Release(iface);
}

UINT CDECL d3d9_GetAdapterCount(IDirect3D9 *iface)
{
    WINE_TRACE("iface %p\n", iface);
    return IDirect3D9_GetAdapterCount(iface);
}

UINT CDECL d3d9_GetAdapterDisplayModeCount(IDirect3D9 *iface, UINT adapter, UINT format)
{
    WINE_TRACE("iface %p, adapter %u\n", iface, adapter);
    return IDirect3D9_GetAdapterModeCount(iface, adapter, format);
}

HRESULT CDECL d3d9_GetAdapterCurrentDisplayMode(IDirect3D9 *iface, UINT adapter, D3DDISPLAYMODE *mode)
{
    WINE_TRACE("iface %p, adapter %u, mode %p\n", iface, adapter, mode);
    return IDirect3D9_GetAdapterDisplayMode(iface, adapter, mode);
}

HRESULT CDECL d3d9_GetAdapterDisplayMode(IDirect3D9 *iface, UINT adapter, UINT index, UINT format, D3DDISPLAYMODE *mode)
{
    WINE_TRACE("iface %p, adapter %u, index %u, mode %p\n", iface, adapter, index, mode);
    return IDirect3D9_EnumAdapterModes(iface, adapter, format, index, mode);
}

HRESULT CDECL d3d9_GetAdapterIdentifier(IDirect3D9 *iface, UINT adapter, UINT flags, D3DADAPTER_IDENTIFIER9 *id)
{
    WINE_TRACE("iface %p, adapter %u, flags 0x%x\n", iface, adapter, flags);
    return IDirect3D9_GetAdapterIdentifier(iface, adapter, flags, id);
}

HRESULT CDECL d3d9_GetDeviceCaps(IDirect3D9 *iface, UINT adapter, UINT type, D3DCAPS9 *caps)
{
    WINE_TRACE("iface %p, adapter %u, type %u, caps %p\n", iface, adapter, type, caps);
    return IDirect3D9_GetDeviceCaps(iface, adapter, type, caps);
}

HRESULT CDECL d3d9_CheckDeviceType(IDirect3D9 *iface, UINT adapter, D3DDEVTYPE devtype, D3DFORMAT displayformat,
	D3DFORMAT backbufferformat, BOOL windowed)
{
    WINE_TRACE("iface %p, adapter %u, devtype %u, format %u/%u, windowed\n", iface, adapter, devtype, displayformat, backbufferformat, windowed);
    return IDirect3D9_CheckDeviceType(iface, adapter, devtype, displayformat, backbufferformat, windowed);
}

HRESULT CDECL d3d9_CheckDeviceFormat(IDirect3D9 *iface, UINT adapter, D3DDEVTYPE devtype, D3DFORMAT adapterformat,
	DWORD usage, D3DRESOURCETYPE restype, D3DFORMAT checkformat)
{
    WINE_TRACE("iface %p, adapter %u, devtype %u, adapterformat %u, usage 0x%x, restype %u checkformat %u\n",
		iface, adapter, devtype, adapterformat, usage, restype, checkformat);
    return IDirect3D9_CheckDeviceFormat(iface, adapter, devtype, adapterformat, usage, restype, checkformat);
}

HRESULT CDECL d3d9_CheckDeviceMultiSampleType(IDirect3D9 *iface, UINT adapter, D3DDEVTYPE devtype, D3DFORMAT format,
	BOOL windowed, D3DMULTISAMPLE_TYPE mstype, DWORD *qualitylevels)
{
    WINE_TRACE("iface %p, adapter %u, devtype %u, format %u, windowed %u, mstype %u\n",
		iface, adapter, devtype, format, windowed, mstype);
    return IDirect3D9_CheckDeviceMultiSampleType(iface, adapter, devtype, format, windowed, mstype, qualitylevels);
}

HRESULT CDECL d3d9_CheckDepthStencilMatch(IDirect3D9 *iface, UINT adapter, D3DDEVTYPE devtype, D3DFORMAT adapterformat,
	D3DFORMAT rendertargetformat, D3DFORMAT depthstencilformat)
{
    WINE_TRACE("iface %p, adapter %u, devtype %u, adapterformat %u, rendertargetformat %u, depthsencilformat %u\n",
		iface, adapter, devtype, adapterformat, rendertargetformat, depthstencilformat);
	return IDirect3D9_CheckDepthStencilMatch(iface, adapter, devtype, adapterformat, rendertargetformat, depthstencilformat);
}

HRESULT CDECL dinput_Create(IDirectInput8 **iface)
{
    HRESULT hr;
    WINE_TRACE("iface %p\n", iface);
    *iface = NULL;
    if (!pDirectInput8Create)
    {
        HMODULE module = load_library_static("dinput8", &dinput);
        if (!module)
            return E_FAIL;
        pDirectInput8Create = (void*)GetProcAddress(module, "DirectInput8Create");
        if (!pDirectInput8Create)
            return E_FAIL;
    }
    hr = pDirectInput8Create(hmonodx, DIRECTINPUT_VERSION, &IID_IDirectInput8, (void**)iface, NULL);
    WINE_TRACE("created %p\n", *iface);
    return hr;
}

void CDECL dinput_Release(IDirectInput8 *iface)
{
    WINE_TRACE("iface %p\n", iface);
    IDirectInput8_Release(iface);
}

HRESULT CDECL dinput_CreateDevice(IDirectInput8 *iface, const GUID* guid, LPDIRECTINPUTDEVICE8 *result)
{
	HRESULT hr;

	WINE_TRACE("iface %p guid %s\n", iface, wine_dbgstr_guid(guid));

	hr = IDirectInput8_CreateDevice(iface, guid, result, NULL);

	WINE_TRACE("created %p\n", *result);
	return hr;
}

struct dinput_enumstate
{
    DIDEVICEINSTANCE *result;
    DWORD count;
    DWORD allocated;
    HRESULT hr;
};

BOOL WINAPI dinput_EnumDevicesCallback(LPCDIDEVICEINSTANCE lpddi, LPVOID pvRef)
{
    struct dinput_enumstate *state = pvRef;

    if (state->count == state->allocated)
    {
        DWORD new_allocated = state->allocated * 2 + 3;
        DIDEVICEINSTANCE *new_result = CoTaskMemAlloc(sizeof(*new_result) * new_allocated);
        if (!new_result)
        {
            state->hr = E_OUTOFMEMORY;
            return DIENUM_STOP;
        }
        if (state->result)
        {
            memcpy(new_result, state->result, sizeof(*new_result) * state->count);
            CoTaskMemFree(state->result);
        }
        state->result = new_result;
        state->allocated = new_allocated;
    }

    state->result[state->count++] = *lpddi;
    return DIENUM_CONTINUE;
}

HRESULT CDECL dinput_GetDevices(IDirectInput8 *iface, DWORD devtype, DWORD flags, DIDEVICEINSTANCE **result, DWORD *count)
{
    HRESULT hr;
    struct dinput_enumstate state = {0};

    WINE_TRACE("iface %p devtype %i flags 0x%x\n", iface, devtype, flags);

    hr = IDirectInput8_EnumDevices(iface, devtype, dinput_EnumDevicesCallback, &state, flags);

    if (FAILED(state.hr))
        hr = state.hr;

    if (SUCCEEDED(hr))
    {
        *result = state.result;
        *count = state.count;
    }
    else
    {
        *result = NULL;
        *count = 0;
        CoTaskMemFree(state.result);
    }

    return hr;
}

void CDECL dinput_device_Release(IDirectInputDevice8 *iface)
{
	WINE_TRACE("iface %p\n", iface);
	IDirectInputDevice8_Release(iface);
}

/* normally defined in dinput8.lib, but we load dinput dynamically: */
const DIOBJECTDATAFORMAT dfDIKeyboard[] = {
  { &GUID_Key,0,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(0),0},
  { &GUID_Key,1,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(1),0},
  { &GUID_Key,2,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(2),0},
  { &GUID_Key,3,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(3),0},
  { &GUID_Key,4,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(4),0},
  { &GUID_Key,5,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(5),0},
  { &GUID_Key,6,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(6),0},
  { &GUID_Key,7,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(7),0},
  { &GUID_Key,8,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(8),0},
  { &GUID_Key,9,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(9),0},
  { &GUID_Key,10,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(10),0},
  { &GUID_Key,11,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(11),0},
  { &GUID_Key,12,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(12),0},
  { &GUID_Key,13,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(13),0},
  { &GUID_Key,14,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(14),0},
  { &GUID_Key,15,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(15),0},
  { &GUID_Key,16,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(16),0},
  { &GUID_Key,17,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(17),0},
  { &GUID_Key,18,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(18),0},
  { &GUID_Key,19,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(19),0},
  { &GUID_Key,20,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(20),0},
  { &GUID_Key,21,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(21),0},
  { &GUID_Key,22,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(22),0},
  { &GUID_Key,23,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(23),0},
  { &GUID_Key,24,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(24),0},
  { &GUID_Key,25,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(25),0},
  { &GUID_Key,26,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(26),0},
  { &GUID_Key,27,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(27),0},
  { &GUID_Key,28,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(28),0},
  { &GUID_Key,29,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(29),0},
  { &GUID_Key,30,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(30),0},
  { &GUID_Key,31,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(31),0},
  { &GUID_Key,32,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(32),0},
  { &GUID_Key,33,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(33),0},
  { &GUID_Key,34,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(34),0},
  { &GUID_Key,35,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(35),0},
  { &GUID_Key,36,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(36),0},
  { &GUID_Key,37,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(37),0},
  { &GUID_Key,38,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(38),0},
  { &GUID_Key,39,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(39),0},
  { &GUID_Key,40,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(40),0},
  { &GUID_Key,41,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(41),0},
  { &GUID_Key,42,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(42),0},
  { &GUID_Key,43,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(43),0},
  { &GUID_Key,44,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(44),0},
  { &GUID_Key,45,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(45),0},
  { &GUID_Key,46,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(46),0},
  { &GUID_Key,47,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(47),0},
  { &GUID_Key,48,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(48),0},
  { &GUID_Key,49,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(49),0},
  { &GUID_Key,50,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(50),0},
  { &GUID_Key,51,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(51),0},
  { &GUID_Key,52,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(52),0},
  { &GUID_Key,53,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(53),0},
  { &GUID_Key,54,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(54),0},
  { &GUID_Key,55,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(55),0},
  { &GUID_Key,56,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(56),0},
  { &GUID_Key,57,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(57),0},
  { &GUID_Key,58,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(58),0},
  { &GUID_Key,59,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(59),0},
  { &GUID_Key,60,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(60),0},
  { &GUID_Key,61,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(61),0},
  { &GUID_Key,62,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(62),0},
  { &GUID_Key,63,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(63),0},
  { &GUID_Key,64,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(64),0},
  { &GUID_Key,65,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(65),0},
  { &GUID_Key,66,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(66),0},
  { &GUID_Key,67,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(67),0},
  { &GUID_Key,68,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(68),0},
  { &GUID_Key,69,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(69),0},
  { &GUID_Key,70,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(70),0},
  { &GUID_Key,71,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(71),0},
  { &GUID_Key,72,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(72),0},
  { &GUID_Key,73,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(73),0},
  { &GUID_Key,74,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(74),0},
  { &GUID_Key,75,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(75),0},
  { &GUID_Key,76,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(76),0},
  { &GUID_Key,77,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(77),0},
  { &GUID_Key,78,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(78),0},
  { &GUID_Key,79,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(79),0},
  { &GUID_Key,80,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(80),0},
  { &GUID_Key,81,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(81),0},
  { &GUID_Key,82,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(82),0},
  { &GUID_Key,83,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(83),0},
  { &GUID_Key,84,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(84),0},
  { &GUID_Key,85,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(85),0},
  { &GUID_Key,86,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(86),0},
  { &GUID_Key,87,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(87),0},
  { &GUID_Key,88,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(88),0},
  { &GUID_Key,89,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(89),0},
  { &GUID_Key,90,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(90),0},
  { &GUID_Key,91,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(91),0},
  { &GUID_Key,92,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(92),0},
  { &GUID_Key,93,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(93),0},
  { &GUID_Key,94,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(94),0},
  { &GUID_Key,95,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(95),0},
  { &GUID_Key,96,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(96),0},
  { &GUID_Key,97,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(97),0},
  { &GUID_Key,98,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(98),0},
  { &GUID_Key,99,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(99),0},
  { &GUID_Key,100,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(100),0},
  { &GUID_Key,101,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(101),0},
  { &GUID_Key,102,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(102),0},
  { &GUID_Key,103,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(103),0},
  { &GUID_Key,104,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(104),0},
  { &GUID_Key,105,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(105),0},
  { &GUID_Key,106,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(106),0},
  { &GUID_Key,107,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(107),0},
  { &GUID_Key,108,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(108),0},
  { &GUID_Key,109,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(109),0},
  { &GUID_Key,110,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(110),0},
  { &GUID_Key,111,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(111),0},
  { &GUID_Key,112,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(112),0},
  { &GUID_Key,113,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(113),0},
  { &GUID_Key,114,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(114),0},
  { &GUID_Key,115,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(115),0},
  { &GUID_Key,116,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(116),0},
  { &GUID_Key,117,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(117),0},
  { &GUID_Key,118,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(118),0},
  { &GUID_Key,119,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(119),0},
  { &GUID_Key,120,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(120),0},
  { &GUID_Key,121,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(121),0},
  { &GUID_Key,122,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(122),0},
  { &GUID_Key,123,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(123),0},
  { &GUID_Key,124,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(124),0},
  { &GUID_Key,125,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(125),0},
  { &GUID_Key,126,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(126),0},
  { &GUID_Key,127,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(127),0},
  { &GUID_Key,128,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(128),0},
  { &GUID_Key,129,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(129),0},
  { &GUID_Key,130,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(130),0},
  { &GUID_Key,131,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(131),0},
  { &GUID_Key,132,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(132),0},
  { &GUID_Key,133,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(133),0},
  { &GUID_Key,134,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(134),0},
  { &GUID_Key,135,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(135),0},
  { &GUID_Key,136,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(136),0},
  { &GUID_Key,137,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(137),0},
  { &GUID_Key,138,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(138),0},
  { &GUID_Key,139,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(139),0},
  { &GUID_Key,140,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(140),0},
  { &GUID_Key,141,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(141),0},
  { &GUID_Key,142,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(142),0},
  { &GUID_Key,143,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(143),0},
  { &GUID_Key,144,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(144),0},
  { &GUID_Key,145,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(145),0},
  { &GUID_Key,146,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(146),0},
  { &GUID_Key,147,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(147),0},
  { &GUID_Key,148,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(148),0},
  { &GUID_Key,149,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(149),0},
  { &GUID_Key,150,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(150),0},
  { &GUID_Key,151,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(151),0},
  { &GUID_Key,152,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(152),0},
  { &GUID_Key,153,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(153),0},
  { &GUID_Key,154,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(154),0},
  { &GUID_Key,155,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(155),0},
  { &GUID_Key,156,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(156),0},
  { &GUID_Key,157,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(157),0},
  { &GUID_Key,158,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(158),0},
  { &GUID_Key,159,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(159),0},
  { &GUID_Key,160,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(160),0},
  { &GUID_Key,161,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(161),0},
  { &GUID_Key,162,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(162),0},
  { &GUID_Key,163,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(163),0},
  { &GUID_Key,164,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(164),0},
  { &GUID_Key,165,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(165),0},
  { &GUID_Key,166,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(166),0},
  { &GUID_Key,167,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(167),0},
  { &GUID_Key,168,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(168),0},
  { &GUID_Key,169,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(169),0},
  { &GUID_Key,170,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(170),0},
  { &GUID_Key,171,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(171),0},
  { &GUID_Key,172,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(172),0},
  { &GUID_Key,173,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(173),0},
  { &GUID_Key,174,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(174),0},
  { &GUID_Key,175,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(175),0},
  { &GUID_Key,176,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(176),0},
  { &GUID_Key,177,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(177),0},
  { &GUID_Key,178,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(178),0},
  { &GUID_Key,179,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(179),0},
  { &GUID_Key,180,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(180),0},
  { &GUID_Key,181,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(181),0},
  { &GUID_Key,182,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(182),0},
  { &GUID_Key,183,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(183),0},
  { &GUID_Key,184,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(184),0},
  { &GUID_Key,185,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(185),0},
  { &GUID_Key,186,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(186),0},
  { &GUID_Key,187,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(187),0},
  { &GUID_Key,188,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(188),0},
  { &GUID_Key,189,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(189),0},
  { &GUID_Key,190,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(190),0},
  { &GUID_Key,191,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(191),0},
  { &GUID_Key,192,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(192),0},
  { &GUID_Key,193,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(193),0},
  { &GUID_Key,194,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(194),0},
  { &GUID_Key,195,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(195),0},
  { &GUID_Key,196,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(196),0},
  { &GUID_Key,197,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(197),0},
  { &GUID_Key,198,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(198),0},
  { &GUID_Key,199,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(199),0},
  { &GUID_Key,200,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(200),0},
  { &GUID_Key,201,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(201),0},
  { &GUID_Key,202,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(202),0},
  { &GUID_Key,203,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(203),0},
  { &GUID_Key,204,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(204),0},
  { &GUID_Key,205,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(205),0},
  { &GUID_Key,206,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(206),0},
  { &GUID_Key,207,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(207),0},
  { &GUID_Key,208,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(208),0},
  { &GUID_Key,209,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(209),0},
  { &GUID_Key,210,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(210),0},
  { &GUID_Key,211,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(211),0},
  { &GUID_Key,212,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(212),0},
  { &GUID_Key,213,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(213),0},
  { &GUID_Key,214,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(214),0},
  { &GUID_Key,215,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(215),0},
  { &GUID_Key,216,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(216),0},
  { &GUID_Key,217,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(217),0},
  { &GUID_Key,218,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(218),0},
  { &GUID_Key,219,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(219),0},
  { &GUID_Key,220,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(220),0},
  { &GUID_Key,221,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(221),0},
  { &GUID_Key,222,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(222),0},
  { &GUID_Key,223,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(223),0},
  { &GUID_Key,224,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(224),0},
  { &GUID_Key,225,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(225),0},
  { &GUID_Key,226,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(226),0},
  { &GUID_Key,227,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(227),0},
  { &GUID_Key,228,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(228),0},
  { &GUID_Key,229,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(229),0},
  { &GUID_Key,230,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(230),0},
  { &GUID_Key,231,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(231),0},
  { &GUID_Key,232,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(232),0},
  { &GUID_Key,233,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(233),0},
  { &GUID_Key,234,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(234),0},
  { &GUID_Key,235,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(235),0},
  { &GUID_Key,236,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(236),0},
  { &GUID_Key,237,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(237),0},
  { &GUID_Key,238,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(238),0},
  { &GUID_Key,239,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(239),0},
  { &GUID_Key,240,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(240),0},
  { &GUID_Key,241,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(241),0},
  { &GUID_Key,242,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(242),0},
  { &GUID_Key,243,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(243),0},
  { &GUID_Key,244,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(244),0},
  { &GUID_Key,245,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(245),0},
  { &GUID_Key,246,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(246),0},
  { &GUID_Key,247,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(247),0},
  { &GUID_Key,248,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(248),0},
  { &GUID_Key,249,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(249),0},
  { &GUID_Key,250,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(250),0},
  { &GUID_Key,251,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(251),0},
  { &GUID_Key,252,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(252),0},
  { &GUID_Key,253,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(253),0},
  { &GUID_Key,254,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(254),0},
  { &GUID_Key,255,DIDFT_OPTIONAL|DIDFT_BUTTON|DIDFT_MAKEINSTANCE(255),0}
};
const DIDATAFORMAT c_dfDIKeyboard = {
    sizeof(DIDATAFORMAT),
    sizeof(DIOBJECTDATAFORMAT),
    DIDF_RELAXIS,
    256,
    256,
    (LPDIOBJECTDATAFORMAT)dfDIKeyboard
};

HRESULT CDECL dinput_device_Acquire(IDirectInputDevice8 *iface)
{
	HRESULT hr;
	WINE_TRACE("iface %p\n", iface);
	hr = IDirectInputDevice8_Acquire(iface);
	if (hr == E_INVALIDARG)
	{
		/* Apparently, Managed DirectX doesn't require calling SetDataFormat before Acquiring a keyboard. */
		DIDEVICEINSTANCE info = { sizeof(info) };

		hr = IDirectInputDevice8_GetDeviceInfo(iface, &info);

		if (SUCCEEDED(hr))
		{
			BYTE type = (BYTE)info.dwDevType;
			switch (type)
			{
			case DI8DEVTYPE_KEYBOARD:
				hr = IDirectInputDevice8_SetDataFormat(iface, &c_dfDIKeyboard);
				break;
			default:
				WINE_FIXME("unhandled device type %i\n", type);
				break;
			}
		}

		if (SUCCEEDED(hr))
			hr = IDirectInputDevice8_Acquire(iface);
	}

	return hr;
}

HRESULT CDECL dinput_device_GetDeviceInfo(IDirectInputDevice8 *iface, DIDEVICEINSTANCE *info)
{
	WINE_TRACE("iface %p\n", iface);
	info->dwSize = sizeof(*info);
	return IDirectInputDevice8_GetDeviceInfo(iface, info);
}

HRESULT CDECL dinput_device_Unacquire(IDirectInputDevice8 *iface)
{
	WINE_TRACE("iface %p\n", iface);
	return IDirectInputDevice8_Unacquire(iface);
}

BOOL WINAPI DllMain(HINSTANCE instance, DWORD reason, void *res)
{
    WINE_TRACE("instance %p, reason %x, res %p\n", instance, reason, res);

    switch (reason)
    {
    case DLL_PROCESS_ATTACH:
        hmonodx = instance;
        break;
    case DLL_PROCESS_DETACH:
        FreeLibrary(d3d9);
        FreeLibrary(dinput);
        break;
    }
    return TRUE;
}
