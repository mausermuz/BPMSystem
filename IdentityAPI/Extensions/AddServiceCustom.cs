﻿using IdentityAPI.Services;
using IdentityAPI.Services.Logic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace IdentityAPI.Extensions
{
    public static class AddServiceCustom
    {
        public static void AddRegistrationServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountService, AccountService>();
        }
        
        public static void AddSwaggerCustom(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IdentityAPI", Version = "v1" });
            });
        }

        public static void AddCorsCustom(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("BpmServicePolicy", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });
        }
    }
}