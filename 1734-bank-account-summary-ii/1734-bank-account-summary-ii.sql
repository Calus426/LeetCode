/* Write your T-SQL query statement below */

SELECT U.name, SUM(T.amount) AS balance
FROM Transactions T INNER JOIN Users U on U.account = T.account
GROUP BY T.account, U.name
HAVING SUM(T.amount) > 10000