SELECT *
FROM TestDB.dbo.Candidates as C
LEFT Outer JOIN TestDB.dbo.Candidate_Position as CP ON C.Id = CP.CandidateId
RIGHT Outer JOIN TestDB.dbo.Positions as P on CP.PositionId = P.Id
WHERE C.Id IS NOT NULL AND P.Id IS NOT NULL
ORDER BY Title 