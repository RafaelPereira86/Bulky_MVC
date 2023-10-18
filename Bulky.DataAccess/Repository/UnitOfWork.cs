﻿using Bulky.DataAcess.Data;
using Bulky.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(AplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }


        public void Save()
        {
            _db.SaveChanges();
        }
    }
}