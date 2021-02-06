using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domofon_ClassLibrary
{
    public static class ApartmentsList
    {
        public static IList<Apartment> Apartments = new List<Apartment>();


        
        public static void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }

        
    }
}
