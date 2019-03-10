using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet_VueJs.Models;
using AspNet_VueJs.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_VueJs.Controllers
{
    [Route("api/[controller]")]
    public class AddressController : Controller
    {
        [HttpGet(nameof(Addresses))]
        [Produces("application/json")]
        public List<AddressItem> Addresses()
        {
            var result = new AddressService().Addresses();
            return result;
        }

        [HttpPost(nameof(Info))]
        [Produces("application/json")]
        public AddressItem Info([FromForm] int addressIndex)
        {
            var result = new AddressService().Address(addressIndex);
            return result;
        }

        [HttpPost(nameof(Add))]
        [Produces("application/json")]
        public int Add([FromForm] AddressItem item)
        {
            var result = new AddressService().Add(item);
            return result;

        }

        [HttpPost(nameof(Remove))]
        [Produces("application/json")]
        public void Remove([FromForm] int index)
        {
            new AddressService().Remove(index);
        }

        [HttpPost(nameof(Change))]
        [Produces("application/json")]
        public void Change([FromForm] AddressItem item)
        {
            new AddressService().Change(item);
        }
    }
}
