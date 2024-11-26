# Write your MySQL query statement below
SELECT w1.id 
FROM Weather w1,Weather w2
WHERE DATEDIFF(w1.recordDate,w2.recordDate)=1 and w1.temperature > w2.temperature#date diff is (todaydate,predate) will have positive 1 date.