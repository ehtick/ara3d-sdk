using System;
using System.IO;
using System.IO.MemoryMappedFiles;

namespace Ara3D.Memory
{
    /// <summary>
    /// This address a limitation of memory mapped view accessor,
    /// in that you can't create sub-views from it. You need access 
    /// to the original memory mapped file. 
    /// </summary>
    public class MemoryMappedView : IDisposable
    {
        public MemoryMappedFile File { get; }
        public long Offset { get; }
        public long Size { get; }
        public MemoryMappedFileAccess Access { get; }
        public MemoryMappedViewAccessor Accessor { get; }

        public MemoryMappedView(MemoryMappedFile file, long offset, long size,
            MemoryMappedFileAccess access = MemoryMappedFileAccess.ReadWrite)
        {
            File = file;
            Offset = offset;
            Size = size;
            Access = access;
            Accessor = file.CreateViewAccessor(offset, size, access);
        }

        public void Dispose()
            => Accessor.Dispose();

        /// <summary>Maps the file read-only and shared for reading, so several readers of
        /// one file, in this process or another, never lock each other out.</summary>
        public static void ReadFile(string filePath, Action<MemoryMappedView> action)
        {
            using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var mmf = MemoryMappedFile.CreateFromFile(stream, null, 0,
                MemoryMappedFileAccess.Read, HandleInheritability.None, leaveOpen: false);
            using var view = new MemoryMappedView(mmf, 0, stream.Length, MemoryMappedFileAccess.Read);
            action(view);
        }
    }
}