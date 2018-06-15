using AspNet_VueJs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_VueJs.Services
{
    public class AddressService
    {
        public List<AddressItem> Addresses()
        {
            var result = AddressList.Instance.AddressesList
                .OrderBy(address => address.Surname)
                .ThenBy(address => address.Name)
                .ThenBy(address => address.Middlename)
                .ToList();
            return result;
        }
        
        public AddressItem Address(int addressIndex)
        {
            var result = AddressList.Instance.AddressesList.Where(a => a.Index == addressIndex).FirstOrDefault();
            return result;
        }
        
        public void Add(AddressItem item)
        {
            int newIndex = 1;
            while (true)
            {
                var isIndexExists = AddressList.Instance.AddressesList.Any(address => address.Index == newIndex);

                if (!isIndexExists)
                {
                    break;
                }

                newIndex++;
            }

            item.Index = newIndex;
            Models.AddressList.Instance.AddressesList.Add(item);
        }
        
        public void Remove(int index)
        {
            AddressList.Instance.AddressesList
                .Where(address => address.Index == index)
                .ToList()
                .ForEach(address => AddressList.Instance.AddressesList.Remove(address));
        }
        
        public void Change(AddressItem item)
        {
            Remove(item.Index);
            AddressList.Instance.AddressesList.Add(item);
        }
    }
}
