using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET.NET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fristNumber}/{secondNumber}")]
        public IActionResult Get(string fristNumber,string secondNumber)
        {
            if (IsNumeric (fristNumber) && IsNumeric(secondNumber)) ;
            {
                var sum = ConvertToDecimal(fristNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private int ConvertToDecimal(string secondNumber)
        {
            throw new NotImplementedException();
        }

        private bool IsNumeric(string fristNumber)
        {
            throw new NotImplementedException();
        }
    }
}
