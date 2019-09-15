using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileStructure
{
    static class BinaryIO
    {
        public static byte[] GetBytes(string filePath, long offset, int length)
        {
            using(FileStream fs=new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                Sanity.Requires(fs.Length >= offset + length, $"File length {fs.Length} is shorter than required {offset} + {length}.");
                fs.Seek(offset, SeekOrigin.Begin);
                using(BinaryReader br=new BinaryReader(fs))
                {
                    return br.ReadBytes(length);
                }
            }
        }

        public static void AppendBytes(string filePath, byte[] bytes)
        {
            Sanity.Requires(File.Exists(filePath), $"File {filePath} doesn't exist.");
            using(FileStream fs=new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
