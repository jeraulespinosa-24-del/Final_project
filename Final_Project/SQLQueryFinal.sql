CREATE DATABASE InventoryDB;

DROP TABLE IF EXISTS Products;






CREATE TABLE Productss (
    ProdID INT IDENTITY PRIMARY KEY,
    sku NVARCHAR(50),
    product_name NVARCHAR(100),
    product_Description NVARCHAR(255),
    prod_category NVARCHAR(100),
    quantity INT,
    unit NVARCHAR(50),
    price DECIMAL(10,2)
);

    

SELECT * FROM Productss

