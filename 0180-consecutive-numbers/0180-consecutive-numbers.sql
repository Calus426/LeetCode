/* Write your T-SQL query statement below */
SELECT distinct F.num as ConsecutiveNums 
FROM Logs F,Logs S,Logs T
WHERE F.id = S.id -1 and F.num = S.num
and S.id = T.id -1 and S.num = T.num