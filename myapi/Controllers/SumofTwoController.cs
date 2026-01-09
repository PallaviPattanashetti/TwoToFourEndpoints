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
    public class SumofTwoController : ControllerBase
    {
        
private readonly SumofTwoServices _sumofTwoServices;

public SumofTwoController(SumofTwoServices sumofTwoServices)
        {
            
            _sumofTwoServices = sumofTwoServices;
        }


[HttpGet]
[Route("Fetch/{num1}/{num2}")]
public string GetSum(int num1, int num2)
        {
            
            return _sumofTwoServices.GetSum(num1, num2);
        }

    }
}