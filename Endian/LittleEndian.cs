namespace Endian;

using System.Buffers.Binary;

public sealed class LittleEndian : IEndianReaderWriter
{
    public ushort ReadUInt16(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt16LittleEndian(data);
    }

    public short ReadInt16(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt16LittleEndian(data);
    }

    public uint ReadUInt32(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt32LittleEndian(data);
    }

    public int ReadInt32(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt32LittleEndian(data);
    }

    public ulong ReadUInt64(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt64LittleEndian(data);
    }

    public long ReadInt64(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt64LittleEndian(data);
    }

    public UInt128 ReadUInt128(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadUInt128LittleEndian(data);
    }

    public Int128 ReadInt128(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadInt128LittleEndian(data);
    }

    public Half ReadHalf(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadHalfLittleEndian(data);
    }

    public float ReadSingle(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadSingleLittleEndian(data);
    }

    public double ReadDouble(ReadOnlySpan<byte> data)
    {
        return BinaryPrimitives.ReadDoubleLittleEndian(data);
    }

    public void Write(Span<byte> data, ushort value)
    {
        BinaryPrimitives.WriteUInt16LittleEndian(data, value);
    }

    public void Write(Span<byte> data, short value)
    {
        BinaryPrimitives.WriteInt16LittleEndian(data, value);
    }

    public void Write(Span<byte> data, uint value)
    {
        BinaryPrimitives.WriteUInt32LittleEndian(data, value);
    }

    public void Write(Span<byte> data, int value)
    {
        BinaryPrimitives.WriteInt32LittleEndian(data, value);
    }

    public void Write(Span<byte> data, ulong value)
    {
        BinaryPrimitives.WriteUInt64LittleEndian(data, value);
    }

    public void Write(Span<byte> data, long value)
    {
        BinaryPrimitives.WriteInt64LittleEndian(data, value);
    }

    public void Write(Span<byte> data, UInt128 value)
    {
        BinaryPrimitives.WriteUInt128LittleEndian(data, value);
    }

    public void Write(Span<byte> data, Int128 value)
    {
        BinaryPrimitives.WriteInt128LittleEndian(data, value);
    }

    public void Write(Span<byte> data, Half value)
    {
        BinaryPrimitives.WriteHalfLittleEndian(data, value);
    }

    public void Write(Span<byte> data, float value)
    {
        BinaryPrimitives.WriteSingleLittleEndian(data, value);
    }

    public void Write(Span<byte> data, double value)
    {
        BinaryPrimitives.WriteDoubleLittleEndian(data, value);
    }
}
