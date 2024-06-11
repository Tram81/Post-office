using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Project3.Data;
using Project3.Repository;

//using Project3.Repository;
using Project3.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();



//Cau hinh JWT


builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration.GetSection("JWT")["Isuser"], // Thay thế bằng issuer của bạn
        ValidateAudience = true,
        ValidAudience = builder.Configuration.GetSection("JWT")["Audithen"], // Thay thế bằng audience của bạn
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT")["Secret"]))
    };
});
// Dang ky vong doi cua 1 Repositoty de co the DI duoc
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IOderRepository, OderRepository>();
builder.Services.AddScoped<IOderDetailsRepository, OderDetailsRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
//builder.Services.AddScoped<IReservationSuperFastFeeRepository, ReservationSuperFastFeeRepository>();
//builder.Services.AddScoped<IRoutesReponsitory, RoutesReponsitory>();
//builder.Services.AddScoped<IStationReponsitory, StationReponsitory>();
//builder.Services.AddScoped<ITrainReponsitory, TrainReponsitory>();
//builder.Services.AddScoped<ITrainScheduleRepository, TrainScheduleRepository>();
//builder.Services.AddScoped<ICustomerRopository, CustomerRopository>();
//builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

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
            builder.WithOrigins("http://localhost:8080") // Thay thế bằng địa chỉ thực tế của ứng dụng Vue của bạn
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
builder.Services.AddTransient<IEmailService, MailKitEmailService>();


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//Config CORS
app.UseCors("AllowAll");
//app.UseCors(builder =>
//{
//    builder.WithOrigins("http://localhost:8080") // Địa chỉ của ứng dụng Vue
//           .AllowAnyHeader()
//           .AllowAnyMethod();
//});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Cấu hình Swagger UI
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API của bạn V1");
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
