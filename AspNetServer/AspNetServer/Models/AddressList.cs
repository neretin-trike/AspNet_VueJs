using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_VueJs.Models
{
    public class AddressList
    {
        private static Lazy<AddressList> _lazyInstance = new Lazy<AddressList>(() => new AddressList());
        public static AddressList Instance { get{ return _lazyInstance.Value; } }

        public List<AddressItem> AddressesList { get; private set; }
        
        private AddressList()
        {
            var addressesList = new List<AddressItem>();
            addressesList.Add(new AddressItem(1, "Иван", "Иванов", "Иванович", "Кирова, 51", "8-999-123-7654"));
            addressesList.Add(new AddressItem(2, "Петр", "Петров", "Петрович", "Тольяти, 11", "8-945-321-4567"));
            AddressesList = addressesList;
        }
    }
}
