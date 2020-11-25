using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaffyVue.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RaffyVue.BackEnd.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisoController : ControllerBase
    {

        private readonly IPermisoRepository _permisoRepository;
        public PermisoController(IPermisoRepository permisoRepository) 
        {
            this._permisoRepository = permisoRepository;
        }

        // GET: api/<PermisoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var permisos = await _permisoRepository.GetAll();
            return Ok(permisos);
        }

        // GET api/<PermisoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PermisoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PermisoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PermisoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
