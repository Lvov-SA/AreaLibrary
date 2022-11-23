 
SELECT products.name, Category.name FROM products JOIN ProductCategory ON products.id = ProductCategory.idProduct JOIN Category ON Category.id = ProductCategory.id 
UNION 
SELECT name,'non category' 
from products 
WHERE NOT EXISTS(SELECT * FROM ProductCategory WHERE products.id = ProductCategory.idProduct)

 
