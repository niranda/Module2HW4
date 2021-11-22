﻿using Microsoft.Extensions.DependencyInjection;
using ShopApp.Services.Abstractions;
using ShopApp.Providers;
using ShopApp.Providers.Abstractions;
using ShopApp.Services;

namespace StyleCop.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IContainerProvider, ContainerProvider>()
                .AddSingleton<IConfigService, ConfigService>()
                .AddSingleton<IContainerService, ContainerService>()
                .AddSingleton<ILoggerService, LoggerService>()
                .AddTransient<ISortService, SortService>()
                .AddTransient<Starter>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Starter>();
            start.Run();
        }
    }
}
