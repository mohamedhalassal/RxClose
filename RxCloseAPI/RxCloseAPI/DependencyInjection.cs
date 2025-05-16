using MapsterMapper;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;

namespace RxCloseAPI;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddControllers();


        services
            .AddSwaggerSerices()
            .AddMapsterConf()
            .AddFluentValidationConf(); ;

        services.AddScoped<IUserService, UserService>();

       

        return services;
    }
    public static IServiceCollection AddSwaggerSerices(this IServiceCollection services)
    {
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        return services;
    }

    public static IServiceCollection AddMapsterConf(this IServiceCollection services)
    {
        //Add Mapster
        var MappingConfig = TypeAdapterConfig.GlobalSettings;
        MappingConfig.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton<IMapper>(new Mapper(MappingConfig));
        return services;
    }

    public static IServiceCollection AddFluentValidationConf(this IServiceCollection services)
    {
        services
           .AddFluentValidationAutoValidation()
           .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }

}
