Use Unit18GC
Go
Select Student_Name, Course_Name, Course_Achieved, Assessor_Name
from Student, Course, CourseSchedule, Assessor
Where Student.Student_ID = CourseSchedule.Student_ID and Assessor.Assessor_ID = CourseSchedule.Assessor_ID and Course.Course_ID = CourseSchedule.Course_ID
and Course.Course_ID = '102-First Aid'
;