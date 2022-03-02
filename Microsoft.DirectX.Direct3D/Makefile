COMPILE_LIB=csc -target:library

LIB_FLAGS=-unsafe -delaysign+ -keyfile:../reactive.pub -langversion:8.0 -nostdlib -noconfig

LIB_REFS=-r:mscorlib.dll -r:System.dll -r:System.Drawing.dll -r:System.Windows.Forms.dll -r:Microsoft.VisualC.dll

LIB_REF_FILES=../Microsoft.DirectX/Microsoft.DirectX.dll

LIB_SRCS=$(shell cat sources.list)

all: Microsoft.DirectX.Direct3D.dll

Microsoft.DirectX.Direct3D.dll: sources.list $(LIB_SRCS) $(LIB_REF_FILES) ../FixupConstructors/FixupConstructors.exe
	$(COMPILE_LIB) $(LIB_FLAGS) $(LIB_REFS) $(LIB_REF_FILES:%=-r:%) -out:$@ @sources.list
	mono ../FixupConstructors/FixupConstructors.exe $@
	sn -R $@ ../mono.snk
