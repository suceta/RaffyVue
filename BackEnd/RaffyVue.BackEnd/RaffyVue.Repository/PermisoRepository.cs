﻿using RaffyVue.DataModels;
using RaffyVue.DataModels.Entities;
using RaffyVue.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RaffyVue.Repository
{
    public class PermisoRepository : Repository<Permiso>, IPermisoRepository
    {
        //private readonly VueDBContext context;
    
        public PermisoRepository(VueDBContext context) : base(context)
        {
            //this.context = context;
        }

  

    }
}
