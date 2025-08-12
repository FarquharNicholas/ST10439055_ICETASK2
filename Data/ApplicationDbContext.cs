using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentLogInIceTask.Models;

namespace StudentLogInIceTask.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserInformation>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
