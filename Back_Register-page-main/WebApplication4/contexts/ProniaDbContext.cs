using Pronia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Pronia.contexts
{
    public class ProniaDbContext : IdentityDbContext<AppUser>
    {

        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {

        }
    }
}
