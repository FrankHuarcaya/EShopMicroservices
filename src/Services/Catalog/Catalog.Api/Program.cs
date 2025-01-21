var builder = WebApplication.CreateBuilder(args);

//Add services to the container

var app = builder.Build();

//configure Http request pipeline

app.Run();
