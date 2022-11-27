using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pedidos.Infra.Data.Common;
using Pedidos.Infra.Data.Interfaces.LifeCycleAbstraction;

namespace Pedidos.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

        public static IServiceCollection AddServicesAndRepositories(this IServiceCollection services)
        {
            services.Scan(selector =>
            {
                selector.FromApplicationDependencies()
                    .AddClasses(typeFilter => typeFilter.AssignableTo<IScopedDependency>())
                    .AsMatchingInterface()
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .WithScopedLifetime();

                selector.FromApplicationDependencies()
                    .AddClasses(typeFilter => typeFilter.AssignableTo<ISingletonDependency>())
                    .AsMatchingInterface()
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .WithSingletonLifetime();

                selector.FromApplicationDependencies()
                    .AddClasses(typeFilter => typeFilter.AssignableTo<ITransientDependency>())
                    .AsMatchingInterface()
                    .AsImplementedInterfaces()
                    .AsSelf()
                    .WithTransientLifetime();
            });

            return services;
        }
    }
}