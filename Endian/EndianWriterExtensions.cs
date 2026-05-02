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

        public async ValueTask WriteAsync(Stream stream, ushort value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ushort)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, short value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(short)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, short value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(short)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, uint value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(uint)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, uint value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(uint)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, int value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(int)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, int value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(int)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, ulong value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ulong)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, ulong value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ulong)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, long value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(long)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, long value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(long)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, UInt128 value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[16];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, UInt128 value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[16];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, Int128 value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[16];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, Int128 value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[16];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, Half value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ushort)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, Half value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ushort)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, float value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(float)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, float value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(float)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }

        public void Write(Stream stream, double value)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(double)];
            writer.Write(buffer, value);
            stream.Write(buffer);
        }

        public async ValueTask WriteAsync(Stream stream, double value, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(double)];
            writer.Write(buffer, value);
            await stream.WriteAsync(buffer.AsMemory(), cancellationToken);
        }
    }
}
