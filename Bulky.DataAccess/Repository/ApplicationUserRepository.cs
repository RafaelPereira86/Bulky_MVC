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
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private AplicationDbContext _db;
        public ApplicationUserRepository(AplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ApplicationUser applicationUser)
        {
           _db.ApplicationUsers.Update(applicationUser);    
        }
    }
}
