using System;
using System.Collections.Generic;
using System.Text;

namespace UML_to_CODE
{
    public struct Address
    {
        public string street;
        public string city;
        public string state;
        public int PostalCode;
        public string country;
        public Person person;

        public bool Validate()
        {
            return true;
        }
    }
}
