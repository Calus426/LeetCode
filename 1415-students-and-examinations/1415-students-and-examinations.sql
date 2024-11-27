# Write your MySQL query statement below
SELECT s.student_id , s.student_name, su.subject_name,count(e.student_id) as  attended_exams #take e.student to count their exam time
FROM Students s cross join Subjects su LEFT JOIN Examinations e   #crossjoin to ensure every student have every subject
on e.student_id= s.student_id and e.subject_name = su.subject_name
GROUP BY student_id,student_name,subject_name
ORDER BY student_id,student_name,subject_name

