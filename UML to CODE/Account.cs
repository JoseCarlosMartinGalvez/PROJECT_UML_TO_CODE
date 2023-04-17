using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_CODE
{
    public abstract class Account
    {
        public string IBAN;
        protected float Amount;
        public bool transaction(string a)
        {
            return true;
        }
    }
}
