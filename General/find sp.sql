select so.Name as 'SP Name', sc.text as 'SP Text', *
from syscomments sc
inner join sysobjects so on so.id = sc.id
where sc.text like '%IsMapped%'