/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [Id]
      ,[Title]
      ,[Requirements]
      ,[Description]
      ,[CompanyId]
  FROM [TestDB].[dbo].[Positions]
  WHERE [Title] LIKE '%Senior%'