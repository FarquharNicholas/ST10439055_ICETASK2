using Microsoft.AspNetCore.Identity;

namespace StudentLogInIceTask.Models
{
    public class UserInformation : IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Qualification { get; set; }
        public string Module { get; set; }
    }
}
