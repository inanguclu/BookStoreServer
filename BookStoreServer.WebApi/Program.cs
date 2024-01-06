using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Options;
using BookStoreServer.WebApi.Utilities;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<AppDbContext>();
builder.Services.AddCors(cfr =>
{
    cfr.AddDefaultPolicy(p => p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.CreateServiceTool();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
