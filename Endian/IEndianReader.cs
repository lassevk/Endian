namespace Endian;

/// <summary>
/// Interface for reading byte data into specific types, using a specific endianness.
/// </summary>
public interface IEndianReader
{
    ushort ReadUInt16(ReadOnlySpan<byte> data);
    short ReadInt16(ReadOnlySpan<byte> data);

    uint ReadUInt32(ReadOnlySpan<byte> data);
    int ReadInt32(ReadOnlySpan<byte> data);

    ulong ReadUInt64(ReadOnlySpan<byte> data);
    long ReadInt64(ReadOnlySpan<byte> data);

    UInt128 ReadUInt128(ReadOnlySpan<byte> data);
    Int128 ReadInt128(ReadOnlySpan<byte> data);

    Half ReadHalf(ReadOnlySpan<byte> data);
    float ReadSingle(ReadOnlySpan<byte> data);
    double ReadDouble(ReadOnlySpan<byte> data);
}
