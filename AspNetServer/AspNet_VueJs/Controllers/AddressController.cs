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

        [HttpGet(nameof(Info))]
        [Produces("application/json")]
        public AddressItem Info(int addressIndex)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            var result = new AddressService().Address(addressIndex);
            return result;
        }

        [HttpGet(nameof(Add))]
        //[HttpPost(nameof(Add))]
        [Produces("application/json")]
        public int Add(/*[FromBody]*/AddressItem item)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            var result = new AddressService().Add(item);
            return result;

        }

        [HttpGet(nameof(Remove))]
        [Produces("application/json")]
        public void Remove(int index)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            new AddressService().Remove(index);
        }

        [HttpGet(nameof(Change))]
        [Produces("application/json")]
        public void Change(AddressItem item)
        {
            this.ControllerContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", AccessControlForUrlBase);
            new AddressService().Change(item);
        }
    }
}
