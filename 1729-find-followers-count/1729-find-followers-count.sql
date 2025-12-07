SELECT user_id,count(*) as followers_count
FROM Followers
GROUP BY user_id