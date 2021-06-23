using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pool.Core.Models;
using Pool.Infraestructure.Data;

namespace Pool.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController: ControllerBase
    {
        public PoolServices _poolServices;

        public TableController(PoolServices poolServices)
        {
            _poolServices = poolServices;
        }

        [HttpGet("{id}")]
         public ActionResult<List<DataTable>> GetDataTable(string id){
            return _poolServices.TraerDataTable(id);
        }

        [HttpPost]
        public ActionResult<DataTable> CrearDataTable(DataTable dt)
        {
            return _poolServices.CreateDataTable(dt);
        }

        
    }
}