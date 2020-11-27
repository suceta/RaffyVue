using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaffyVue.BackEnd.Models;
using RaffyVue.DataModels.Entities;
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
        // POST api/<PermisoController>
        [HttpPost]
        public async Task<IActionResult> Post(PermisoDTO permisodto)
        {
            Permiso _permiso = new Permiso {NombreEmpleado = permisodto.Nombre
                , ApellidosEmpleado = permisodto.Apellido
                , TipoPermiso = permisodto.Tipo
                , FechaPermiso =Convert.ToDateTime(permisodto.Fecha) };
            return Ok(await this._permisoRepository.Create(_permiso));
        }
        // GET api/<PermisoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            return Ok(await this._permisoRepository.FindById(id));
        }

        // PUT api/<PermisoController>/5
        [HttpPut("{id}")]
        public void Put(PermisoDTO permisodto)
        {
            Permiso _permiso = new Permiso
            {
                Id = permisodto.Id,
                NombreEmpleado = permisodto.Nombre,
                ApellidosEmpleado = permisodto.Apellido ,
                TipoPermiso = permisodto.Tipo ,
                FechaPermiso = Convert.ToDateTime(permisodto.Fecha)
            };
            this._permisoRepository.Update(_permiso);
        }

        // DELETE api/<PermisoController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await this._permisoRepository.Delete(id);
        }
    }
}
