using Endian;

namespace Endian.Tests;

public sealed class EndianReaderExtensionsTests
{
    private static readonly UInt128 _uInt128Value = ((UInt128)0x0123456789ABCDEFul << 64) | 0xFEDCBA9876543210ul;
    private readonly LittleEndian _endian = new();

    [Test]
    public void ReadStream()
    {
        Assert.That(_endian.ReadUInt16(Stream([0x39, 0x30])), Is.EqualTo(0x3039));
        Assert.That(_endian.ReadInt16(Stream([0xC7, 0xCF])), Is.EqualTo(-12345));
        Assert.That(_endian.ReadUInt32(Stream([0x78, 0x56, 0x34, 0x12])), Is.EqualTo(0x12345678u));
        Assert.That(_endian.ReadInt32(Stream([0xEB, 0x32, 0xA4, 0xF8])), Is.EqualTo(-123456789));
        Assert.That(_endian.ReadUInt64(Stream([0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01])), Is.EqualTo(0x0123456789ABCDEFul));
        Assert.That(_endian.ReadInt64(Stream([0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE])), Is.EqualTo(-1234567890123456789L));
        Assert.That(_endian.ReadUInt128(Stream([0x10, 0x32, 0x54, 0x76, 0x98, 0xBA, 0xDC, 0xFE, 0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01])), Is.EqualTo(_uInt128Value));
        Assert.That(_endian.ReadInt128(Stream([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80])), Is.EqualTo(Int128.MinValue));
        Assert.That(_endian.ReadHalf(Stream([0x00, 0x3E])), Is.EqualTo((Half)1.5f));
        Assert.That(_endian.ReadSingle(Stream([0x00, 0x00, 0xC0, 0x3F])), Is.EqualTo(1.5f));
        Assert.That(_endian.ReadDouble(Stream([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0])), Is.EqualTo(-2.5d));
    }

    [Test]
    public async Task ReadStreamAsync()
    {
        Assert.That(await _endian.ReadUInt16Async(Stream([0x39, 0x30])), Is.EqualTo(0x3039));
        Assert.That(await _endian.ReadInt16Async(Stream([0xC7, 0xCF])), Is.EqualTo(-12345));
        Assert.That(await _endian.ReadUInt32Async(Stream([0x78, 0x56, 0x34, 0x12])), Is.EqualTo(0x12345678u));
        Assert.That(await _endian.ReadInt32Async(Stream([0xEB, 0x32, 0xA4, 0xF8])), Is.EqualTo(-123456789));
        Assert.That(await _endian.ReadUInt64Async(Stream([0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01])), Is.EqualTo(0x0123456789ABCDEFul));
        Assert.That(await _endian.ReadInt64Async(Stream([0xEB, 0x7E, 0x16, 0x82, 0x0B, 0xEF, 0xDD, 0xEE])), Is.EqualTo(-1234567890123456789L));
        Assert.That(await _endian.ReadUInt128Async(Stream([0x10, 0x32, 0x54, 0x76, 0x98, 0xBA, 0xDC, 0xFE, 0xEF, 0xCD, 0xAB, 0x89, 0x67, 0x45, 0x23, 0x01])), Is.EqualTo(_uInt128Value));
        Assert.That(await _endian.ReadInt128Async(Stream([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80])), Is.EqualTo(Int128.MinValue));
        Assert.That(await _endian.ReadHalfAsync(Stream([0x00, 0x3E])), Is.EqualTo((Half)1.5f));
        Assert.That(await _endian.ReadSingleAsync(Stream([0x00, 0x00, 0xC0, 0x3F])), Is.EqualTo(1.5f));
        Assert.That(await _endian.ReadDoubleAsync(Stream([0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0xC0])), Is.EqualTo(-2.5d));
    }

    [Test]
    public void ReadStream_WithNullStream_Throws()
    {
        Assert.That(() => _endian.ReadUInt16((Stream)null!), Throws.ArgumentNullException);
    }

    [Test]
    public void ReadStream_WithTooFewBytes_Throws()
    {
        Assert.That(() => _endian.ReadUInt16(Stream([0x39])), Throws.TypeOf<EndOfStreamException>());
    }

    private static MemoryStream Stream(byte[] data)
    {
        return new MemoryStream(data);
    }
}
