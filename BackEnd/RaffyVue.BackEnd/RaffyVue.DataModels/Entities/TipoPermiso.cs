using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RaffyVue.DataModels.Entities
{

    public class TipoPermiso
    {
         [Key]
            public int Id { get; set; }

            public string Descripcion { get; set; }
    }

}
