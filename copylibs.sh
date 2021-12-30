#!/bin/bash


if [ -z "$WINEPREFIX" ]
then
    mkdir -p output

    cp -v ./Microsoft.DirectX/bin/Debug/Microsoft.DirectX.dll output
    cp -v ./Microsoft.DirectX.Direct3DX/bin/Debug/Microsoft.DirectX.Direct3DX.dll output
    cp -v ./Microsoft.DirectX.DirectInput/bin/Debug/Microsoft.DirectX.DirectInput.dll output
    cp -v ./Microsoft.DirectX.DirectPlay/bin/Debug/Microsoft.DirectX.DirectPlay.dll output
    cp -v ./Microsoft.DirectX.Direct3D/bin/Debug/Microsoft.DirectX.Direct3D.dll output
    cp -v ./Microsoft.DirectX.DirectSound/bin/Debug/Microsoft.DirectX.DirectSound.dll output
else

    cp -v ./Microsoft.DirectX/bin/Debug/Microsoft.DirectX.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX/1.0.7982.36091__31bf3856ad364e35
    cp -v ./Microsoft.DirectX.Direct3DX/bin/Debug/Microsoft.DirectX.Direct3DX.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX.Direct3DX/2.0.0.0__31bf3856ad364e35
    cp -v ./Microsoft.DirectX.DirectInput/bin/Debug/Microsoft.DirectX.DirectInput.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX.DirectInput/1.0.2902.0__31bf3856ad364e35
    cp -v ./Microsoft.DirectX.DirectPlay/bin/Debug/Microsoft.DirectX.DirectPlay.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX.DirectPlay/1.0.2902.0__31bf3856ad364e35/
    cp -v ./Microsoft.DirectX.Direct3D/bin/Debug/Microsoft.DirectX.Direct3D.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX.Direct3D/1.0.2902.0__31bf3856ad364e35
    cp -v ./Microsoft.DirectX.DirectSound/bin/Debug/Microsoft.DirectX.DirectSound.dll $WINEPREFIX/drive_c/windows/mono/mono-2.0/lib/mono/gac/Microsoft.DirectX.DirectSound/1.0.2902.0__31bf3856ad364e35/
fi
