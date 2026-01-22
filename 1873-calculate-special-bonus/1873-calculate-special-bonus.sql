/* Write your T-SQL query statement below */

SELECT EMPLOYEE_ID,
CASE
    WHEN EMPLOYEE_ID%2 <>0 AND NAME NOT LIKE 'M%' THEN SALARY
    ELSE 0
END AS bonus
FROM EMPLOYEES
ORDER BY employee_id