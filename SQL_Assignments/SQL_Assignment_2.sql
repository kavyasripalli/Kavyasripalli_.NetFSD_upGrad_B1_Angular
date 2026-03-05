CREATE DATABASE StoreDB;

USE StoreDB;

CREATE TABLE customers (
customer_id INT PRIMARY KEY,
first_name VARCHAR(50),
last_name VARCHAR(50)
);

CREATE TABLE stores (
store_id INT PRIMARY KEY,
store_name VARCHAR(100)
);

CREATE TABLE brands (
brand_id INT PRIMARY KEY,
brand_name VARCHAR(100)
);

CREATE TABLE categories (
category_id INT PRIMARY KEY,
category_name VARCHAR(100)
);

CREATE TABLE products (
product_id INT PRIMARY KEY,
product_name VARCHAR(100),
brand_id INT,
category_id INT,
model_year INT,
list_price DECIMAL(10,2),
FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

CREATE TABLE orders (
order_id INT PRIMARY KEY,
customer_id INT,
store_id INT,
order_date DATE,
order_status INT,
FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

CREATE TABLE order_items (
item_id INT PRIMARY KEY,
order_id INT,
product_id INT,
quantity INT,
list_price DECIMAL(10,2),
discount DECIMAL(4,2),
FOREIGN KEY (order_id) REFERENCES orders(order_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE stocks (
store_id INT,
product_id INT,
quantity INT,
PRIMARY KEY (store_id, product_id),
FOREIGN KEY (store_id) REFERENCES stores(store_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
);

INSERT INTO customers VALUES
(1,'Kavya','Sri'),
(2,'Sri','Adhi'),
(3,'Sai','Kiran'),
(4,'Sri','Kavya');

INSERT INTO stores VALUES
(1,'Hyderabad Store'),
(2,'Bangalore Store');

INSERT INTO brands VALUES
(1,'Nike'),
(2,'Adidas'),
(3,'Puma');

INSERT INTO categories VALUES
(1,'Shoes'),
(2,'Clothing'),
(3,'Accessories');

INSERT INTO products VALUES
(1,'Running Shoes',1,1,2023,1200),
(2,'Sports T-Shirt',2,2,2022,700),
(3,'Cap',3,3,2023,300),
(4,'Training Shoes',1,1,2024,1500);

INSERT INTO orders VALUES
(1,1,1,'2025-01-10',1),
(2,2,2,'2025-01-12',4),
(3,3,1,'2025-01-15',4),
(4,4,2,'2025-01-18',2);

INSERT INTO order_items VALUES
(1,1,1,2,1200,0.10),
(2,2,2,1,700,0.05),
(3,3,4,1,1500,0.15),
(4,2,3,3,300,0.00);

INSERT INTO stocks VALUES
(1,1,50),
(1,2,30),
(1,3,20),
(2,2,40),
(2,4,25);

SELECT c.first_name, c.last_name, o.order_id, o.order_date, o.order_status
FROM customers c
INNER JOIN orders o ON c.customer_id = o.customer_id
WHERE o.order_status = 1 OR o.order_status = 4
ORDER BY o.order_date DESC;

SELECT p.product_name, b.brand_name, c.category_name, p.model_year, p.list_price
FROM products p
INNER JOIN brands b ON p.brand_id = b.brand_id
INNER JOIN categories c ON p.category_id = c.category_id
WHERE p.list_price > 500
ORDER BY p.list_price ASC;

SELECT s.store_name,
SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales_amount
FROM stores s
INNER JOIN orders o ON s.store_id = o.store_id
INNER JOIN order_items oi ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name
ORDER BY total_sales_amount DESC;

SELECT p.product_name, s.store_name, st.quantity AS available_stock_quantity,
SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p ON st.product_id = p.product_id
INNER JOIN stores s ON st.store_id = s.store_id
LEFT JOIN order_items oi ON st.product_id = oi.product_id
GROUP BY p.product_name, s.store_name, st.quantity
ORDER BY p.product_name;