using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Adds two decimal numbers
        [HttpGet("add")]
        public ActionResult<decimal> Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a + b);
        }

        // Subtracts the second number from the first
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a - b);
        }

        // Multiplies two decimal numbers
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a * b);
        }

        // Divides the first number by the second, with a check to prevent division by zero
        [HttpGet("divide")]
        public ActionResult<decimal> Divide([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return Ok(a / b);
        }

        // Returns the remainder (modulo) of the division of the first number by the second
        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a % b);
        }
    }
}
