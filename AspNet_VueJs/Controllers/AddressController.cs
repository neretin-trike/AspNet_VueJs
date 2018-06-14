using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet_VueJs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_VueJs.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        [HttpGet(nameof(Addresses))]
        [Produces("application/json")]
        public List<AddressItemViewModel> Addresses()
        {
            var result = AddressesViewModel.Instance.AddressesList;
            return result;
        }

        [HttpGet(nameof(Info))]
        [Produces("application/json")]
        public AddressItemViewModel Info(int addressIndex)
        {
            var result = AddressesViewModel.Instance.AddressesList.Where(a => a.Index == addressIndex).FirstOrDefault();
            return result;
        }

        [HttpPost(nameof(Add))]
        [Produces("application/json")]
        public void Add([FromBody]AddressItemViewModel item)
        {
            int newIndex = 1;
            while (true) {
                var isIndexExists = AddressesViewModel.Instance.AddressesList.Any(address => address.Index == newIndex);

                if (!isIndexExists)
                {
                    break;
                }

                newIndex++;
            }

            item.Index = newIndex;
            AddressesViewModel.Instance.AddressesList.Add(item);
        }
    }
}
