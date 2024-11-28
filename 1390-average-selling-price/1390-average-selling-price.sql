
# Write your MySQL query statement below
SELECT P.product_id,IFNULL(round(SUM(P.price*US.units)/SUM(US.units),2),0)as  average_price 
FROM Prices P left join UnitsSold US on P.product_id = US.product_id and US.purchase_date between P.start_date and P.end_date

GROUP BY p.product_id