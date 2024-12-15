var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // AddControllers diyerek ConfigureService'e controller yap�lanmas�n� eklemezsek hata al�rz
var app = builder.Build();

app.MapControllers();

app.Run();
