# Write your MySQL query statement below
SELECT name,bonus
FROM Employee e left join Bonus b on e.empID=b.empId
WHERE b.bonus < 1000 OR  b.bonus is null;