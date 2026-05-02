namespace Endian;

/// <summary>
/// Combined interface that pulls in both <see cref="IEndianReader"/> and <see cref="IEndianWriter"/>.
/// </summary>
public interface IEndianReaderWriter : IEndianReader, IEndianWriter
{

}