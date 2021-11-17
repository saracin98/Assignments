SELECT Requirements, Count(*) AS Vacancies FROM TestDB.dbo.Positions
Group BY Requirements Having CONVERT(INT, SUBSTRING(Requirements,1,1)) >= 3