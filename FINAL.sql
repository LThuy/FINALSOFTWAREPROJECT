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

DELETE FROM Products;

SELECT * FROM Products

