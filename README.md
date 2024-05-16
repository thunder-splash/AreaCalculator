Ответ на третий вопрос: 
Если есть промежуточная таблица ProductCategories, хранящая соответствия ProductId и CategoryID, то запрос будет выглядеть так:

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN ProductCategories PC ON P.ProductID = PC.ProductID
LEFT JOIN Categories C ON PC.CategoryID = C.CategoryID;

Допустим наша БД не хранит такую таблицу соответствий, но в таблице Products программист предусмотрительно добавил поле CategoryID, которое напрямую
ссылается на CategoryID в таблице Categories, тогда запрос будет выглядеть вот так:

SELECT P.ProductName, C.CategoryName
FROM Products P
LEFT JOIN Categories C ON P.CategoryID = C.CategoryID;
