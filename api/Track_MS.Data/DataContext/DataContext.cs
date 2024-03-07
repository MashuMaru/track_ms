using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Track_MS.Data.DataContext
{
    public class DataContext : IdentityDbContext<IdentityUser>
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}