using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Frontend_Js_Backend.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Bio { get; set; }

    public string? ProfileImage { get; set; } = "avatar.png";

    public bool IsSubscribedToNewsletter { get; set; }

    public string? NewsletterEmail { get; set; }

    public string? UserRole { get; set; } = "User";

    public int? AddressId { get; set; }

    public AddressEntity? Address { get; set; }
}

public class AddressEntity
{
    [Key]

    public int Id { get; set; }

    public string? AddressLine1 { get; set; } 

    public string? AddressLine2 { get; set;}

    public string? PostalCode { get; set; } 

    public string? City { get; set; } 

}
