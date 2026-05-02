using Endian;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class EndianServiceCollectionExtensions
{
    public static IServiceCollection AddEndian(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddSingleton<LittleEndian>();
        services.AddSingleton<BigEndian>();

        if (BitConverter.IsLittleEndian)
        {
            services.AddSingleton<IEndianReaderWriter>(serviceProvider =>
                serviceProvider.GetRequiredService<LittleEndian>());
        }
        else
        {
            services.AddSingleton<IEndianReaderWriter>(serviceProvider =>
                serviceProvider.GetRequiredService<BigEndian>());
        }

        services.AddSingleton<IEndianReader>(serviceProvider =>
            serviceProvider.GetRequiredService<IEndianReaderWriter>());

        services.AddSingleton<IEndianWriter>(serviceProvider =>
            serviceProvider.GetRequiredService<IEndianReaderWriter>());

        return services;
    }
}
