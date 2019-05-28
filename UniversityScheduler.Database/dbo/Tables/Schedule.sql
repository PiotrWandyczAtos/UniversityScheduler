CREATE TABLE [dbo].[Schedule] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [UserId]    NVARCHAR (450) NOT NULL,
    [LectureId] INT            NOT NULL,
    CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Plan_Lecture] FOREIGN KEY ([LectureId]) REFERENCES [dbo].[Lecture] ([Id]),
    CONSTRAINT [FK_Plan_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id])
);

