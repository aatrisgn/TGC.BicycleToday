var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddOpenApiDocument(document =>
{
	document.Title = "TGC.BicycleToday API Spec";
	document.Description = "API for exposing data to Angular Client (BicycleToday.App). Be aware this API is not ready for consumption by third-party. Breaking changes can occur without notice.";
});

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "ALLOW_DEVELOPMENT_CORS_ORIGINS_POLICY",
		builder =>
		{
			builder.WithOrigins("*")
				.AllowAnyMethod()
				.AllowAnyHeader()
				.AllowCredentials();
		});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseOpenApi();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
