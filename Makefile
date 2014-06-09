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
	problem3.exe \
	problem4.exe \
	problem5.exe \
	problem6.exe \
	problem7.exe \
	problem8.exe \
	problem9.exe \

problem10.exe: algorithms.fs problem10.fsx
	fsharpc algorithms.fs problem10.fsx

problem11.exe: algorithms.fs problem11.fsx
	fsharpc algorithms.fs problem11.fsx

problem12.exe: algorithms.fs problem12.fsx
	fsharpc algorithms.fs problem12.fsx

problem13.exe: algorithms.fs problem13.fsx
	fsharpc algorithms.fs problem13.fsx

problem14.exe: algorithms.fs problem14.fsx
	fsharpc algorithms.fs problem14.fsx

problem14-map.exe: algorithms.fs problem14-map.fsx
	fsharpc algorithms.fs problem14-map.fsx

problem15.exe: algorithms.fs problem15.fsx
	fsharpc algorithms.fs problem15.fsx

problem16.exe: algorithms.fs problem16.fsx
	fsharpc algorithms.fs problem16.fsx

problem17.exe: algorithms.fs problem17.fsx
	fsharpc algorithms.fs problem17.fsx

problem18.exe: algorithms.fs problem18.fsx
	fsharpc algorithms.fs problem18.fsx

problem19.exe: algorithms.fs problem19.fsx
	fsharpc algorithms.fs problem19.fsx

problem1.exe: algorithms.fs problem1.fsx
	fsharpc algorithms.fs problem1.fsx

problem20.exe: algorithms.fs problem20.fsx
	fsharpc algorithms.fs problem20.fsx

problem21.exe: algorithms.fs problem21.fsx
	fsharpc algorithms.fs problem21.fsx

problem22.exe: algorithms.fs problem22.fsx
	fsharpc algorithms.fs problem22.fsx

problem23.exe: algorithms.fs problem23.fsx
	fsharpc algorithms.fs problem23.fsx

problem24.exe: algorithms.fs problem24.fsx
	fsharpc algorithms.fs problem24.fsx

problem25.exe: algorithms.fs problem25.fsx
	fsharpc algorithms.fs problem25.fsx

problem26.exe: algorithms.fs problem26.fsx
	fsharpc algorithms.fs problem26.fsx

problem27.exe: algorithms.fs problem27.fsx
	fsharpc algorithms.fs problem27.fsx

problem28.exe: algorithms.fs problem28.fsx
	fsharpc algorithms.fs problem28.fsx

problem29.exe: algorithms.fs problem29.fsx
	fsharpc algorithms.fs problem29.fsx

problem2.exe: algorithms.fs problem2.fsx
	fsharpc algorithms.fs problem2.fsx

problem30.exe: algorithms.fs problem30.fsx
	fsharpc algorithms.fs problem30.fsx

problem31.exe: algorithms.fs problem31.fsx
	fsharpc algorithms.fs problem31.fsx

problem32.exe: algorithms.fs problem32.fsx
	fsharpc algorithms.fs problem32.fsx

problem33.exe: algorithms.fs problem33.fsx
	fsharpc algorithms.fs problem33.fsx

problem34.exe: algorithms.fs problem34.fsx
	fsharpc algorithms.fs problem34.fsx

problem35.exe: algorithms.fs problem35.fsx
	fsharpc algorithms.fs problem35.fsx

problem36.exe: algorithms.fs problem36.fsx
	fsharpc algorithms.fs problem36.fsx

problem37.exe: algorithms.fs problem37.fsx
	fsharpc algorithms.fs problem37.fsx

problem38.exe: algorithms.fs problem38.fsx
	fsharpc algorithms.fs problem38.fsx

problem3.exe: algorithms.fs problem3.fsx
	fsharpc algorithms.fs problem3.fsx

problem4.exe: algorithms.fs problem4.fsx
	fsharpc algorithms.fs problem4.fsx

problem5.exe: algorithms.fs problem5.fsx
	fsharpc algorithms.fs problem5.fsx

problem6.exe: algorithms.fs problem6.fsx
	fsharpc algorithms.fs problem6.fsx

problem7.exe: algorithms.fs problem7.fsx
	fsharpc algorithms.fs problem7.fsx

problem8.exe: algorithms.fs problem8.fsx
	fsharpc algorithms.fs problem8.fsx

problem9.exe: algorithms.fs problem9.fsx
	fsharpc algorithms.fs problem9.fsx

clean:
	rm problem*.exe
