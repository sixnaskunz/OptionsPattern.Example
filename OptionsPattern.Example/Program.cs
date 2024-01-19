var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// If you manually add appsettings.json, you need to set third parameter to true for reload config on change.
// builder.Configuration.AddJsonFile("appsettings.json", false, true);
// builder.Configuration.AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", false, true)

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Learn more about Options Pattern at https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-8.0
builder.Services.Configure<ExampleOptions>(builder.Configuration.GetSection(ExampleOptions.Example));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();