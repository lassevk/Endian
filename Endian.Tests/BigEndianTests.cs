using Endian;

namespace Endian.Tests;

public sealed class BigEndianTests
{
    private static readonly UInt128 _uInt128Value = ((UInt128)0x0123456789ABCDEFul << 64) | 0xFEDCBA9876543210ul;
    private readonly BigEndian _endian = new();

    [Test]
    public void ReadUInt16()
    {
        Assert.That(_endian.ReadUInt16([0x30, 0x39]), Is.EqualTo(0x3039));
    }

    [Test]
    public void ReadInt16()
    {
        Assert.That(_endian.ReadInt16([0xCF, 0xC7]), Is.EqualTo(-12345));
    }

    [Test]
    public void ReadUInt32()
    {
        Assert.That(_endian.ReadUInt32([0x12, 0x34, 0x56, 0x78]), Is.EqualTo(0x12345678u));
    }

    [Test]
    public void ReadInt32()
    {
        Assert.That(_endian.ReadInt32([0xF8, 0xA4, 0x32, 0xEB]), Is.EqualTo(-123456789));
    }

    [Test]
    public void ReadUInt64()
    {
        Assert.That(_endian.ReadUInt64([0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF]), Is.EqualTo(0x0123456789ABCDEFul));
    }

    [Test]
    public void ReadInt64()
    {
        Assert.That(_endian.ReadInt64([0xEE, 0xDD, 0xEF, 0x0B, 0x82, 0x16, 0x7E, 0xEB]), Is.EqualTo(-1234567890123456789L));
    }

    [Test]
    public void ReadUInt128()
    {
        Assert.That(_endian.ReadUInt128([0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10]), Is.EqualTo(_uInt128Value));
    }

    [Test]
    public void ReadInt128()
    {
        Assert.That(_endian.ReadInt128([0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00]), Is.EqualTo(Int128.MinValue));
    }

    [Test]
    public void ReadHalf()
    {
        Assert.That(_endian.ReadHalf([0x3E, 0x00]), Is.EqualTo((Half)1.5f));
    }

    [Test]
    public void ReadSingle()
    {
        Assert.That(_endian.ReadSingle([0x3F, 0xC0, 0x00, 0x00]), Is.EqualTo(1.5f));
    }

    [Test]
    public void ReadDouble()
    {
        Assert.That(_endian.ReadDouble([0xC0, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00]), Is.EqualTo(-2.5d));
    }

    [Test]
    public void WriteUInt16()
    {
        Span<byte> data = stackalloc byte[sizeof(ushort)];

        _endian.Write(data, (ushort)0x3039);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x30, 0x39 }));
    }

    [Test]
    public void WriteInt16()
    {
        Span<byte> data = stackalloc byte[sizeof(short)];

        _endian.Write(data, (short)-12345);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xCF, 0xC7 }));
    }

    [Test]
    public void WriteUInt32()
    {
        Span<byte> data = stackalloc byte[sizeof(uint)];

        _endian.Write(data, 0x12345678u);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x12, 0x34, 0x56, 0x78 }));
    }

    [Test]
    public void WriteInt32()
    {
        Span<byte> data = stackalloc byte[sizeof(int)];

        _endian.Write(data, -123456789);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xF8, 0xA4, 0x32, 0xEB }));
    }

    [Test]
    public void WriteUInt64()
    {
        Span<byte> data = stackalloc byte[sizeof(ulong)];

        _endian.Write(data, 0x0123456789ABCDEFul);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF }));
    }

    [Test]
    public void WriteInt64()
    {
        Span<byte> data = stackalloc byte[sizeof(long)];

        _endian.Write(data, -1234567890123456789L);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xEE, 0xDD, 0xEF, 0x0B, 0x82, 0x16, 0x7E, 0xEB }));
    }

    [Test]
    public void WriteUInt128()
    {
        Span<byte> data = stackalloc byte[16];

        _endian.Write(data, _uInt128Value);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF, 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10 }));
    }

    [Test]
    public void WriteInt128()
    {
        Span<byte> data = stackalloc byte[16];

        _endian.Write(data, Int128.MinValue);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }));
    }

    [Test]
    public void WriteHalf()
    {
        Span<byte> data = stackalloc byte[sizeof(ushort)];

        _endian.Write(data, (Half)1.5f);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x3E, 0x00 }));
    }

    [Test]
    public void WriteSingle()
    {
        Span<byte> data = stackalloc byte[sizeof(float)];

        _endian.Write(data, 1.5f);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0x3F, 0xC0, 0x00, 0x00 }));
    }

    [Test]
    public void WriteDouble()
    {
        Span<byte> data = stackalloc byte[sizeof(double)];

        _endian.Write(data, -2.5d);

        Assert.That(data.ToArray(), Is.EqualTo(new byte[] { 0xC0, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }));
    }
}
