IF NOT EXISTS (SELECT 1 FROM dbo.Quote)
BEGIN
	INSERT INTO dbo.Quote ([Date], [Names], [Quote], [Visibility])
	VALUES ('2020-1-1', 'Tester1', 'Haha the fuckkk', 0),
	('2021-1-1', 'Tester2', 'WTF', 0),
	('2022-1-1', 'Tester1, Tester2', 'FROM DA FUTURE', 0)
END