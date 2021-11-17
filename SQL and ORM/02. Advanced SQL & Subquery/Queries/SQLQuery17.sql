SELECT C.Name FROM Companies as C
WHERE (
SELECT AVG(CONVERT(INT,SUBSTRING(P.Requirements,1,1))) FROM Positions as P 
INNER JOIN Companies as C ON P.CompanyId = C.Id
) >= 2