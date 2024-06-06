-- Sinh dữ liệu fake cho bảng Categories
INSERT INTO Categories (CategoryName, Description, CreatedDate)
VALUES 
    ('Electronics', 'Electronic devices such as smartphones, laptops, and tablets', GETDATE()),
    ('Clothing', 'Apparel items including shirts, pants, and jackets', GETDATE()),
    ('Home Decor', 'Decorative items for home such as vases, paintings, and sculptures', GETDATE()),
    ('Books', 'Various books on different topics including fiction, non-fiction, and self-help', GETDATE());

-- Sinh dữ liệu fake cho bảng Products
INSERT INTO Products (ProductName, Description, Price, QuantityStock, CategoryID, CreatedDate)
VALUES 
    ('Smartphone XYZ', 'High-end smartphone with advanced features', 999.99, 100, 1, GETDATE()),
    ('Laptop ABC', 'Powerful laptop for professional use', 1499.99, 50, 1, GETDATE()),
    ('T-shirt Plain', 'Basic plain t-shirt available in various colors', 19.99, 200, 2, GETDATE()),
    ('Jeans Slim Fit', 'Slim fit jeans made of stretchable denim fabric', 39.99, 150, 2, GETDATE()),
    ('Vase Ceramic', 'Decorative ceramic vase with intricate design', 29.99, 50, 3, GETDATE()),
    ('Canvas Painting', 'Canvas painting depicting a scenic landscape', 149.99, 20, 3, GETDATE()),
    ('Book "The Great Gatsby"', 'Classic novel written by F. Scott Fitzgerald', 9.99, 100, 4, GETDATE()),
    ('Book "Thinking, Fast and Slow"', 'Bestselling book on psychology by Daniel Kahneman', 14.99, 80, 4, GETDATE());

-- Sinh dữ liệu fake cho bảng Orders
INSERT INTO Orders (UserID, AreaCode, OrderDate, Status, ShippingAddress, ShippingFee, TotalAmount, CreatedDate)
VALUES 
    (1, 'A123', '2024-06-01', 0, '123 Main Street, City, Country', 5.99, 105.98, GETDATE()),
    (2, 'B456', '2024-06-02', 1, '456 Elm Street, City, Country', 7.99, 219.97, GETDATE()),
    (3, 'C789', '2024-06-03', 2, '789 Oak Street, City, Country', 9.99, 339.96, GETDATE());

-- Sinh dữ liệu fake cho bảng OrderDetails
INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price, CreatedDate)
VALUES 
    (1, 1, 2, 999.99, GETDATE()),
    (1, 3, 3, 19.99, GETDATE()),
    (2, 2, 1, 1499.99, GETDATE()),
    (2, 4, 2, 39.99, GETDATE()),
    (3, 5, 1, 29.99, GETDATE()),
    (3, 7, 2, 14.99, GETDATE());
