namespace Endian;

/// <summary>
/// Interface for writing specific types into byte data, using a specific endianness.
/// </summary>
public interface IEndianWriter
{
    void Write(Span<byte> data, ushort value);
    void Write(Span<byte> data, short value);
    void Write(Span<byte> data, uint value);
    void Write(Span<byte> data, int value);
    void Write(Span<byte> data, ulong value);
    void Write(Span<byte> data, long value);
    void Write(Span<byte> data, UInt128 value);
    void Write(Span<byte> data, Int128 value);
    void Write(Span<byte> data, Half value);
    void Write(Span<byte> data, float value);
    void Write(Span<byte> data, double value);
}
