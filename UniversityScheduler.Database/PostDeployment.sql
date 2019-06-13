/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

BEGIN

DECLARE @subjectId1 INT;
DECLARE @subjectId2 INT;
DECLARE @lectureTimeId1 INT;
DECLARE @lectureTimeId2 INT;
DECLARE @lectureTimeId3 INT;

INSERT INTO [dbo].[Subject] ([Name]) VALUES ('Elektrotechnika I')
SET @subjectId1 = SCOPE_IDENTITY();

INSERT INTO [dbo].[Subject] ([Name]) VALUES ('Programowanie II')
SET @subjectId2 = SCOPE_IDENTITY();

INSERT INTO [dbo].[LectureTime] ([DayOfWeek], [StartTime], [EndTime]) VALUES (3, '07:00:00.0000000', '07:50:00.0000000')
SET @lectureTimeId1 = SCOPE_IDENTITY();

INSERT INTO [dbo].[LectureTime] ([DayOfWeek], [StartTime], [EndTime]) VALUES (3, '11:00:00.0000000', '11:50:00.0000000')
SET @lectureTimeId2 = SCOPE_IDENTITY();

INSERT INTO [dbo].[LectureTime] ([DayOfWeek], [StartTime], [EndTime]) VALUES (4, '14:00:00.0000000', '14:50:00.0000000')
SET @lectureTimeId2 = SCOPE_IDENTITY();

INSERT INTO [dbo].[Lecture] (SubjectId, LectureTimeId) VALUES (@subjectId1, @lectureTimeId1)
INSERT INTO [dbo].[Lecture] (SubjectId, LectureTimeId) VALUES (@subjectId2, @lectureTimeId2)
INSERT INTO [dbo].[Lecture] (SubjectId, LectureTimeId) VALUES (@subjectId2, @lectureTimeId3)

END