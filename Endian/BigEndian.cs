namespace Endian;

using System.Buffers.Binary;

public sealed class BigEndian : IEndianReaderWriter
{
    public ushort ReadUInt16(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt16BigEndian(data);
    }

    public short ReadInt16(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt16BigEndian(data);
    }

    public uint ReadUInt32(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt32BigEndian(data);
    }

    public int ReadInt32(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt32BigEndian(data);
    }

    public ulong ReadUInt64(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt64BigEndian(data);
    }

    public long ReadInt64(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt64BigEndian(data);
    }

    public UInt128 ReadUInt128(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt128BigEndian(data);
    }

    public Int128 ReadInt128(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt128BigEndian(data);
    }

    public Half ReadHalf(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadHalfBigEndian(data);
    }

    public float ReadSingle(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadSingleBigEndian(data);
    }

    public double ReadDouble(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadDoubleBigEndian(data);
    }

    public void Write(Span<byte> data, ushort value)
    {
        BinaryPrimitives.WriteUInt16BigEndian(data, value);
    }

    public void Write(Span<byte> data, short value)
    {
        BinaryPrimitives.WriteInt16BigEndian(data, value);
    }

    public void Write(Span<byte> data, uint value)
    {
        BinaryPrimitives.WriteUInt32BigEndian(data, value);
    }

    public void Write(Span<byte> data, int value)
    {
        BinaryPrimitives.WriteInt32BigEndian(data, value);
    }

    public void Write(Span<byte> data, ulong value)
    {
        BinaryPrimitives.WriteUInt64BigEndian(data, value);
    }

    public void Write(Span<byte> data, long value)
    {
        BinaryPrimitives.WriteInt64BigEndian(data, value);
    }

    public void Write(Span<byte> data, UInt128 value)
    {
        BinaryPrimitives.WriteUInt128BigEndian(data, value);
    }

    public void Write(Span<byte> data, Int128 value)
    {
        BinaryPrimitives.WriteInt128BigEndian(data, value);
    }

    public void Write(Span<byte> data, Half value)
    {
        BinaryPrimitives.WriteHalfBigEndian(data, value);
    }

    public void Write(Span<byte> data, float value)
    {
        BinaryPrimitives.WriteSingleBigEndian(data, value);
    }

    public void Write(Span<byte> data, double value)
    {
        BinaryPrimitives.WriteDoubleBigEndian(data, value);
    }
}
