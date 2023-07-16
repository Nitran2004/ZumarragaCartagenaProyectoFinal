using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LomasZumarraga_ProyectoFinal.Data;
using LomasZumarraga_ProyectoFinal.Models;
using System.Runtime.InteropServices;

namespace LomasZumarraga_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArteController : ControllerBase
    {
        private readonly ArtDatabase _artDatabase;

        public ArteController(ArtDatabase artDatabase)
        {
            _artDatabase = artDatabase;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Arte>> GetAllArte()
        {
            var arteList = _artDatabase.GetAllArte();
            return Ok(arteList);
        }
    }
}

