UPDATE P SET P.Description = 'Java Job Description' from Candidates as C
INNER JOIN Candidate_Position as CP on C.Id = CP.CandidateId
INNER JOIN Positions as P on CP.PositionId =  P.Id
Where P.Requirements Like '%Java%';