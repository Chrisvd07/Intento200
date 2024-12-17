using System.Configuration.Internal;
using System.ServiceProcess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Northwind.Application;
using Northwind.Application.Abstraction;
using Northwind.Infraestructure;
using static Northwind.Infraestructure.SupplierRepository;

namespace Northwind
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("Appsettings.json").Build();
            var serviceCollections = new ServiceCollection();
            serviceCollections.AddSingleton<IConfiguration>(configuration);

            //Applicaction 


            //Infraestructure
            serviceCollections.AddScoped<ISqlConnectionFasctory, SqlConnectionFasctory>();
            serviceCollections.AddScoped<ISupplierRepository, SupplierRepository > ();
            serviceCollections.AddScoped<ICategoryRepositore, CategoryRepository>();
            serviceCollections.AddScoped<IProductRepository, ProductRepository>();
            serviceCollections.AddScoped<CategoryService>();
            serviceCollections.AddScoped<ProductService>();
            

            //PRESENTACION

            serviceCollections.AddTransient<Form1>();
            serviceCollections.AddTransient<Categories>(); 
            serviceCollections.AddTransient<Form2>();
            serviceCollections.AddTransient<AddProduct>();
            serviceCollections.AddTransient<AddCategories>();
            serviceCollections.AddTransient<AddSupplier>();
            serviceCollections.AddTransient<AddingProduct>();





            var ServiceProvider = serviceCollections.BuildServiceProvider();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<AddingProduct>());
            
        }
    }
}