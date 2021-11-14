CREATE TABLE [TestDB].[dbo].[Positions]
(
[Id]  BIGINT  NOT NULL,
[Title] VARCHAR(100) NOT NULL,
[Requirements] VARCHAR(100) NOT NULL,
[Description] VARCHAR(100) NOT NULL,
[CompanyId] BIGINT NOT NULL,
CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED ([Id]),
Constraint [Positions_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([Id])
)