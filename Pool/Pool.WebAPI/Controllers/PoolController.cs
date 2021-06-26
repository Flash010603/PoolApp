using System;
using System.Collections.Generic;
using System.IO.Ports;
using Microsoft.AspNetCore.Mvc;
using Pool.Core.Models;
using Pool.Infraestructure.Data;

namespace Pool.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class PoolController : ControllerBase
    {
        // SerialPort sp = new SerialPort();
        public PoolServices _poolServices;

        public PoolController(PoolServices poolServices)
        {
            _poolServices = poolServices;
            // sp.PortName = "COM6";
            // sp.BaudRate = 9600;
            // sp.DataBits = 8;
            // sp.Parity = Parity.None;
            // sp.StopBits = StopBits.One;
            // sp.Handshake = Handshake.None;
            
        }

        [HttpGet("{id}")]
        public ActionResult<Poolplace> GetPoolById(string id)
        {
            return _poolServices.TraerPoolId(id);
        }



        [HttpGet("user/{id}")]
        public ActionResult<List<Poolplace>> GetPoolByUser(string id)
        {
            return _poolServices.TraerPoolIdUsuario(id);
        }

        [HttpPost]
        public ActionResult<Poolplace> PostPool(Poolplace poolplace)
        {
            return _poolServices.CreateNewPool(poolplace);
        }

        [HttpPut]
        public ActionResult<Poolplace> PutPool(Poolplace poolplace)
        {
            // if(sp.IsOpen){
            //     string data = sp.ReadLine();
            //     string ph = data.Substring(0, data.Length - 2);
            //     poolplace.Ph_current = Convert.ToDecimal(data);
            //     sp.Dispose();
            //     sp.Close();

            // }else{
            //     sp.Open();

            //     string data = sp.ReadLine();
            //     string ph = data.Substring(0, data.Length - 2);
            //     poolplace.Ph_current = Convert.ToDecimal(data);
            //     sp.Dispose();
            //     sp.Close();
            // }
           

            // sp.Dispose();

            return _poolServices.UpdatePool(poolplace);
        }

        [HttpDelete("{id}")]
        public ActionResult DelPool(string id)
        {
            _poolServices.DeletePool(id);
            return Ok("Pool eliminada");
        }


    }
}