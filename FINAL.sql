CREATE DATABASE FINAL
GO

USE FINAL
GO



-- Create the Agents table
CREATE TABLE Agents (
    AgentID INT PRIMARY KEY,
    AgentName VARCHAR(50) NOT NULL,
    AgentAddress VARCHAR(100) NOT NULL,
    AgentPhone VARCHAR(20) NOT NULL
);

GO

-- Insert sample data into the Agents table
INSERT INTO Agents (AgentID, AgentName, AgentAddress, AgentPhone) VALUES
(1, 'TB Mobiles', '123 Dong Den St, 12 Ward, Tan Binh District, TP.HCM', '0908112345'),
(2, 'D7 Phones', '1 Nguyen Huu Tho St, Tan Phong Ward, 7 District, TP.HCM', '01234567891'),
(3, '10 Wireless', '29 Cach Mang Thang Tam St, 15 Ward, 10 District, TP.HCM', '1800234589');

GO

--Delete from Agents Where AgentID = 5

CREATE TABLE AgentsLogin (
    AgentID INT NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
	FOREIGN KEY (AgentID) REFERENCES Agents (AgentID)

);
GO

INSERT INTO AgentsLogin (AgentID, Username, Password)
VALUES
(1, 'admin', '123456'),
(2, 'D7 Phones', 'D71234'),
(3, '10 Wireless', '10W1234');
GO

--Select * from AgentsLogin

CREATE TABLE Carts (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    image VARCHAR(255) NOT NULL,
    name VARCHAR(255) NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL
);

Select * from Carts
-- Create the Accountants table
CREATE TABLE Accountants (
    AccountantID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50),
    Phone VARCHAR(20)
);

-- Insert sample data into the Accountants table
INSERT INTO Accountants (AccountantID, Name, Email, Phone)
VALUES 
    (1, 'Le Thanh Huy', 'Huy@example.com', '0101234589'),
    (2, 'Tien Phat', 'Phat@example.com', '0908112321'),
    (3, 'Vinh Thanh', 'Thanh@example.com', '0956773241');

GO

CREATE TABLE AccountantLogin (
	AccountantID INT NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
	FOREIGN KEY (AccountantID) REFERENCES Accountants (AccountantID)
);
Go

INSERT INTO AccountantLogin (AccountantID, Username, Password)
VALUES
(1, 'Le Thanh Huy', 'password123'),
(2, 'Tien Phat', 'phat1234'),
(3, 'Vinh Thanh', 'abc123');
GO


-- Create the Products table
CREATE TABLE Products (
  id INT PRIMARY KEY IDENTITY(1,1),
  phone_name VARCHAR(100),
  price DECIMAL(10,2),
  memory INT,
  camera INT,
  pin INT,
  image VARCHAR(255)
);

GO

-- Insert sample data into the Products table
INSERT INTO Products (phone_name, price, memory, camera, pin, image)
VALUES
('Samsung Galaxy S21', 799.99, 128, 64, 4000, '/css/images/products/samsung-galaxy-s21-tim-600x600.jpg'),
('Apple iPhone 12 Pro', 999.99, 256, 12, 2815, '/css/images/products/(600x600)_crop_iphone-12-pro-max-128gb-cu.jpg'),
('OnePlus 9 Pro', 1069.00, 256, 48, 4500, '/css/images/products/oneplus-9-pro-600x600-1-600x600.jpg'),
('Google Pixel 5', 699.00, 128, 12, 4080, '/css/images/products/google-pixel-5-600jpg-600x600.jpg'),
('Xiaomi Mi 11 Ultra', 1199.99, 512, 50, 5000, '/css/images/products/xiaomi-mi-11-ultra-600x600-2-600x600.jpg'),
('Sony Xperia 1 III', 1299.99, 256, 12, 4500, '/css/images/products/sony-xperia-1-iii-1-600x600.jpg'),
('LG Velvet 5G', 599.99, 128, 48, 4300, '/css/images/products/600_600_Untitled_1.jpg'),
('Motorola Moto G Power', 199.99, 64, 48, 5000, '/css/images/products/Motorola-Moto-G-Power-2021.jpg'),
('Asus ROG Phone 5', 999.99, 256, 64, 6000, '/css/images/products/asus-rog-phone-5g-thumb-600x600-600x600.jpg'),
('Nokia 8.3 5G', 699.00, 128, 64, 4500, '/css/images/products/nokia-83-600x600-2-200x200.jpg'),
('Realme GT 5G', 499.00, 128, 64, 4500, '/css/images/products/realme-gt-5g-600x600-1-600x600.jpg'),
('ZTE Axon 30 Ultra', 749.00, 256, 64, 4600, '/css/images/products/zte-axon-30-ultra-600x600.jpg');

GO

--DELETE FROM Products;

--SELECT * FROM Products

CREATE TABLE incoming_stock (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    quantity INT,
    price DECIMAL(12, 0),
    total_price DECIMAL(12, 0),
    date DATE
);

GO
INSERT INTO incoming_stock (name, quantity, price, total_price, date) 
VALUES 
('asus',30,15000000,450000000,'2023-01-01'),
 ('apple', 50, 20000000, 1000000000, '2023-3-01'),
       ('samsung', 40, 18000000, 720000000, '2023-02-02'),
       ('huawei', 35, 17000000, 595000000, '2023-04-03'),
       ('lenovo', 25, 12000000, 300000000, '2023-02-04'),
       ('nokia', 20, 15000000, 300000000, '2023-01-05'),
       ('lg', 30, 13000000, 390000000, '2023-04-06');


--select * from incoming_stock

--drop table incoming_stock
GO

CREATE TABLE outgoing_stock (
  id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(100),
    quantity INT,
    price DECIMAL(12, 0),
    total_price DECIMAL(12, 0),
	 date DATE
);

GO

--drop table outgoing_stock

INSERT INTO outgoing_stock (name, quantity, price, total_price, date) 
VALUES 
('asus',30,15000000,450000000,'2023-01-01'),
 ('apple', 50, 20000000, 1000000000, '2023-3-01'),
       ('samsung', 40, 18000000, 720000000, '2023-02-02'),
       ('huawei', 35, 17000000, 595000000, '2023-04-03'),
       ('lenovo', 25, 12000000, 300000000, '2023-02-04'),
       ('nokia', 20, 15000000, 300000000, '2023-01-05'),
       ('lg', 30, 13000000, 390000000, '2023-04-06');

--select * from outgoing_stock
GO


CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name_agent VARCHAR(100),
    date DATE,
    status VARCHAR(20),
	total DECIMAL(12, 0)
);
GO




CREATE TABLE orders_details (
    id INT IDENTITY(1,1) PRIMARY KEY,
    order_id INT,
    name_product VARCHAR(100),
    quantity INT,
    price DECIMAL(12, 0),
    total_price DECIMAL(12, 0),
    FOREIGN KEY (order_id) REFERENCES orders(id)
);
GO

--drop table orders

-- Insert 10 orders into the "orders" table
INSERT INTO orders (name_agent, date, status, total) VALUES 
    ('Agent 1', '2023-05-01', 'Pending', 500000),
    ('Agent 2', '2023-05-02', 'Shipped', 750000),
    ('Agent 3', '2023-05-03', 'Delivered', 1000000),
    ('Agent 4', '2023-05-04', 'Cancelled', 250000),
    ('Agent 5', '2023-05-05', 'Pending', 500000),
    ('Agent 6', '2023-05-06', 'Shipped', 750000),
    ('Agent 7', '2023-05-07', 'Delivered', 1000000),
    ('Agent 8', '2023-05-08', 'Cancelled', 250000);

	GO

INSERT INTO orders_details (order_id, name_product, quantity, price, total_price) VALUES
 (1, 'Product A', 2, 100000, 200000),
    (1, 'Product B', 3, 75000, 225000),
	  (2, 'Product D', 4, 125000, 500000),
    (2, 'Product E', 2, 150000, 300000),
	 (3, 'Product G', 5, 100000, 500000),
    (3, 'Product H', 2, 75000, 150000),
    (3, 'Product I', 3, 50000, 150000),
	(4, 'Product K', 3, 100000, 300000),
    (4, 'Product L', 1, 150000, 150000),
	   (5, 'Product N', 4, 125000, 500000),
    (5, 'Product O', 1, 200000, 200000),
	  (6, 'Product Q', 2, 100000, 200000),
    (6, 'Product R', 4, 75000, 300000),
    (6, 'Product S', 1, 200000, 200000),
	  (7, 'Product U', 3, 100000, 300000),
    (7, 'Product V', 2, 150000, 300000),
	 (8, 'Product X', 1, 250000, 250000),
    (8, 'Product Y', 4, 100000, 400000);

	GO