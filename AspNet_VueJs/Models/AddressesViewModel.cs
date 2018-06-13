using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_VueJs.Models
{
    public class AddressesViewModel
    {
        private static Lazy<AddressesViewModel> _lazyInstance = new Lazy<AddressesViewModel>(() => new AddressesViewModel());
        public static AddressesViewModel Instance { get{ return _lazyInstance.Value; } }

        public List<AddressItemViewModel> AddressesList { get; private set; }
        
        private AddressesViewModel()
        {
            var addressesList = new List<AddressItemViewModel>();
            addressesList.Add(new AddressItemViewModel(1, "Иванов", "Иван", "Иванович", "Кирова, 51", "8-999-123-7654"));
            addressesList.Add(new AddressItemViewModel(2, "Петров", "Петр", "Петрович", "Тольяти, 11", "8-945-321-4567"));
            AddressesList = addressesList;
        }
    }
}
