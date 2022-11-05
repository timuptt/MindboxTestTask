CREATE TABLE products_db.products (
    product_id INT IDENTITY
        CONSTRAINT pk_product_id PRIMARY KEY,
    product_name NVARCHAR(50) NOT NULL
)

CREATE TABLE products_db.categories (
    category_id INT IDENTITY
	    CONSTRAINT pk_category_id PRIMARY KEY,
	category_name NVARCHAR(50) NOT NULL
)
GO


CREATE TABLE products_db.products_to_categories (
	id INT IDENTITY
	    CONSTRAINT pk_product_to_category PRIMARY KEY,
	product_id INT NOT NULL,
	    CONSTRAINT fk_products_products_to_categories
	    FOREIGN KEY (product_id) REFERENCES products_db.products(product_id)
	    ON DELETE CASCADE,
	category_id INT NOT NULL,
	    CONSTRAINT fk_categories_products_to_categories
	    FOREIGN KEY (category_id) REFERENCES products_db.categories(category_id)
)
GO

INSERT INTO products_db.products(product_name)
VALUES
    ('TestProduct1'),
    ('TestProduct2'),
    ('TestProduct3'),
    ('TestProduct4'),
    ('TestProduct5'),
    ('TestProduct6'),
    ('TestProduct7'),
    ('TestProduct8'),
    ('TestProduct9'),
    ('TestProduct10')
GO;

INSERT INTO products_db.categories(category_name)
VALUES
    ('category1'),
    ('category2'),
    ('category3'),
    ('category4'),
    ('category5')
GO;

INSERT INTO products_db.products_to_categories(product_id, category_id)
VALUES
    (1, 1),
    (1, 2),
    (3, 4),
    (3, 5),
    (4, 1),
    (5, 3),
    (5, 2),
    (8, 1),
    (9, 2),
    (9, 5)
GO;