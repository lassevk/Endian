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

        public async ValueTask<ushort> ReadUInt16Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ushort)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadUInt16(buffer);
        }

        public short ReadInt16(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(short)];
            stream.ReadExactly(buffer);
            return reader.ReadInt16(buffer);
        }

        public async ValueTask<short> ReadInt16Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(short)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadInt16(buffer);
        }

        public uint ReadUInt32(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(uint)];
            stream.ReadExactly(buffer);
            return reader.ReadUInt32(buffer);
        }

        public async ValueTask<uint> ReadUInt32Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(uint)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadUInt32(buffer);
        }

        public int ReadInt32(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(int)];
            stream.ReadExactly(buffer);
            return reader.ReadInt32(buffer);
        }

        public async ValueTask<int> ReadInt32Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(int)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadInt32(buffer);
        }

        public ulong ReadUInt64(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ulong)];
            stream.ReadExactly(buffer);
            return reader.ReadUInt64(buffer);
        }

        public async ValueTask<ulong> ReadUInt64Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ulong)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadUInt64(buffer);
        }

        public long ReadInt64(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(long)];
            stream.ReadExactly(buffer);
            return reader.ReadInt64(buffer);
        }

        public async ValueTask<long> ReadInt64Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(long)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadInt64(buffer);
        }

        public UInt128 ReadUInt128(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[16];
            stream.ReadExactly(buffer);
            return reader.ReadUInt128(buffer);
        }

        public async ValueTask<UInt128> ReadUInt128Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[16];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadUInt128(buffer);
        }

        public Int128 ReadInt128(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[16];
            stream.ReadExactly(buffer);
            return reader.ReadInt128(buffer);
        }

        public async ValueTask<Int128> ReadInt128Async(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[16];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadInt128(buffer);
        }

        public Half ReadHalf(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(ushort)];
            stream.ReadExactly(buffer);
            return reader.ReadHalf(buffer);
        }

        public async ValueTask<Half> ReadHalfAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(ushort)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadHalf(buffer);
        }

        public float ReadSingle(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(float)];
            stream.ReadExactly(buffer);
            return reader.ReadSingle(buffer);
        }

        public async ValueTask<float> ReadSingleAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(float)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadSingle(buffer);
        }

        public double ReadDouble(Stream stream)
        {
            ArgumentNullException.ThrowIfNull(stream);

            Span<byte> buffer = stackalloc byte[sizeof(double)];
            stream.ReadExactly(buffer);
            return reader.ReadDouble(buffer);
        }

        public async ValueTask<double> ReadDoubleAsync(Stream stream, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(stream);

            byte[] buffer = new byte[sizeof(double)];
            await stream.ReadExactlyAsync(buffer.AsMemory(), cancellationToken);
            return reader.ReadDouble(buffer);
        }
    }
}
