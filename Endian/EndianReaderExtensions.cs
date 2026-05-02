namespace Endian;

public static class EndianReaderExtensions
{
    extension(IEndianReader reader)
    {
        public ushort ReadUInt16(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ushort)];
            stream.ReadExactly(buffer);
            return reader.ReadUInt16(buffer);
        }

        public short ReadInt16(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(short)];
            stream.ReadExactly(buffer);
            return reader.ReadInt16(buffer);
        }

        public uint ReadUInt32(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(uint)];
            stream.ReadExactly(buffer);
            return reader.ReadUInt32(buffer);
        }

        public int ReadInt32(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(int)];
            stream.ReadExactly(buffer);
            return reader.ReadInt32(buffer);
        }

        public ulong ReadUInt64(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ulong)];
            stream.ReadExactly(buffer);
            return reader.ReadUInt64(buffer);
        }

        public long ReadInt64(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(long)];
            stream.ReadExactly(buffer);
            return reader.ReadInt64(buffer);
        }

        public float ReadSingle(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(float)];
            stream.ReadExactly(buffer);
            return reader.ReadSingle(buffer);
        }

        public double ReadDouble(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(double)];
            stream.ReadExactly(buffer);
            return reader.ReadDouble(buffer);
        }
    }
}