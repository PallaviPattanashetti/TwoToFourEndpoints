using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TwoInputController : ControllerBase
    {

        private readonly TwoInputServices _twoInputServices;

        public TwoInputController(TwoInputServices twoInputServices)
        {
            _twoInputServices = twoInputServices;
        }

        [HttpGet]
        [Route("Fetch/{name}/{time}")]
        public string GetHello(string name, string time)
        {
            return _twoInputServices.GetHello(name, time);
        }
    }
}