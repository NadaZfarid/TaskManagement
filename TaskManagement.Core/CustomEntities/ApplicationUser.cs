using Microsoft.AspNetCore.Identity;
namespace TaskManagement.Core.CustomEntities
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom fields if needed
        public string FullName { get; set; }
    }
}
