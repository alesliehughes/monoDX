WIDL=widl

%.tlb: %.idl
	$(WIDL) -t $< -o $@

all: dpaddr.tlb
	echo "done"

