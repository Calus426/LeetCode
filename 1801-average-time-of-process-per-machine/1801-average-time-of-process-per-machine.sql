# Write your MySQL query statement below
SELECT a.machine_id,ROUND(AVG(B.timestamp-A.timestamp),3)as processing_time
FROM Activity a ,Activity b
WHERE a.process_id= b.process_id and a.machine_id=b.machine_id and a.activity_type='start'and b.activity_type ="end"
GROUP BY a.machine_id