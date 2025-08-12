using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeApplicatoin.Models;

namespace EmployeeApplicatoin.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserInformation>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
