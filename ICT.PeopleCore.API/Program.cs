using ICT.PeopleCore.Helper;

var builder = WebApplication.CreateBuilder(args);

// Register layers
builder.Services.AddCoreServices();

// Register Swagger (no manual AddSwaggerGen)
builder.Services.AddSwaggerServices();

// Register authorization
builder.Services.AddAuthorization();

// Add controllers
builder.Services.AddControllers();

var app = builder.Build();

// Global error handling
app.UseGlobalErrorHandling(app.Environment);

// Swagger middleware (development only)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PeopleCore API V1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
