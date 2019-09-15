using System;
using System.Collections.Generic;
using System.Text;

namespace FileStructure
{
    public static class Sanity
    {
        public static void Requires(bool b)
        {
            if (!b)
                throw new FSException();
        }
        public static void Requires(bool b, string message)
        {
            if (!b)
                throw new FSException(message);
        }
    }
}
