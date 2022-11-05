SELECT
    p.product_name AS 'Product Name',
    c.category_name AS 'Product Category'
FROM
    products_db.products p
LEFT JOIN
       products_db.products_to_categories ptc ON p.product_id = ptc.product_id
LEFT JOIN
       products_db.categories c ON ptc.category_id = c.category_id;

-- Возможно, можно оптимизировать количество логических чтений с помощью индекса
