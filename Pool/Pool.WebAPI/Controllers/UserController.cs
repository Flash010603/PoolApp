using Microsoft.AspNetCore.Mvc;
using Pool.Core.Models;
using Pool.Infraestructure.Data;

namespace Pool.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public PoolServices _poolServices;

        public UserController(PoolServices poolServices)
        {
            _poolServices = poolServices;
        }

        // =====================================================            
        
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(string id){
            return _poolServices.TraerUsuarioId(id);
        }

        // =====================================================

        [HttpPost]
        public ActionResult<User> PostUser(User user){
            return _poolServices.CreateUser(user);
        }

        // =====================================================

        [HttpPut]
        public ActionResult PutUser(User user){
            _poolServices.UpdateUser(user.Id,user);
            return Ok("Usuario actualizado");
        }

        // =====================================================

        [HttpDelete("{id}")]
        public ActionResult DelUser(string id){
            _poolServices.DeleteUser(id);
            return Ok("Usuario eliminando");
        }

        // =====================================================

        
    }
}