﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Order
{
    public static class OrderModule
    {

        public static IServiceCollection AddOrderModule(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services;
        }
    }
}
