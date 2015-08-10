using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedHomes.Models;
using System.Data.Entity;

namespace CodedHomes.Data
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
