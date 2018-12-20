using DotNetCore.IoC;
using everis.SimpleProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace everis.SimpleProject.IoC
{
    public static class IServiceCollectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCriptography(Guid.NewGuid().ToString());
            services.AddHash();
            services.AddJsonWebToken(Guid.NewGuid().ToString());
            services.AddLogger(configuration);

            services.AddClassesMatchingInterfacesFrom(
            //    new[]
            //{
            //    assembly.getassembly(typeof(iauthenticationapplication)),
            //    assembly.getassembly(typeof(iauthenticationdomain)),
            //    assembly.getassembly(typeof(idatabaseunitofwork))
            //}
            );

            var connectionString = configuration.GetConnectionString(nameof(DatabaseContext));
            services.AddDbContextEnsureCreatedMigrate<DatabaseContext>(options => options.UseSqlServer(connectionString));
        }
    }
}