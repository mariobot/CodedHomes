using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedHomes.Models;
using System.Data.Entity;

namespace CodedHomes.Data
{
    public class HomeRepository : GenericRepository<Home>
    {
        public HomeRepository(DbContext context) : base(context) { }
    }
}
