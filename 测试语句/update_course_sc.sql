update sc
set ctype= 1
where cno like '%1'


update sc
set ctype= '2'
where cno like '%2'

update sc
set ctype= '3'
where cno like '%3'

update sc
set grade=90
where sno = '18180100062'

update sc
set grade=40
where sno = '18180100086'

update course
set credit = 20
