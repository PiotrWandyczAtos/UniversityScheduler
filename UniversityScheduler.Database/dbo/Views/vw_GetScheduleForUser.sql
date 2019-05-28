CREATE VIEW [vw_GetScheduleForUser]
	AS
SELECT
	SD.Id as SchedulePartId,
	L.Id as LectureId,
	S.[Name] as SubjectName,
	LT.[DayOfWeek],
	LT.StartTime,
	LT.EndTime,
	SD.UserId
FROM [dbo].[Schedule] SD
INNER JOIN [dbo].[Lecture] L
ON L.Id = SD.LectureId
INNER JOIN [dbo].[LectureTime] LT
ON LT.Id = L.LectureTimeId
INNER JOIN [dbo].[Subject] S
ON S.Id = L.SubjectId