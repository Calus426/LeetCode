/* Write your T-SQL query statement below */
SELECT score,dense_rank() over (ORDER BY score desc) as rank
from Scores 