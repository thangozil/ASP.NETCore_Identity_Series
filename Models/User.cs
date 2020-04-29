using Microsoft.AspNetCore.Identity;

namespace IdentitySeries.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}