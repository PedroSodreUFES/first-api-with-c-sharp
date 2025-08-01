using MyFirstApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(option => option.LowercaseUrls = true); // colocar controllers minusculos por default

/*  Testando appsettings.json e appsettings.Development.json    */
var prop1 = builder.Configuration.GetSection("MyClass").GetSection("Prop1").Value;
// Outra forma
var number = builder.Configuration.GetValue<int>("MyClass:Number");
// tem 2 iguais, vai dar preferencia ao desenvolvimento
var propA = builder.Configuration.GetSection("MyClass").GetSection("PropA").Value;

Console.WriteLine(prop1);
Console.WriteLine(number);
Console.WriteLine(propA);

// pegar em forma de classe
var test = builder.Configuration.GetSection("MyClass").Get<MyClass>();
Console.WriteLine(test.Prop1);
Console.WriteLine(test.Prop2);
Console.WriteLine(test.PropA);

// OBS: tentar pegar um valor que não existe em algum appsettings.json retorna null
var pegandoErrado = builder.Configuration.GetSection("NaoExiste").Value;
Console.WriteLine(pegandoErrado); // printa vazio


/*Fim dos testes*/

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
