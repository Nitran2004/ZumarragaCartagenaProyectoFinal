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
    public class CulturaController : ControllerBase
    {
        private readonly CultDatabase _cultDatabase;

        public CulturaController(CultDatabase cultDatabase)
        {
            _cultDatabase = cultDatabase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cultura>> GetAllCultura()
        {
            var cultura = _cultDatabase.GetAllCultura();
            return Ok(cultura);
        }
    }
}
