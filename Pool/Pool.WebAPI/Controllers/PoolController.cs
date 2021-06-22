using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pool.Core.Models;
using Pool.Infraestructure.Data;

namespace Pool.WebAPI.Controllers
{ 
    [ApiController]
    [Route("[controller]")]
    public class PoolController : ControllerBase
    {
        public PoolServices _poolServices;

        public PoolController(PoolServices poolServices)
        {
            _poolServices = poolServices;
        }

        [HttpGet("{id}")]
        public ActionResult<List<Poolplace>> GetPoolById(string id){
            return _poolServices.TraerPoolId(id);
        }

        [HttpGet("user/{id}")]
        public ActionResult<Poolplace> GetPoolByUser(string id){
            return _poolServices.TraerPoolIdUsuario(id);
        }

        [HttpPost]
        public ActionResult<Poolplace> PostPool(Poolplace poolplace){
            return _poolServices.CreateNewPool(poolplace);
        }

        [HttpPut]
        public ActionResult<Poolplace> PutPool(Poolplace poolplace){
            return _poolServices.UpdatePool(poolplace);
        }

        [HttpDelete("{id}")]
        public ActionResult DelPool(string id){
            _poolServices.DeletePool(id);
            return Ok("Pool eliminada");
        }
    }
}