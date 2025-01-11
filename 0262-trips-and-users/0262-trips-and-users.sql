/* Write your T-SQL query statement below */
SELECT T.request_at as 'Day',ROUND(CAST(COUNT(CASE WHEN T.status  like 'cancelled%' THEN 1 END) AS FLOAT)/COUNT(T.request_at),2) AS 'Cancellation Rate'
FROM Trips T join Users U on T.client_id = U.users_id AND U.banned ='No'
JOIN USERS U2 ON T.driver_id = U2.users_id AND U2.banned ='No'
Where  (T.status like 'cancelled%' or T.status like 'completed' )AND T.request_at BETWEEN '2013-10-01' AND '2013-10-03'
GROUP BY T.request_at



