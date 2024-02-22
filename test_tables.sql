CREATE TABLE [dbo].Products (
    Id INT PRIMARY KEY IDENTITY(1, 1) ,
    Name NVARCHAR(100),
    Description NVARCHAR(MAX),
    Price DECIMAL
);

CREATE TABLE [dbo].Categories (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Name NVARCHAR(100)
);

CREATE TABLE [dbo].ProductCategories(
    ProductId INT,
    CategoryId INT,
    PRIMARY KEY (ProductId, CategoryId),
    FOREIGN KEY (ProductId) REFERENCES Products(id),
    FOREIGN KEY (CategoryId) REFERENCES Categories(id)
);

INSERT INTO [dbo].Products(Name, Description, Price) VALUES
    ('Banana', 'Delicious fruit', 70),
    ('Red Apple', 'One more delicious fruit', 90),
    ('Cucumber', 'Green vegetable', 20),
    ('Tomato', 'Red vegetable', 40),
    ('Napkins', 'Definitely not eatable', 120);

INSERT INTO [dbo].Categories(Name) VALUES ('Fruits'), ('Vegetables'), ('Apples');

INSERT INTO [dbo].ProductCategories(ProductId, CategoryId) VALUES
    (1, 1), (2, 1), (2, 3), (3, 2), (4 ,2);