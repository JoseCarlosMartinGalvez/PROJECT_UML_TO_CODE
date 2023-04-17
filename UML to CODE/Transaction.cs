using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_CODE
{
    public struct Transaction
    {
        public string from;
        public string to;
        public float amount;
        public DateTime request;
        public Account account;
    }
}
