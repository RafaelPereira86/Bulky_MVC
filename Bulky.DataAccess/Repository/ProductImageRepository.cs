using Bulky.DataAcess.Data;
using Bulky.DataAcess.Repository.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAcess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private AplicationDbContext _db;
        public ProductImageRepository(AplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ProductImage obj)
        {
           _db.ProductImages.Update(obj);
        }
    }
}
