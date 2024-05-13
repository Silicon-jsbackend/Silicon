using Microsoft.AspNetCore.Identity;

namespace BlazorApp.Data;


public class ApplicationUser : IdentityUser
{
    public string? UserProfileId { get; set; }
    public UserProfile? UserProfile { get; set; }
    public string? UserAddressId { get; set; }
    public UserAddress? UserAddress { get; set; }
}
