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
        private const string AccessControlForUrlBase = "http://localhost:8080";

        [HttpGet(nameof(Addresses))]
        [Produces("application/json")]
        public List<AddressItem> Addresses()
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            var result = new AddressService().Addresses();
            return result;
        }

        [HttpPost(nameof(Info))]
        [Produces("application/json")]
        public AddressItem Info([FromForm] int addressIndex)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            var result = new AddressService().Address(addressIndex);
            return result;
        }

        [HttpPost(nameof(Add))]
        [Produces("application/json")]
        public int Add([FromForm] AddressItem item)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            var result = new AddressService().Add(item);
            return result;

        }

        [HttpPost(nameof(Remove))]
        [Produces("application/json")]
        public void Remove([FromForm] int index)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            new AddressService().Remove(index);
        }

        [HttpPost(nameof(Change))]
        [Produces("application/json")]
        public void Change([FromForm] AddressItem item)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            new AddressService().Change(item);
        }
    }
}
