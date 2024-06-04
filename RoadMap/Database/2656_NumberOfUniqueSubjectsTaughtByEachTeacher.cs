/* Write your T-SQL query statement below */

Select teacher_id, Count(distinct subject_id) as cnt from Teacher
Group By teacher_id;