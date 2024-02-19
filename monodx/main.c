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
