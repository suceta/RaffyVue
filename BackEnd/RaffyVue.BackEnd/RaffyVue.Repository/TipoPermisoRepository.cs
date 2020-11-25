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

        public async Task<TipoPermiso> CreateTipoPermiso(TipoPermiso entidad)
        {
            return await CreateAsync(entidad);
        }

        public async Task<TipoPermiso> UpdateTipoPermiso(TipoPermiso entidad)
        {
            return await UpdateAsync(entidad);
        }

        public async Task<bool> DeleteTipoPermiso(TipoPermiso entidad)
        {
            return await DeleteAsync(entidad);
        }
    }
}
