SELECT P.Title, CASE P.Title
WHEN 'Junior Software Developer' THEN '0-1 years of experience in BE'
WHEN 'Middle Software DEveloper' THEN '3-5 years of experience in BE' ELSE P.Requirements
END AS 'New Requirements'
FROM Positions as P