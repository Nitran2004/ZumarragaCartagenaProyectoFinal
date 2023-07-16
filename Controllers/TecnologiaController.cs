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
    public class TecnologiaController : ControllerBase
    {
        private readonly TecDatabase _tecDatabase;

        public TecnologiaController(TecDatabase tecDatabase)
        {
            _tecDatabase = tecDatabase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tecnologia>> GetAllTecnologia()
        {
            var tecnologia = _tecDatabase.GetAllTecnologia();
            return Ok(tecnologia);
        }
    }
}
