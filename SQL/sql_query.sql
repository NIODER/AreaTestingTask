-- Пусть таблица категорий называется categories, а таблица продуктов products.
-- А промежуточная таблица - catprod
-- Идентификаторы хранятся в атрибутах с именем "id".
SELECT (products.name, categories.name) FROM products
LEFT JOIN catprod
ON products.id = catprod.product_id
INNER JOIN categories
ON catprod.category_id = categories.id;
