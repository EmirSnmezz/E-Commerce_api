var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // AddControllers diyerek ConfigureService'e controller yapýlanmasýný eklemezsek hata alýrz
var app = builder.Build();

app.MapControllers();

app.Run();
