/* Write your T-SQL query statement below */
SELECT name as Customers
FROM Customers C LEFT JOIN Orders O on C.id = O.customerId
WHERE O.id is null