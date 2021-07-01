using System.Collections.Generic;
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


        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return _poolServices.TraerUsuarios();
        }

            
        // =====================================================            

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(string id)
        {
            return _poolServices.TraerUsuarioId(id);
        }

        // =====================================================

        [HttpPost("{user}&{pass}")]
        public ActionResult<User> LoginUser(string user, string pass)
        {
            return _poolServices.LogInUser(pass,user);
        }

        // =====================================================

        [HttpPost]
        public ActionResult<User> PostUser(User user)
        {
            return _poolServices.CreateUser(user);
        }

        // =====================================================

        [HttpPut]
        public ActionResult PutUser(User user)
        {
            _poolServices.UpdateUser(user.Id, user);
            return Ok("Usuario actualizado");
        }

        // =====================================================

        [HttpDelete("{id}")]
        public ActionResult DelUser(string id)
        {
            _poolServices.DeleteUser(id);
            return Ok("Usuario eliminando");
        }

        // =====================================================


    }
}