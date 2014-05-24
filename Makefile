all: \
	problem10.exe \
	problem11.exe \
	problem12.exe \
	problem13.exe \
	problem14.exe \
	problem14-map.exe \
	problem15.exe \
	problem1.exe \
	problem2.exe \
	problem3.exe \
	problem4.exe \
	problem5.exe \
	problem6.exe \
	problem7.exe \
	problem8.exe \
	problem9.exe \

problem10.exe: problem10.fsx
	fsharpc problem10.fsx

problem11.exe: problem11.fsx
	fsharpc problem11.fsx

problem12.exe: problem12.fsx
	fsharpc problem12.fsx

problem13.exe: problem13.fsx
	fsharpc problem13.fsx

problem14.exe: problem14.fsx
	fsharpc problem14.fsx

problem14-map.exe: problem14-map.fsx
	fsharpc problem14-map.fsx

problem15.exe: problem15.fsx
	fsharpc problem15.fsx

problem1.exe: problem1.fsx
	fsharpc problem1.fsx

problem2.exe: problem2.fsx
	fsharpc problem2.fsx

problem3.exe: problem3.fsx
	fsharpc problem3.fsx

problem4.exe: problem4.fsx
	fsharpc problem4.fsx

problem5.exe: problem5.fsx
	fsharpc problem5.fsx

problem6.exe: problem6.fsx
	fsharpc problem6.fsx

problem7.exe: problem7.fsx
	fsharpc problem7.fsx

problem8.exe: problem8.fsx
	fsharpc problem8.fsx

problem9.exe: problem9.fsx
	fsharpc problem9.fsx

clean:
	rm problem*.exe
