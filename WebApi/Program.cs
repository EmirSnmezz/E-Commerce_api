using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // AddControllers diyerek ConfigureService'e (IOC CONTA�NER'a) controller yap�lanmas�n� eklemezsek hata al�rz

#region Dependency Resolver
builder.Services.AddSingleton<IProductService, ProductManager>();  // Add Singleton, Proje aya�a kalk�nca bir kez instance �retir. Proje durana kadar onu kullan�r Add Transient, nesnenin her istekte tekrar �retilmesini ifade eder. Add Scoped, her http iste�i i�in tekrardan olu�turulur.
builder.Services.AddSingleton<IProductDal, EfProductDal>();     // Singleton sadece i�inde data tutulmayan, state i de�i�meyen nesneler i�in kullan�lmal�d�r.
                                                                // Data tutan yap�lar addScoped veya AddTransient olarak tan�mlanmal�
#endregion 

var app = builder.Build();

app.MapControllers();

app.Run();
