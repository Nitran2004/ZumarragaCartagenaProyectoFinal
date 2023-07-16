using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LomasZumarraga_ProyectoFinal.Models;
using LomasZumarraga_ProyectoFinal.Data;

namespace LomasZumarraga_ProyectoFinal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeportesController : ControllerBase
    {
        private readonly DepDatabase _depDatabase;

        public DeportesController(DepDatabase depDatabase)
        {
            _depDatabase = depDatabase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Deportes>> GetAllDeportes()
        {
            var deportes = _depDatabase.GetAllDeportes();
            return Ok(deportes);
        }
    }
}
