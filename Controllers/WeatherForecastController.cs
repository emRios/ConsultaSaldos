using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ConsultaSaldos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsultaSaldosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ConsultaSaldosController> _logger;

        public ConsultaSaldosController(ILogger<ConsultaSaldosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ConsultaSaldos> Get()
        {
            var rng = new Random();
            int  vSaldoContable ;
            int vCompensacion;
            int vSaldoTotal;
            vSaldoContable = rng.Next(50, 55);
            vCompensacion = rng.Next(12, 25);
            vSaldoTotal = vSaldoContable + vCompensacion;


            return Enumerable.Range(1, 1).Select(index => new ConsultaSaldos
            {
                
                FEchaConsulta = DateTime.Now.AddDays(index),
                SaldoContable = vSaldoContable,
                Compensacion  = vCompensacion,
                SaltoTotal    = vSaldoTotal,
                Nombre     = "Ernesto Jimenez"
            })
            .ToArray();
        }
    }
}
