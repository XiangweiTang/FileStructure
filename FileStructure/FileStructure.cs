using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace FileStructure
{
    class FileStructure
    {
        public FileStructure() { }
        public Header StructHeader { get; set; }
        
    }

    struct Header
    {
        public short HeaderLength { get; set; }
        public Schema[] Schemas { get; set; }
    }

    struct Schema
    {
        // 2 bytes
        public short SchemaLength { get; set; }
        // 1 byte
        public byte ValueType { get; set; }
        // 256 bytes
        public string SchemaName { get; set; }        
    }

    struct Cell
    {
        public int ValueLength { get; set; }
        public byte[] Value { get; set; }
    }
}
