using Endian;
using Microsoft.Extensions.DependencyInjection;

namespace Endian.Extensions.DependencyInjection.Tests;

public sealed class EndianServiceCollectionExtensionsTests
{
    [Test]
    public void AddEndian_WithNullServices_Throws()
    {
        Assert.That(() => EndianServiceCollectionExtensions.AddEndian(null!), Throws.ArgumentNullException);
    }

    [Test]
    public void AddEndian_RegistersLittleEndian()
    {
        using ServiceProvider serviceProvider = CreateServiceProvider();

        Assert.That(serviceProvider.GetRequiredService<LittleEndian>(), Is.Not.Null);
    }

    [Test]
    public void AddEndian_RegistersBigEndian()
    {
        using ServiceProvider serviceProvider = CreateServiceProvider();

        Assert.That(serviceProvider.GetRequiredService<BigEndian>(), Is.Not.Null);
    }

    [Test]
    public void AddEndian_RegistersPlatformEndian()
    {
        using ServiceProvider serviceProvider = CreateServiceProvider();

        IEndianReaderWriter endian = serviceProvider.GetRequiredService<IEndianReaderWriter>();

        if (BitConverter.IsLittleEndian)
        {
            Assert.That(endian, Is.SameAs(serviceProvider.GetRequiredService<LittleEndian>()));
        }
        else
        {
            Assert.That(endian, Is.SameAs(serviceProvider.GetRequiredService<BigEndian>()));
        }
    }

    [Test]
    public void AddEndian_RegistersReaderAsPlatformEndian()
    {
        using ServiceProvider serviceProvider = CreateServiceProvider();

        Assert.That(
            serviceProvider.GetRequiredService<IEndianReader>(),
            Is.SameAs(serviceProvider.GetRequiredService<IEndianReaderWriter>()));
    }

    [Test]
    public void AddEndian_RegistersWriterAsPlatformEndian()
    {
        using ServiceProvider serviceProvider = CreateServiceProvider();

        Assert.That(
            serviceProvider.GetRequiredService<IEndianWriter>(),
            Is.SameAs(serviceProvider.GetRequiredService<IEndianReaderWriter>()));
    }

    private static ServiceProvider CreateServiceProvider()
    {
        ServiceCollection services = new();
        services.AddEndian();
        return services.BuildServiceProvider();
    }
}
