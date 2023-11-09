﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicketEase.Application.Interfaces.Repositories;
using TicketEase.Application.Interfaces.Services;
using TicketEase.Application.ServicesImplementation;
using TicketEase.Domain.Entities;
using TicketEase.Persistence.Repositories;

namespace TicketEase.Persistence.Extensions
{
    public static class DIServiceExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration config)
        {

            //Bind CloudinarySettings from configuration 
            var cloudinarySettings = new CloudinarySetting();
            config.GetSection("CloudinarySettings").Bind(cloudinarySettings);
            services.AddSingleton(cloudinarySettings);

            var emailSettings = new EmailSettings();
            config.GetSection("EmailSettings").Bind(emailSettings);
            services.AddSingleton(emailSettings);




            // services.AddDbContext<DataContext>();

            // services.AddTransient<IEmailService, EmailService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBoardServices, BoardServices>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICloudinaryServices, CloudinaryServices>();




        }
    }
}
