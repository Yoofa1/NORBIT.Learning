-- запрос на выборку топ издательств по числу книг
SELECT TOP(5)
	publisher AS 'Издательство'
	, COUNT(book_id) AS 'Кол-во книг'
FROM books_src LEFT JOIN book_operation
ON books_src.id = book_operation.book_id
GROUP BY publisher 
ORDER BY COUNT(book_id) DESC

-- книги, которые на данный момент находятся у читателей
SELECT 
	title AS 'Название книги'
FROM books_src INNER JOIN book_operation
ON books_src.id = book_operation.id
WHERE end_date IS NULL

-- книги, которые никто никогда не брал
SELECT 
	title AS 'Название книги'
FROM books_src LEFT JOIN book_operation
ON books_src.id = book_operation.id
WHERE book_operation.id IS NULL

-- книги, которые берут чаще других
SELECT TOP(3)
	title AS 'Название книги'
	, COUNT(reader_id) AS 'Сколько брали'
FROM books_src INNER JOIN book_operation
ON books_src.id = book_operation.book_id
GROUP BY title
ORDER BY COUNT(reader_id) DESC

-- сколько книг выдал каждый сотрудник
SELECT
	surname AS 'Фамилия'
	, COUNT(book_id) AS 'Кол-во выданных книг'
FROM employee LEFT JOIN book_operation
ON employee.id = book_operation.employee_id
GROUP BY surname
ORDER BY COUNT(book_id) DESC

-- спсиок должников
SELECT
	surname AS 'Фамилия'
FROM reader LEFT JOIN book_operation
ON reader.id = book_operation.reader_id
WHERE end_date IS NULL
GROUP BY surname