CREATE TABLE [dbo].[LectureTime] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [DayOfWeek] INT      NOT NULL,
    [StartTime] TIME (7) NOT NULL,
    [EndTime]   TIME (7) NOT NULL,
    CONSTRAINT [PK_LectureTime] PRIMARY KEY CLUSTERED ([Id] ASC)
);

