# Write your MySQL query statement below
SELECT ROUND(AVG(ORDER_DATE=CUSTOMER_PREF_DELIVERY_DATE)*100,2) AS immediate_percentage
FROM Delivery 
WHERE (customer_id,order_date) in (SELECT customer_id,min(order_date) from Delivery Group By customer_id)