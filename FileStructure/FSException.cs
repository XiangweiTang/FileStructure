using System;
using System.Collections.Generic;
using System.Text;

namespace FileStructure
{
    public class FSException : Exception
    {
        public FSException() : base() { }
        public FSException(string message) : base(message) { }        
    }
}
