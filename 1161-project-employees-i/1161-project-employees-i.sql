# Write your MySQL query statement below
SELECT P.project_id ,ROUND(AVG(E.experience_years),2) as average_years 
FROM Project P cross join Employee E on P.employee_id = E.employee_id
GROUP BY PROJECT_ID