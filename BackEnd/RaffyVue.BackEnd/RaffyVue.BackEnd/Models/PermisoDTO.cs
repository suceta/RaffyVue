using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaffyVue.BackEnd.Models
{
    public class PermisoDTO
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Tipo { get; set; }

        public string Fecha { get; set; }
    }
}
