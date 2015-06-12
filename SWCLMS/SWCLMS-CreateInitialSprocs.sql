USE SWC_LMS
GO

--------------------------------------------------------
ALTER PROCEDURE UserViewDetails  (  --6/12 Slide #4 **DONE**
@UserID int)
 
AS
 
Select UserId, LastName, FirstName, GradeLevelID,Email, SuggestedRole --NEED ROLES
FROM LMSUser
WHERE UserID = @UserID

--------------------------------------------------------
CREATE PROCEDURE UserUpdateDetails(
@UserID int,
@FirstName varchar(30),
@LastName varchar(30),
@SuggestedRole varchar(50) = null,
@GradeLevelID tinyint = null)

AS

UPDATE LMSUser SET
FirstName = @FirstName,
LastName = @LastName,
SuggestedRole = @SuggestedRole,
GradeLevelID = @GradeLevelID

WHERE UserID = @UserID

--------------------------------------------------------
CREATE PROCEDURE UserSearch(
@UserID int,
@FirstNamePartial varchar(30) = Null,
@LastNamePartial varchar(30) = Null,
@EmailPartial varchar(50) = Null)

AS 

SELECT LastName, FirstName, Email --Should ID go in here eventually?
FROM  LMSUser
WHERE LastName LIKE @LastNamePartial OR FirstName LIKE @FirstNamePartial OR Email LIKE @EmailPartial

--------------------------------------------------------
CREATE PROCEDURE UserStudentDashboard(
@UserID int)

AS 

SELECT CourseName, CurrentGrade
FROM Roster 
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE UserID = @UserID

--------------------------------------------------------
CREATE PROCEDURE UserParentDashboard(
@UserID int)

AS

SELECT FirstName, LastName
FROM LMSUser
INNER JOIN StudentGuardian ON StudentID = UserID
WHERE GuardianID = @UserID

--------------------------------------------------------
CREATE PROCEDURE UserTeacherDashboard ( --6/9 **RUN ME**
@UserID int)

AS

SELECT CourseName, Count(UserID) AS StudentsPerCourse
FROM Roster
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE TeacherID = @UserID AND IsArchived = 0
GROUP BY CourseName

--------------------------------------------------------
CREATE PROCEDURE UserTeacherDashboardArchived ( --6/9 **RUN ME**
@UserID int)

AS

SELECT CourseName, Count(UserID) AS StudentsPerCourse
FROM Roster
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE TeacherID = @UserID AND IsArchived = 1
GROUP BY CourseName

--------------------------------------------------------
CREATE PROCEDURE AssignmentAdd  ( --6/9 **RUN ME**
@UserID int,
@CourseID int,
@AssignmentName varchar(50),
@PossiblePoints int,
@DueDate date,
@AssignmentDescription varchar(255) = NULL)

AS

INSERT INTO Assignment (AssignmentName,PossiblePoints,DueDate,AssignmentDescription)
VALUES (@AssignmentName, @PossiblePoints, @DueDate, @AssignmentDescription)
WHERE CourseID = @CourseID                                                    --Is where necessary?

--------------------------------------------------------
CREATE PROCEDURE CourseInformationGet  (  --6/10 Slide #6 **DONE**
@UserID int,
@CourseID int)

AS

SELECT CourseName,SubjectName,CurrentGrade,StartDate,EndDate,GradeLevel,CourseDescription,IsArchived,
Count(RosterID) AS TotalStudents,
Count(CurrentGrade) AS TotalByGrade
FROM Course
INNER JOIN [Subject] ON Course.SubjectID = Subject.SubjectID
INNER JOIN Roster ON Course.CourseID = Roster.CourseID
WHERE Course.CourseID = @CourseID
GROUP BY CourseName,CurrentGrade,SubjectName,StartDate,EndDate,GradeLevel,CourseDescription,IsArchived
ORDER BY CurrentGrade DESC

--------------------------------------------------------
CREATE PROCEDURE RosterGetStudentInCourse  (   --6/10 Slide #7 **DONE**
@UserID int,                            --search for students in course
@CourseID int)

AS

SELECT FirstName,LastName,Email,IsDeleted,GradeLevelID, CourseID
FROM LMSUser
INNER JOIN Roster ON LMSUser.UserID = Roster.UserID
WHERE CourseID = @CourseID AND IsDeleted = 0

--------------------------------------------------------
CREATE PROCEDURE RosterGetStudentNotInCourse  (   --6/10 Slide #7 **DONE**
@UserID int,                               --display students not in course
@CourseID int,
@LastName varchar(30) = NULL,
@GradeLevelID tinyint = NULL)

AS

SELECT FirstName,LastName,GradeLevelID,CourseID,RosterID
FROM LMSUser
LEFT JOIN Roster ON LMSUser.UserID = Roster.UserID
WHERE Roster.RosterID IS NULL AND GradeLevelID IS NOT NULL OR CourseID != @CourseID

--------------------------------------------------------
CREATE PROCEDURE RosterInsertStudent (   --6/10 Slide #7 **DONE**
@CourseID int,                           --insert student into course
@UserID int,                             --Does roster id change on delete?
@CurrentGrade varchar(3) = NULL,
@IsDeleted BIT = NULL)

AS

INSERT INTO Roster (CourseID,UserID,CurrentGrade,IsDeleted)
VALUES (@CourseID,@UserID,@CurrentGrade,@IsDeleted)

--------------------------------------------------------
CREATE PROCEDURE CourseGetGradebook  (  --6/10 Slide #8 **DONE**
@UserID int,                             
@CourseID int)

AS

SELECT LMSUser.UserID,FirstName,LastName,CurrentGrade,Percentage,AssignmentName
FROM LMSUser
INNER JOIN Roster ON LMSUser.UserID = Roster.UserID
INNER JOIN RosterAssignment ON Roster.RosterID = RosterAssignment.RosterID
INNER JOIN Assignment ON RosterAssignment.AssignmentID = Assignment.AssignmentID
WHERE Roster.CourseID = @CourseID

--------------------------------------------------------
CREATE PROCEDURE CourseGradebookAddScore  (  --6/10 Slide #8 **DONE**
@UserID int,
@RosterID int,                             
@CourseID int,
@AssignmentID int,
@PointsEarned decimal)

AS

UPDATE RosterAssignment SET
PointsEarned = @PointsEarned
FROM LMSUser
INNER JOIN Roster ON LMSUser.UserID = Roster.UserID
INNER JOIN RosterAssignment ON Roster.RosterID = RosterAssignment.RosterID
INNER JOIN Assignment ON RosterAssignment.AssignmentID = Assignment.AssignmentID
WHERE Roster.CourseID = @CourseID AND Roster.UserID = @UserID AND RosterAssignment.AssignmentID = @AssignmentID
AND RosterAssignment.RosterID = @RosterID

--------------------------------------------------------
CREATE PROCEDURE CourseAssignmentGradesSlide12  (  --6/10 Slide #12 **REVIEW**
@UserID int,                                       --2 views: all children view for parents; all student view for teacher
@CourseID int)

AS

SELECT AssignmentDescription,Percentage,Grade,DueDate  --more?
FROM Assignment
INNER JOIN RosterAssignment ON Assignment.AssignmentID = RosterAssignment.AssignmentID
WHERE CourseID = @CourseID

--------------------------------------------------------
ALTER PROCEDURE AdministratorDashboardSlide2  --(  --6/10 Slide #2 **REVIEW**
--@UserID int)

AS

SELECT UserID,ID,FirstName,LastName,Email,SuggestedRole,GradeLevelID
FROM LMSUser

SELECT *
FROM LMSUser

--------------------------------------------------------
CREATE PROCEDURE MainPageExistingUserLogin  (  --6/11 Slide #1 **REVIEW**
@UserID int,
@Email varchar(50),
@Password  --??)

AS

SELECT UserID,Email
FROM LMSUser
WHERE UserID = @UserID AND Email = @Email

--------------------------------------------------------
CREATE PROCEDURE MainPageNewUserLogin  (  --6/11 Slide #1 **REVIEW**
@UserID int,
@FirstName varchar(30),
@LastName varchar(30),
@Email varchar (50),
@Password --?
@ConfirmPassword  --?
@SuggestedRole varchar (50),
@GradeLevelID tinyint)

AS

SELECT UserID,FirstName,LastName,Email,SuggestedRole,GradeLevelID
FROM LMSUser
WHERE UserID = @UserID AND FirstName = @FirstName AND LastName = @LastName AND Email = @Email
AND SuggestedRole = @SuggestedRole AND GradeLevelID = @GradeLevelID

