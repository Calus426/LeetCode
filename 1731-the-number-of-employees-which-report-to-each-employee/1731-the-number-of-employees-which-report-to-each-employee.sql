SELECT m.employee_id,m.name,COUNT(e.reports_to) AS reports_count,ROUND(SUM(e.age)*1.0/COUNT(e.reports_to),0) AS  average_age 
FROM EMPLOYEES e join EMPLOYEES m on e.reports_to = m.employee_id
GROUP BY e.reports_to,m.employee_id,m.name
ORDER BY m.employee_id