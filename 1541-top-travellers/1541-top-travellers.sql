/* Write your T-SQL query statement below */
SELECT U.NAME AS name, ISNULL(SUM(R.distance),0)
AS travelled_distance
FROM USERS U LEFT JOIN RIDES R ON U.ID = R.USER_ID
GROUP BY R.USER_ID,U.NAME
ORDER BY travelled_distance DESC, name 
