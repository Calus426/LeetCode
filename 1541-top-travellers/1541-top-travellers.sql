/* Write your T-SQL query statement below */
SELECT U.NAME AS name,
CASE
    WHEN SUM(R.distance) IS NOT NULL THEN SUM(R.distance)
    ELSE 0
END
AS travelled_distance
FROM USERS U FULL OUTER JOIN RIDES R ON U.ID = R.USER_ID
WHERE U.NAME IS NOT NULL
GROUP BY R.USER_ID,U.NAME
ORDER BY travelled_distance DESC, name 
