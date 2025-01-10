using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.DependencyResolvers.AutoFac;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(); // AddControllers diyerek ConfigureService'e (IOC CONTAÝNER'a) controller yapýlanmasýný eklemezsek hata alýrz

#region Dependency Resolver

//builder.Services.AddSingleton<IProductService, ProductManager>();  // Add Singleton, Proje ayaða kalkýnca bir kez instance üretir. Proje durana kadar onu kullanýr Add Transient, nesnenin her istekte tekrar üretilmesini ifade eder. Add Scoped, her http isteði için tekrardan oluþturulur.
//builder.Services.AddSingleton<IProductDal, EfProductDal>();     // Singleton sadece içinde data tutulmayan, state i deðiþmeyen nesneler için kullanýlmalýdýr.
// Data tutan yapýlar addScoped veya AddTransient olarak tanýmlanmalý

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())  //.NET'e Senin IoC yapýn var ama vereceðim þu IoC'yi kullan diyoruz.
.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutoFacBusinessModule());
});
#endregion 

var app = builder.Build();

app.MapControllers();

app.Run();
