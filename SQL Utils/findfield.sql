SELECT c.name  AS 'ColumnName', t.name AS 'TableName'
FROM sys.columns c
JOIN sys.tables t ON c.object_id = t.object_id
WHERE c.name LIKE 'column name you want%'
ORDER BY TableName, ColumnName;