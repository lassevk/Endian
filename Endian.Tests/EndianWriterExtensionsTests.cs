using Endian;

namespace Endian.Tests;

public sealed class EndianWriterExtensionsTests
{
    private static readonly UInt128 _uInt128Value = ((UInt128)0x0123456789ABCDEFul << 64) | 0xFEDCBA9876543210ul;
    private readonly LittleEndian _endian = new();

    [Test]
    public void WriteStream()
    {
        AssertWrite(stream => _endian.Write(stream, (ushort)0x3039), [0x39, 0x30]);
        AssertWrite(stream => _endian.Write(stream, (short)-12345), [0xC7, 0xCF]);
        AssertWrite(stream => _endian.Write(stream, 0x12345678u), [0x78, 0x56, 0x34, 0x12]);
        AssertWrite(stream => _endian.Write(stream, -123456789), [0xEB, 0x32, 0xA4, 0xF8]);
        AssertWrite(stream => _endian.Write(stream, 0x0123456789ABCDEFul), [0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01]);
        AssertWrite(stream => _endian.Write(stream, -1234567890123456789L), [0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE]);
        AssertWrite(stream => _endian.Write(stream, _uInt128Value), [0x10, 0x32, 0x54, 0x76, 0x98, 0xBA, 0xDC, 0xFE, 0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01]);
        AssertWrite(stream => _endian.Write(stream, Int128.MinValue), [0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80]);
        AssertWrite(stream => _endian.Write(stream, (Half)1.5f), [0x00, 0x3E]);
        AssertWrite(stream => _endian.Write(stream, 1.5f), [0x00, 0x00, 0xC0, 0x3F]);
        AssertWrite(stream => _endian.Write(stream, -2.5d), [0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0]);
    }

    [Test]
    public async Task WriteStreamAsync()
    {
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, (ushort)0x3039, cancellationToken), [0x39, 0x30]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, (short)-12345, cancellationToken), [0xC7, 0xCF]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, 0x12345678u, cancellationToken), [0x78, 0x56, 0x34, 0x12]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, -123456789, cancellationToken), [0xEB, 0x32, 0xA4, 0xF8]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, 0x0123456789ABCDEFul, cancellationToken), [0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, -1234567890123456789L, cancellationToken), [0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, _uInt128Value, cancellationToken), [0x10, 0x32, 0x54, 0x76, 0x98, 0xBA, 0xDC, 0xFE, 0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, Int128.MinValue, cancellationToken), [0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, (Half)1.5f, cancellationToken), [0x00, 0x3E]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, 1.5f, cancellationToken), [0x00, 0x00, 0xC0, 0x3F]);
        await AssertWriteAsync((stream, cancellationToken) => _endian.WriteAsync(stream, -2.5d, cancellationToken), [0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0]);
    }

    [Test]
    public void WriteStream_WithNullStream_Throws()
    {
        Assert.That(() => _endian.Write((Stream)null!, (ushort)0x3039), Throws.ArgumentNullException);
    }

    private static void AssertWrite(Action<MemoryStream> write, byte[] expected)
    {
        using MemoryStream stream = new();

        write(stream);

        Assert.That(stream.ToArray(), Is.EqualTo(expected));
    }

    private static async Task AssertWriteAsync(Func<MemoryStream, CancellationToken, ValueTask> write, byte[] expected)
    {
        using MemoryStream stream = new();

        await write(stream, CancellationToken.None);

        Assert.That(stream.ToArray(), Is.EqualTo(expected));
    }
}
