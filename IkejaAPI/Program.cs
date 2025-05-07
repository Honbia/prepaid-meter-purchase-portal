// File: Program.cs
var builder = WebApplication.CreateBuilder(args);

// 🔥 Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors("AllowAll"); // 🔥 Enable CORS

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
builder.Services.AddControllers();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();