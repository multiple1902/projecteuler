FSHARPC=fsharpc --define:DEBUG

all: \
	problem10.exe \
	problem11.exe \
	problem12.exe \
	problem13.exe \
	problem14.exe \
	problem14-map.exe \
	problem15.exe \
	problem16.exe \
	problem17.exe \
	problem18.exe \
	problem19.exe \
	problem1.exe \
	problem20.exe \
	problem21.exe \
	problem22.exe \
	problem23.exe \
	problem24.exe \
	problem25.exe \
	problem26.exe \
	problem27.exe \
	problem28.exe \
	problem29.exe \
	problem2.exe \
	problem30.exe \
	problem31.exe \
	problem32.exe \
	problem33.exe \
	problem34.exe \
	problem35.exe \
	problem36.exe \
	problem37.exe \
	problem38.exe \
	problem39.exe \
	problem3.exe \
	problem40.exe \
	problem41.exe \
	problem42.exe \
	problem43.exe \
	problem43-nextperm.exe \
	problem44.exe \
	problem45.exe \
	problem46.exe \
	problem47.exe \
	problem48.exe \
	problem49.exe \
	problem4.exe \
	problem50.exe \
	problem51.exe \
	problem5.exe \
	problem6.exe \
	problem7.exe \
	problem8.exe \
	problem9.exe \

problem10.exe: problem10.fsx
	$(FSHARPC) algorithms.fs problem10.fsx

problem11.exe: problem11.fsx
	$(FSHARPC) algorithms.fs problem11.fsx

problem12.exe: problem12.fsx
	$(FSHARPC) algorithms.fs problem12.fsx

problem13.exe: problem13.fsx
	$(FSHARPC) algorithms.fs problem13.fsx

problem14.exe: problem14.fsx
	$(FSHARPC) algorithms.fs problem14.fsx

problem14-map.exe: problem14-map.fsx
	$(FSHARPC) algorithms.fs problem14-map.fsx

problem15.exe: problem15.fsx
	$(FSHARPC) algorithms.fs problem15.fsx

problem16.exe: problem16.fsx
	$(FSHARPC) algorithms.fs problem16.fsx

problem17.exe: problem17.fsx
	$(FSHARPC) algorithms.fs problem17.fsx

problem18.exe: problem18.fsx
	$(FSHARPC) algorithms.fs problem18.fsx

problem19.exe: problem19.fsx
	$(FSHARPC) algorithms.fs problem19.fsx

problem1.exe: problem1.fsx
	$(FSHARPC) algorithms.fs problem1.fsx

problem20.exe: problem20.fsx
	$(FSHARPC) algorithms.fs problem20.fsx

problem21.exe: problem21.fsx
	$(FSHARPC) algorithms.fs problem21.fsx

problem22.exe: problem22.fsx
	$(FSHARPC) algorithms.fs problem22.fsx

problem23.exe: problem23.fsx
	$(FSHARPC) algorithms.fs problem23.fsx

problem24.exe: problem24.fsx
	$(FSHARPC) algorithms.fs problem24.fsx

problem25.exe: problem25.fsx
	$(FSHARPC) algorithms.fs problem25.fsx

problem26.exe: problem26.fsx
	$(FSHARPC) algorithms.fs problem26.fsx

problem27.exe: problem27.fsx
	$(FSHARPC) algorithms.fs problem27.fsx

problem28.exe: problem28.fsx
	$(FSHARPC) algorithms.fs problem28.fsx

problem29.exe: problem29.fsx
	$(FSHARPC) algorithms.fs problem29.fsx

problem2.exe: problem2.fsx
	$(FSHARPC) algorithms.fs problem2.fsx

problem30.exe: problem30.fsx
	$(FSHARPC) algorithms.fs problem30.fsx

problem31.exe: problem31.fsx
	$(FSHARPC) algorithms.fs problem31.fsx

problem32.exe: problem32.fsx
	$(FSHARPC) algorithms.fs problem32.fsx

problem33.exe: problem33.fsx
	$(FSHARPC) algorithms.fs problem33.fsx

problem34.exe: problem34.fsx
	$(FSHARPC) algorithms.fs problem34.fsx

problem35.exe: problem35.fsx
	$(FSHARPC) algorithms.fs problem35.fsx

problem36.exe: problem36.fsx
	$(FSHARPC) algorithms.fs problem36.fsx

problem37.exe: problem37.fsx
	$(FSHARPC) algorithms.fs problem37.fsx

problem38.exe: problem38.fsx
	$(FSHARPC) algorithms.fs problem38.fsx

problem39.exe: problem39.fsx
	$(FSHARPC) algorithms.fs problem39.fsx

problem3.exe: problem3.fsx
	$(FSHARPC) algorithms.fs problem3.fsx

problem40.exe: problem40.fsx
	$(FSHARPC) algorithms.fs problem40.fsx

problem41.exe: problem41.fsx
	$(FSHARPC) algorithms.fs problem41.fsx

problem42.exe: problem42.fsx
	$(FSHARPC) algorithms.fs problem42.fsx

problem43.exe: problem43.fsx
	$(FSHARPC) algorithms.fs problem43.fsx

problem43-nextperm.exe: problem43-nextperm.fsx
	$(FSHARPC) algorithms.fs problem43-nextperm.fsx

problem44.exe: problem44.fsx
	$(FSHARPC) algorithms.fs problem44.fsx

problem45.exe: problem45.fsx
	$(FSHARPC) algorithms.fs problem45.fsx

problem46.exe: problem46.fsx
	$(FSHARPC) algorithms.fs problem46.fsx

problem47.exe: problem47.fsx
	$(FSHARPC) algorithms.fs problem47.fsx

problem48.exe: problem48.fsx
	$(FSHARPC) algorithms.fs problem48.fsx

problem49.exe: problem49.fsx
	$(FSHARPC) algorithms.fs problem49.fsx

problem4.exe: problem4.fsx
	$(FSHARPC) algorithms.fs problem4.fsx

problem50.exe: problem50.fsx
	$(FSHARPC) algorithms.fs problem50.fsx

problem51.exe: problem51.fsx
	$(FSHARPC) algorithms.fs problem51.fsx

problem5.exe: problem5.fsx
	$(FSHARPC) algorithms.fs problem5.fsx

problem6.exe: problem6.fsx
	$(FSHARPC) algorithms.fs problem6.fsx

problem7.exe: problem7.fsx
	$(FSHARPC) algorithms.fs problem7.fsx

problem8.exe: problem8.fsx
	$(FSHARPC) algorithms.fs problem8.fsx

problem9.exe: problem9.fsx
	$(FSHARPC) algorithms.fs problem9.fsx

clean:
	rm problem*.exe problem*.res
