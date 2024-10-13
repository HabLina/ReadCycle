using Microsoft.AspNetCore.Identity;

namespace ReadCycle.Models;

public class ApplicationUser : IdentityUser
{
    public required string? Nickname { get; set; }
    
    public required string? FirstName { get; set; }
    
    public required string? LastName { get; set; }
    
    public required string? Location { get; set; }
}