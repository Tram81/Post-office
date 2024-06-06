using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Test_3.Models;
using Test_3.Repository;

namespace Test_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));
            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();


            // Dang ky vong doi cua 1 Repositoty de co the DI duoc
            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            // Scope
            // Transient
            // Singleton

            // Middleware
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DataContext>();
            builder.Services.AddControllersWithViews();

            // Cấu hình Swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Tên API của bạn", Version = "v1" });
            });
            //Config CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:8080") // địa chỉ thực tế của ứng dụng Vue
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            //Config CORS
            app.UseCors("AllowAll");
            // Cấu hình Swagger UI
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API của bạn V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
/*
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'mydb')
BEGIN
    CREATE DATABASE mydb;
END;


USE mydb;
-- Tạo bảng Categories trước
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0,
    DeletedAt DATETIME
);

-- Tạo bảng Products kế tiếp
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    Price DECIMAL(18, 2) NOT NULL CHECK (Price >= 0),
    QuantityStock INT NOT NULL CHECK (QuantityStock >= 0),
    CategoryID INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0,
    DeletedAt DATETIME,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Tạo bảng Users tiếp theo
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY,
    UserName NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) CHECK (Email LIKE '%@%.%'),
    FullName NVARCHAR(100),
    Address NVARCHAR(200),
    Phone NVARCHAR(20) CHECK (Phone LIKE '[0-9]+'),
    PaymentMethod NVARCHAR(50),
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0,
    DeletedAt DATETIME
);

-- Sau đó tạo bảng Orders
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY,
    UserID INT NOT NULL,
    AreaCode NVARCHAR(10) NOT NULL,
    OrderDate DATETIME,
    Status INT NOT NULL CHECK (Status IN (0, 1, 2, 3)),
    ShippingAddress NVARCHAR(200) NOT NULL,
    ShippingFee DECIMAL(18, 2) NOT NULL CHECK (ShippingFee >= 0),
    TotalAmount DECIMAL(18, 2) NOT NULL CHECK (TotalAmount >= 0),
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0,
    DeletedAt DATETIME,
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Cuối cùng tạo bảng OrderDetails
CREATE TABLE OrderDetails (
    OrderDetailsID INT PRIMARY KEY IDENTITY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 0 CHECK (Quantity >= 0),
    Price DECIMAL(18, 2) NOT NULL CHECK (Price >= 0),
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    UpdatedAt DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0,
    DeletedAt DATETIME,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

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



 */