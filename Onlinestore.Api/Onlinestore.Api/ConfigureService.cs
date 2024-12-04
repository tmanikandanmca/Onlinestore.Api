using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Onlinestore.Api.Context;

namespace Onlinestore.Api;

public static class ConfigureService
{
    public static void Configure(this IServiceCollection services)
    {
        var builder = WebApplication.CreateBuilder();
        services.AddDbContext<StoreDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("StoreDB"));
        });

    }
}