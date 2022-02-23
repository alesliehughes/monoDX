C_SRCS = \
    main.c \

H_SRCS = \
    ../wine/debug.h \
    ../wine/heap.h \

all: monodx.dll
.PHONY: all

%.o: $(SRCDIR)/%.c
	$(MINGW)-gcc -o $@ $(CFLAGS) -D_WIN32_WINNT=0x0602 --std=c99 -c -Wall -Wno-format -Werror -Wno-pragma-pack -municode -I$(SRCDIR)/.. $<

debug.o: $(SRCDIR)/../wine/debug.c
	$(MINGW)-gcc -o $@ $(CFLAGS) -D_WIN32_WINNT=0x0602 -D__WINESRC__ --std=c99 -c -Wall -Wno-format -Werror -I$(SRCDIR)/.. $<

monodx.dll: $(C_SRCS:%.c=%.o) debug.o $(H_SRCS:%=$(SRCDIR)/%)
	$(MINGW)-gcc -o $@ $(LDFLAGS) -shared -Wl,--kill-at $(C_SRCS:%.c=%.o) debug.o -luuid -ldxguid -lgdi32 -lole32
