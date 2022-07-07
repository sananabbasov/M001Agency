using Microsoft.AspNetCore.Identity;

namespace Agency.Models
{
    public class M001User : IdentityUser
    {
        public string Fullname { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}
