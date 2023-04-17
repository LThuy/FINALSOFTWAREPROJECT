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

CREATE TABLE AgentsLogin (
    AgentID INT NOT NULL,
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
	FOREIGN KEY (AgentID) REFERENCES Agents (AgentID)

);
GO

INSERT INTO AgentsLogin (AgentID, Username, Password)
VALUES
(1, 'TB Mobiles', 'TB1234'),
(2, 'D7 Phones', 'D71234'),
(3, '10 Wireless', '10W1234');


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
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL,
    ProductDescription VARCHAR(200),
    ProductPrice DECIMAL(10,2) NOT NULL,
    ProductQuantity INT NOT NULL
);

GO

-- Insert sample data into the Products table
INSERT INTO Products (ProductID, ProductName, ProductDescription, ProductPrice, ProductQuantity) VALUES
    (1, 'iPhone 13 Pro Max', 'Apple iPhone 13 Pro Max, 256GB', 1299.99, 50),
    (2, 'Samsung Galaxy S21 Ultra', 'Samsung Galaxy S21 Ultra, 512GB', 1299.99, 40),
    (3, 'Google Pixel 6 Pro', 'Google Pixel 6 Pro, 128GB', 899.99, 30),
    (4, 'OnePlus 10 Pro', 'OnePlus 10 Pro, 256GB', 999.99, 20),
    (5, 'Xiaomi Mi 12', 'Xiaomi Mi 12, 128GB', 799.99, 60),
    (6, 'Sony Xperia 1 III', 'Sony Xperia 1 III, 256GB', 1299.99, 35),
    (7, 'Huawei P50 Pro', 'Huawei P50 Pro, 256GB', 1199.99, 25),
    (8, 'LG Wing 5G', 'LG Wing 5G, 256GB', 899.99, 15),
    (9, 'Motorola Edge 20 Pro', 'Motorola Edge 20 Pro, 128GB', 699.99, 50),
    (10, 'Nokia X50 Pro', 'Nokia X50 Pro, 256GB', 899.99, 30),
    (11, 'Asus Zenfone 8 Flip', 'Asus Zenfone 8 Flip, 128GB', 799.99, 20),
    (12, 'Realme GT Master', 'Realme GT Master, 256GB', 599.99, 50),
    (13, 'Oppo Find X3 Pro', 'Oppo Find X3 Pro, 256GB', 1199.99, 30),
    (14, 'Vivo X70 Pro+', 'Vivo X70 Pro+, 256GB', 999.99, 40),
    (15, 'Lenovo Legion Phone Duel 2', 'Lenovo Legion Phone Duel 2, 512GB', 1099.99, 20),
    (16, 'Redmi Note 11 Pro', 'Redmi Note 11 Pro, 128GB', 399.99, 80),
    (17, 'ZTE Axon 30 Ultra', 'ZTE Axon 30 Ultra, 256GB', 999.99, 25),
    (18, 'TCL 20 Pro 5G', 'TCL 20 Pro 5G, 256GB', 599.99, 35),
    (19, 'Blackberry Key3', 'Blackberry Key3, 128GB', 899.99, 15),
    (20, 'CAT S62 Pro', 'CAT S62 Pro, 128GB', 699.99, 10);


GO

CREATE TABLE GoodsReceivedNote (
GRN_ID INT PRIMARY KEY,
ReceiptDate DATE,
ItemCount INT,
TotalAmount DECIMAL(10, 2)
);

GO

CREATE TABLE GoodsReceivedNoteItems (
GRN_ID INT,
ProductID INT,
Quantity INT,
FOREIGN KEY (GRN_ID) REFERENCES GoodsReceivedNote(GRN_ID),
FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

GO


INSERT INTO GoodsReceivedNote (GRN_ID, ReceiptDate, ItemCount, TotalAmount) VALUES
(1, '2023-04-01', 5, 6499.95),
(2, '2023-04-07', 10, 11999.90),
(3, '2023-04-14', 15, 18249.85);

GO

INSERT INTO GoodsReceivedNoteItems (GRN_ID, ProductID, Quantity) VALUES
(1, 1, 2),
(1, 2, 1),
(1, 3, 1),
(1, 6, 1),
(1, 7, 1),
(2, 1, 5),
(2, 4, 2),
(2, 8, 2),
(2, 11, 1),
(2, 12, 2),
(3, 1, 3),
(3, 2, 4),
(3, 3, 2),
(3, 4, 1),
(3, 5, 1),
(3, 6, 1),
(3, 7, 1),
(3, 10, 1),
(3, 13, 1),
(3, 14, 1);

GO


-- Create the Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    AgentID INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(10,2) NOT NULL,
    PaymentMethod VARCHAR(50) NOT NULL,
    PaymentStatus VARCHAR(50) NOT NULL
);

GO

-- Insert sample data into the Orders table
INSERT INTO Orders (OrderID, AgentID, OrderDate, TotalAmount, PaymentMethod, PaymentStatus) VALUES
(1, 1, '2023-04-14 10:00:00', 799.99, 'Cash', 'Paid'),
(2, 2, '2023-04-15 12:00:00', 999.99, 'Bank Transfer', 'Pending'),
(3, 3, '2023-04-15 14:00:00', 1399.98, 'Momo', 'Paid');

GO

-- Create the OrderItems table
CREATE TABLE OrderItems (
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    PRIMARY KEY (OrderID, ProductID),
    FOREIGN KEY (OrderID) REFERENCES Orders (OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products (ProductID)
);

GO

-- Insert sample data into the OrderItems table
INSERT INTO OrderItems (OrderID, ProductID, Quantity) VALUES
(1, 1, 2),
(1, 3, 1),
(2, 2, 1),
(3, 1, 1),
(3, 2, 1),
(3, 3, 1);

GO

-- View incoming stock report
CREATE PROCEDURE GetIncomingStock
AS
BEGIN
    SELECT p.ProductName, SUM(o.Quantity) as IncomingStock
    FROM OrderItems o
    INNER JOIN Products p ON o.ProductID = p.ProductID
    WHERE o.OrderID IN (
        SELECT OrderID
        FROM Orders
        WHERE PaymentStatus = 'Paid'
    )
    GROUP BY p.ProductName
    ORDER BY IncomingStock DESC;
END;
GO

-- View outgoing stock report
SELECT p.ProductName, SUM(o.Quantity) as OutgoingStock
FROM OrderItems o
INNER JOIN Products p ON o.ProductID = p.ProductID
WHERE o.OrderID IN (
SELECT OrderID
FROM Orders
WHERE PaymentStatus = 'Paid'
)
GROUP BY p.ProductName
ORDER BY OutgoingStock DESC;

GO

-- View best-selling products report
SELECT p.ProductName, SUM(o.Quantity) as TotalSales
FROM OrderItems o
INNER JOIN Products p ON o.ProductID = p.ProductID
WHERE o.OrderID IN (
SELECT OrderID
FROM Orders
WHERE PaymentStatus = 'Paid'
)
GROUP BY p.ProductName
ORDER BY TotalSales DESC;

GO

-- View revenue report
SELECT DATEPART(MONTH, o.OrderDate) as Month, SUM(o.TotalAmount) as Revenue
FROM Orders o
WHERE o.PaymentStatus = 'Paid'
GROUP BY DATEPART(MONTH, o.OrderDate)
ORDER BY Month;