using RaffyVue.DataModels;
using RaffyVue.DataModels.Entities;
using RaffyVue.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RaffyVue.Repository
{

    public class TipoPermisoRepository : Repository<TipoPermiso>, ITipoPermisoRepository
    {
        //private readonly VueDBContext context;

        public TipoPermisoRepository(VueDBContext context) : base(context)
        {
            //this.context = context;
        }

    }
}
