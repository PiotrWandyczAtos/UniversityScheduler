CREATE VIEW [dbo].[vw_GetLectures]
	AS
SELECT
	L.Id as LectureId,
	S.[Name] as SubjectName,
	LT.[DayOfWeek],
	LT.StartTime,
	LT.EndTime
FROM [dbo].[Lecture] L
INNER JOIN [dbo].[LectureTime] LT
ON LT.Id = L.LectureTimeId
INNER JOIN [dbo].[Subject] S
ON S.Id = L.SubjectId