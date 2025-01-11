/* Write your T-SQL query statement below */
SELECT D.name as Department,E.name as Employee,E.salary
FROM Employee E join Department D on E.departmentId = D.id
join (SELECT MAX(salary) as salary,departmentId FROM Employee GROUP BY departmentId) as M ON E.salary = M.salary and E.departmentId = M.departmentId
