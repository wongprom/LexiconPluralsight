using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LexiconPluralsight.HR
{
    internal class Address
    {
        //Field
        private string street;
        private string city;
        private string zipCode;
        private string houseNumber;

        //Constructor
        public Address(string street, string houseNumber, string zipCode, string city)
        {
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
            City = city;
        }

        //Property
        public string Street
        {
            get { return street; }
            set
            {
                street = value;
            }
        }
        public string HouseNumber
        {
            get { return houseNumber; }
            set
            {
                houseNumber = value;
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                zipCode = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
    }
}
