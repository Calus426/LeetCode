--Write your MySQL query statement below

SELECT sell_date, count(distinct product ) as num_sold, STRING_AGG(product,',') as products
FROM
(SELECT DISTINCT * from Activities ) as t
GROUP BY sell_date

