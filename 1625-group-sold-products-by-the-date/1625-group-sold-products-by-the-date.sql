--Write your MySQL query statement below

SELECT sell_date, count(product) as num_sold, STRING_AGG(product,',') as products
FROM
(SELECT DISTINCT * from Activities ) as t --it will sort the table if use distinct
GROUP BY sell_date

