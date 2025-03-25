using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Frontend_Js_Backend.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Bio { get; set; }

    public string? ProfileImage { get; set; } = "avatar.png";

    public int? AddressId { get; set; }

    public AddressEntity? Address { get; set; }
}

public class AddressEntity
{
    [Key]

    public int Id { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set;}

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

}
