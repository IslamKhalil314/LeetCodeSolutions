/* Write your T-SQL query statement below */

select s.user_id , case when cc.confirmedAction is null or c.allAction is null then 0 else Round( CAST(cc.confirmedAction  AS float) / CAST( c.allAction  AS float) , 2) end confirmation_rate
from   Signups s
left join (Select user_id , count (action) allAction  from Confirmations 
group by user_id ) c
on s.user_id = c.user_id 
left join (Select user_id , count (action) confirmedAction  from Confirmations 
where action = 'confirmed'
group by user_id ) cc
on s.user_id = cc.user_id

