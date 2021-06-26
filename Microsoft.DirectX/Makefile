COMPILE_LIB=csc -target:library

LIB_FLAGS=-unsafe -delaysign+ -keyfile:../reactive.pub -langversion:8.0 -nostdlib -noconfig

LIB_REFS=-r:mscorlib.dll -r:System.dll

LIB_REF_FILES=

LIB_SRCS=$(shell cat sources.list)

all: Microsoft.DirectX.dll

Microsoft.DirectX.dll: sources.list $(LIB_SRCS) $(LIB_REF_FILES)
	$(COMPILE_LIB) $(LIB_FLAGS) $(LIB_REFS) $(LIB_REF_FILES:%=-r:%) -out:$@ @sources.list
	sn -R $@ ../mono.snk
