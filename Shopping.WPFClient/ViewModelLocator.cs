using Bogus;
using dotnet_core_3_wpf_mvvm.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shopping.Domain.Models;
using Shopping.Domain.Services;
using Shopping.Inftrastructure;
using Shopping.Inftrastructure.Fakers;
using Shopping.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace dotnet_core_3_wpf_mvvm
{
    public class ViewModelLocator
    {
        public IConfiguration Configuration { get; }

        private readonly ServiceProvider _serviceProvider;

        public ShellViewModel ShellViewModel => _serviceProvider.GetRequiredService<ShellViewModel>();
        public CustomersViewModel CustomersViewModel => _serviceProvider.GetRequiredService<CustomersViewModel>();

        public ViewModelLocator()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true);
            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<INavigationService, FrameNavigationService>();

            services.AddScoped<ShellViewModel>();
            services.AddScoped<CustomersViewModel>();

            services.AddScoped<ICustomerService, FakeCustomerService>();
            services.AddScoped<Faker<Customer>, CustomerFaker>();

         
        }

    }
}
