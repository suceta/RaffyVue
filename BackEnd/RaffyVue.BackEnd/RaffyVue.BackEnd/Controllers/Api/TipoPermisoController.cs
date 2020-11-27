using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaffyVue.Repository.Interfaces;

namespace RaffyVue.BackEnd.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPermisoController : ControllerBase
    {
        private readonly ITipoPermisoRepository _tipoPermisoRepository;
        public TipoPermisoController(ITipoPermisoRepository tipoPermisoRepository)
        {
            this._tipoPermisoRepository = tipoPermisoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var permisos = await _tipoPermisoRepository.GetAll();
            return Ok(permisos);
        }

    }
}
