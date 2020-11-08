using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pitagorax.Demo.WebApi.Model;

namespace Pitagorax.Demo.WebApi.Model
{
    public class PitagoraxContext: DbContext
    {
        public PitagoraxContext(DbContextOptions<PitagoraxContext> options)
            : base(options)
        {
        }
        public DbSet<Pitagorax.Demo.WebApi.Model.User> User { get; set; }
    }
}
