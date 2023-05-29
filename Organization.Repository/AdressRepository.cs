using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Organization.Entities;

namespace Organization.Repository
{
    public class AdressRepository : BaseRepository<Adress>
    {
        public AdressRepository(ApplicationDbContext context) : base(context) { }
    }
}