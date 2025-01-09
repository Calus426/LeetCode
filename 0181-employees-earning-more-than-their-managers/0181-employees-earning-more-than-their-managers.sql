/* Write your T-SQL query statement below */
SELECT E.name as Employee
FROM Employee E JOIN Employee M on E.managerId = M.id
WHERE E.salary > M.salary