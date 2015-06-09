USE SWC_LMS
GO

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

CREATE PROCEDURE UserSearch(
@UserID int,
@FirstNamePartial varchar(30) = Null,
@LastNamePartial varchar(30) = Null,
@EmailPartial varchar(50) = Null)

AS 

SELECT LastName, FirstName, Email --Should ID go in here eventually?
FROM  LMSUser
WHERE LastName LIKE @LastNamePartial OR FirstName LIKE @FirstNamePartial OR Email LIKE @EmailPartial

CREATE PROCEDURE UserStudentDashboard(
@UserID int)

AS 

SELECT CourseName, CurrentGrade
FROM Roster 
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE UserID = @UserID


CREATE PROCEDURE UserParentDashboard(
@UserID int)

AS

SELECT FirstName, LastName
FROM LMSUser
INNER JOIN StudentGuardian ON StudentID = UserID
WHERE GuardianID = @UserID

CREATE PROCEDURE UserTeacherDashboard ( --6/9 **RUN ME**
@UserID int)

AS

SELECT CourseName, Count(UserID) AS StudentsPerCourse
FROM Roster
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE TeacherID = @UserID AND IsArchived = 0
GROUP BY CourseName

CREATE PROCEDURE UserTeacherDashboardArchived ( --6/9 **RUN ME**
@UserID int)

AS

SELECT CourseName, Count(UserID) AS StudentsPerCourse
FROM Roster
INNER JOIN Course ON Course.CourseID = Roster.CourseID
WHERE TeacherID = @UserID AND IsArchived = 1
GROUP BY CourseName

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
WHERE CourseID = @CourseID












