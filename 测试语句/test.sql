
	select sum(credit)
	from sc,course 
	where sno = '18180100001' and grade<60 and sc.ctype=1 and sc.cno = course.cno 
	go
	select sum(credit)
	from sc,course 
	where sno = '18180100062' and grade<90 and sc.ctype=3 and sc.cno = course.cno 
	go
	select term , sum(credit)
	from sc,course
	where grade<95 and sc.cno = course.cno and sc.ctype = 1
	group by term 
	/*group by term、*/
	go
	select credit from sc, course where grade<60 and sc.sno = '18180100086' and sc.cno = course.cno and sc.ctype = 1