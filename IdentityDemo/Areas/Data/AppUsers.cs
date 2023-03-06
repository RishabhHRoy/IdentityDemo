using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Areas.Data
{
    public class AppUsers : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? MobileNo { get; set; }
        public string? Address { get; set; }
        public object FullName { get; internal set; }
    }
}
