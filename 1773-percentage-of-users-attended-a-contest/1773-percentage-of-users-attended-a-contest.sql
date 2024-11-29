# Write your MySQL query statement below
SELECT R.contest_id,ROUND((COUNT(U.user_id)/(Select Count(user_id)from Users))*100,2) AS percentage
FROM Users U  right join Register R on U.user_id=R.user_id
GROUP BY R.Contest_id
ORDER BY percentage Desc, R.contest_id asc