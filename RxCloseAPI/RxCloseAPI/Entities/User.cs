using Microsoft.AspNetCore.Identity;

namespace RxCloseAPI.Entities
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
