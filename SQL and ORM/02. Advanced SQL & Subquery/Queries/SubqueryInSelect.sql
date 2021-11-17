SELECT C.Name,
(SELECT Count(*) FROM Positions as P Where C.Id = P.CompanyId AND P.Requirements LIKE '%JAVA%') AS CompanyName
From Companies as C
