using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Organization.Repository
{
    public class CompanyRepository : BaseRepository<Company>
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}