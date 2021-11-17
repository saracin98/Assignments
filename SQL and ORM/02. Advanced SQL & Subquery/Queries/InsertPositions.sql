INSERT INTO TestDB.dbo.Positions (Id, Title, Requirements, Description, CompanyId) VALUES
(5, 'Middle Software DEveloper', '3 years in .NET', 'Some job description', 2),
(6, 'Database Administrator', '2 years in database administration', 'Some job description', 1),
(7, 'Database Administrator', '3 years in database administration', 'Some job description', 2),
(8, 'System Administrator', '3 years in system administration', 'Some job description', 2)
SELECT Id, Title, Requirements, Description, CompanyId
FROM TestDB.dbo.Positions
WHERE Title Like '%Middle%'