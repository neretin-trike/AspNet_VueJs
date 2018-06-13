using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_VueJs.Models
{
    public class AddressItemViewModel
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public AddressItemViewModel()
        {
        }

        public AddressItemViewModel(int index, string name, string surname, string middlename, string address, string phone)
        {
            Index = index;
            Name = name;
            Surname = surname;
            Middlename = middlename;
            Address = address;
            Phone = phone;
        }
    }
}
