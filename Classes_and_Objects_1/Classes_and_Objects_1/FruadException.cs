using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_1
{
    public class FruadException : Exception
    {
        public FruadException()
            : base() { }
        public FruadException(string mesage)
            : base(message) { }
    }
}
