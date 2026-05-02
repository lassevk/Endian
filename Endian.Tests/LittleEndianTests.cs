using Endian;

namespace Endian.Tests;

public sealed class LittleEndianTests
{
    private readonly LittleEndian _endian = new();

    [Test]
    public void ReadUInt16()
    {
        Assert.That(_endian.ReadUInt16([0x39, 0x30]), Is.EqualTo(0x3039));
    }

    [Test]
    public void ReadInt16()
    {
        Assert.That(_endian.ReadInt16([0xC7, 0xCF]), Is.EqualTo(-12345));
    }

    [Test]
    public void ReadUInt32()
    {
        Assert.That(_endian.ReadUInt32([0x78, 0x56, 0x34, 0x12]), Is.EqualTo(0x12345678u));
    }

    [Test]
    public void ReadInt32()
    {
        Assert.That(_endian.ReadInt32([0xEB, 0x32, 0xA4, 0xF8]), Is.EqualTo(-123456789));
    }

    [Test]
    public void ReadUInt64()
    {
        Assert.That(_endian.ReadUInt64([0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01]), Is.EqualTo(0x0123456789ABCDEFul));
    }

    [Test]
    public void ReadInt64()
    {
        Assert.That(_endian.ReadInt64([0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE]), Is.EqualTo(-1234567890123456789L));
    }

    [Test]
    public void ReadSingle()
    {
        Assert.That(_endian.ReadSingle([0x00, 0x00, 0xC0, 0x3F]), Is.EqualTo(1.5f));
    }

    [Test]
    public void ReadDouble()
    {
        Assert.That(_endian.ReadDouble([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0]), Is.EqualTo(-2.5d));
    }

    [Test]
    public void WriteUInt16()
    {
        Span<byte> data = stackalloc byte[sizeof(ushort)];

        _endian.Write(data, (ushort)0x3039);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x39, 0x30 }));
    }

    [Test]
    public void WriteInt16()
    {
        Span<byte> data = stackalloc byte[sizeof(short)];

        _endian.Write(data, (short)-12345);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xC7, 0xCF }));
    }

    [Test]
    public void WriteUInt32()
    {
        Span<byte> data = stackalloc byte[sizeof(uint)];

        _endian.Write(data, 0x12345678u);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x78, 0x56, 0x34, 0x12 }));
    }

    [Test]
    public void WriteInt32()
    {
        Span<byte> data = stackalloc byte[sizeof(int)];

        _endian.Write(data, -123456789);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xEB, 0x32, 0xA4, 0xF8 }));
    }

    [Test]
    public void WriteUInt64()
    {
        Span<byte> data = stackalloc byte[sizeof(ulong)];

        _endian.Write(data, 0x0123456789ABCDEFul);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01 }));
    }

    [Test]
    public void WriteInt64()
    {
        Span<byte> data = stackalloc byte[sizeof(long)];

        _endian.Write(data, -1234567890123456789L);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE }));
    }

    [Test]
    public void WriteSingle()
    {
        Span<byte> data = stackalloc byte[sizeof(float)];

        _endian.Write(data, 1.5f);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x00, 0x00, 0xC0, 0x3F }));
    }

    [Test]
    public void WriteDouble()
    {
        Span<byte> data = stackalloc byte[sizeof(double)];

        _endian.Write(data, -2.5d);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0 }));
    }
}
