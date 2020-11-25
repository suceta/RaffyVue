using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RaffyVue.DataModels.Entities
{
    public class Permiso
    {
            public int Id { get; set; }

            public string NombreEmpleado { get; set; }

            public string ApellidosEmpleado { get; set; }

            public int TipoPermiso { get; set; }

            public DateTime FechaPermiso { get; set; }
    }
}
