namespace Endian;

public static class EndianWriterExtensions
{
    extension(IEndianWriter writer)
    {
        public void Write(Stream stream, ushort value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ushort)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, short value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(short)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, uint value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(uint)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, int value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(int)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, ulong value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ulong)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, long value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(long)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, float value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(float)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public void Write(Stream stream, double value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(double)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }
    }
}