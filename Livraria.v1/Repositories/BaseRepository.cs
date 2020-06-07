﻿using Livraria.v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.v1.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
