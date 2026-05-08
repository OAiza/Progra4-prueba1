using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase
    {
        // SUMA
        [HttpGet("sumar")]
        public IActionResult Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;

            return Ok(new
            {
                Operacion = "Suma",
                Resultado = resultado
            });
        }

        // RESTA
        [HttpGet("restar")]
        public IActionResult Restar(int num1, int num2)
        {
            int resultado = num1 - num2;

            return Ok(new
            {
                Operacion = "Resta",
                Resultado = resultado
            });
        }
    }
}