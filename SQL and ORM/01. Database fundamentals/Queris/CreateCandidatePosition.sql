CREATE TABLE [TestDB].[dbo].[Candidate_Position] (
[CandidateId] BIGINT NOT NULL,
[PositionId] BIGINT NOT NULL,
CONSTRAINT [FK_Candidate] FOREIGN KEY ([CandidateId]) REFERENCES [TestDB].[dbo].[Candidates] ([Id]),
CONSTRAINT [FK_Position] FOREIGN KEY ([PositionId]) REFERENCES [TestDB].[dbo].[Positions] ([Id])
)