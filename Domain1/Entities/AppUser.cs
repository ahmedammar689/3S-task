using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain1.Entities;
public class AppUser : IdentityUser
{
    [Required]
    [MaxLength(20)]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A\u0660-\u0669]+$", ErrorMessage = "First name can only contain Arabic or English letters and spaces.")]
    public string FirstName { get; set; }

    [MaxLength(40)]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A\u0660-\u0669]+$", ErrorMessage = "Middle name can only contain Arabic or English letters and spaces.")]
    public string MiddleName { get; set; }

    [Required]
    [MaxLength(20)]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A\u0660-\u0669]+$", ErrorMessage = "Last name can only contain Arabic or English letters and spaces.")]
    public string LastName { get; set; }

    [Required]

    public DateTime BirthDate { get; set; }

    [Required]
    [RegularExpression(@"^\+\d{1,3}\d{6,14}$", ErrorMessage = "Mobile number must be in the format +021006158123.")]
    public string MobileNumber { get; set; }

    [Required]
    [EmailAddress]
    public override string Email { get; set; }
    [Required]
    public List<Address> Addresses { get; set; } = new List<Address>();
}
