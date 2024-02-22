SELECT P.Name as ProductName,
       COALESCE(STRING_AGG(C.Name, ', '), 'No categories') as Categories
FROM [dbo].Products P
    LEFT JOIN [dbo].ProductCategories PC on P.Id = PC.ProductId
    LEFT JOIN [dbo].Categories C on PC.CategoryId = C.Id
GROUP BY P.Name;