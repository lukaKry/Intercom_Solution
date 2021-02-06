using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domofon_ClassLibrary
{
    public class Apartment
    {
        public Apartment(string resident, int number, int code)
        {
            Resident = resident;
            Number = number;
            Code = code;
        }

        public string Resident { get; set; }
        public int Number { get; set; }
        public int Code { get; set; }


        public  string ToStringForSave()
        {
            return Resident + ", " + Number + ", " + Code;
        }

        public override string ToString()
        {
            return $"{Number}. {Resident.Substring(0,1).ToUpper()+Resident.Substring(1).ToLower()}";
        }
    }
}
