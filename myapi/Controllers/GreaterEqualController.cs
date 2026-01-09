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
    public class GreaterEqualController : ControllerBase
    {
        private readonly GreaterEqualServices _greaterEqualServices;

        public GreaterEqualController(GreaterEqualServices greaterEqualServices)
        {
            _greaterEqualServices = greaterEqualServices;

        }
        [HttpGet]
        [Route("Fetch/{firstNumber}/{secondNumber}")]
        public string GetNumbers(int firstNumber, int secondNumber)
        {

            return _greaterEqualServices.GetNumbers(firstNumber, secondNumber);
           
        }
    }
}