CREATE TABLE [dbo].[Lecture] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [SubjectId]     INT NOT NULL,
    [LectureTimeId] INT NOT NULL,
    CONSTRAINT [PK_Lecture] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Lecture_LectureTime] FOREIGN KEY ([LectureTimeId]) REFERENCES [dbo].[LectureTime] ([Id]),
    CONSTRAINT [FK_Lecture_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [dbo].[Subject] ([Id])
);

