﻿using Battlefield.Infrastructure.EventHandlers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Battlefield.Infrastructure.Events
{
    internal static class Extensions
    {
        public static IServiceCollection AddEvents(this IServiceCollection services)
        {
            services.AddSingleton<IEventDispatcher, EventDispatcher>();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //services.Scan(s => s.FromAssemblies(assemblies)
            //    .AddClasses(c => c.AssignableTo(typeof(IEventHandler<>)))
            //    .AsImplementedInterfaces()
            //    .WithScopedLifetime());
            return services;
        }
    }
}
