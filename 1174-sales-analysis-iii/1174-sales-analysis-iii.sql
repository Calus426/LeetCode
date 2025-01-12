/* Write your T-SQL query statement below */
SELECT distinct S.product_id,P.product_name
FROM Sales S join Product P on S.product_id = P.product_id
WHERE S.product_id IN (
    SELECT product_id From Sales GROUP BY product_id 
    HAVING MAX(sale_date) between '2019-01-01' and '2019-03-31' and MIN(sale_date) between '2019-01-01' and '2019-03-31')
