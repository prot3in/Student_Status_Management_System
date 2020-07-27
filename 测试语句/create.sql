create table course(
cno char(10) not null,
cname char(20) not null,
creadit int not null,
ctype int not null,
primary key (cno),
check (ctype>=0 and ctype<=3)
)

create table student(
sno char(11) not null,
sname char(20) not null,
ssex char(4) not null,
sbirth date,
smajor char(20),
scollege char (20),
primary key(sno),
check (ssex in ('ÄĞ','Å®'))
)

create table sc(
term int not null,
ctype char,
sno char(11) not null,
cno char(10) not null,
grade int not null,
primary key(sno,cno),
foreign key (sno) references student(sno),
foreign key (cno) references course(cno),
check (term >=1 and term <=8 ),
check (grade >=0 and grade <=100)
)

create table teacher(
tno char(11) not null,
tname char(10) not null,
primary key(tno)
)

create table tc(
tno char(11) not null,
cno char(10) not null,
primary key(tno,cno),
foreign key (tno) references teacher(tno),
foreign key (cno) references course(cno)
)

create table command(
term int not null,
bx int ,
xx int ,
rx int ,
check (term>=1 and term <=8)
)


