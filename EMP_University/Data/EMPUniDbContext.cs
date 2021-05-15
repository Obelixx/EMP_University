using Common.Interfaces;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class EMPUniDbContext : IdentityDbContext, IEMPUniDbContext
    {
        public EMPUniDbContext(DbContextOptions<EMPUniDbContext> options)
            : base(options)
        {
        }
    }
}
