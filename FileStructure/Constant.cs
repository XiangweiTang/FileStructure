using System;
using System.Collections.Generic;
using System.Text;

namespace FileStructure
{
    public static class Constant
    {
        // 256
        public const int TINY_TEXT_LENGTH = 256;
        // 1K
        public const int SHORT_TEXT_LENGTH = 1024;
        // 64K
        public const int LONG_TEXT_LENGTH = 1024 * 64;
        // 1K
        public const int TINY_BLOB_LENGTH = 1024;
        // 1M
        public const int SHORT_BLOB_LENGTH = 1024 * 1024;
        // 256M
        public const int LONG_BLOB_LENGTH = 1024 * 1024 * 256;
    }
}
