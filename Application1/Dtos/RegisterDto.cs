using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1.Dtos;
public class RegisterDto
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A]+$", ErrorMessage = "First name can contain only Arabic or English letters and spaces.")]
    public string FirstName { get; set; }

    [StringLength(40, ErrorMessage = "Middle name cannot be longer than 40 characters.")]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A]+$", ErrorMessage = "Middle name can contain only Arabic or English letters and spaces.")]
    public string MiddleName { get; set; }

    [Required(ErrorMessage = "Last name is required.")]
    [StringLength(20, ErrorMessage = "Last name cannot be longer than 20 characters.")]
    [RegularExpression(@"^[a-zA-Z\s\u0621-\u064A]+$", ErrorMessage = "Last name can contain only Arabic or English letters and spaces.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Birth date is required.")]
    [DataType(DataType.Date)]
   
    public DateTime BirthDate { get; set; }

    [Required(ErrorMessage = "Mobile number is required.")]
    [RegularExpression(@"^\+\d{12,}$", ErrorMessage = "Mobile number must be in the format +021006158123.")]
    public string MobileNumber { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.")]
    public string Password { get; set; }



}
