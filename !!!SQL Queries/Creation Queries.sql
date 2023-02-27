Create database [Unit18GC] 

Go 



Use [Unit18GC] 

Go 

Create Table dbo.Venue( 

Venue_ID varchar(3), 

Venue_Name varchar(30), 

Venue_Address varchar(70), 

Venue_Postcode varchar (15), 

Venue_Mobile varchar (15), 

Manager_Name varchar (15), 

Venue_Email varchar(30), 

Venue_Cost integer, 

Google_Map varchar(300) 

 

primary key (Venue_ID) 

 

); 

 

Use [Unit18GC] 

Go 

Create Table dbo.Student( 

Student_ID int identity (1,1), 

Student_Name varchar(30), 

Student_Address varchar(30), 

Student_Postcode varchar (15), 

Student_Email varchar(35), 

Student_Mobile varchar (12), 

Student_Notes varchar (30), 

 

primary key (Student_ID) 

 

); 

 

Use [Unit18GC] 

Go 

Create Table dbo.Assessor( 

Assessor_ID varchar (10), 

Assessor_Name varchar(30), 

Assessor_Address varchar(70), 

Assessor_Postcode varchar (15), 

Assessor_Mobile varchar (12), 

Assessor_Email varchar (35), 

 

primary key (Assessor_ID) 

 

); 

 

Use [Unit18GC] 

Go 

Create Table dbo.Course( 

Course_ID varchar (25), 

Course_Name varchar(30), 

Course_Cost integer, 

Course_Duration varchar(40), 

 

primary key (Course_ID) 

 

); 

 

Use [Unit18GC] 

Go 

Create Table dbo.CourseSchedule( 

Course_Schedule_ID varchar (10), 

Course_ID varchar(25), 

Assessor_ID varchar(10), 

Venue_ID varchar(3), 

Student_ID int, 

Course_Achieved bit, 

Course_Date date 

 

primary key (Course_Schedule_ID) 

Foreign Key (Course_ID) References Course(Course_ID), 

Foreign Key (Assessor_ID) References Assessor(Assessor_ID), 

Foreign Key (Venue_ID) References Venue(Venue_ID), 

Foreign Key (Student_ID) References Student(Student_ID), 

 

 

); 

 
 

 