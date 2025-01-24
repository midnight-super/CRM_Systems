using System;
using System.ComponentModel.DataAnnotations;

namespace Role_based_authentication.Models;

public class RegisterViewModal
{
  [Required]
  public string? Name { get; set; }
  [Required]
  [EmailAddress]
  public string? Email { get; set; }
  [Required]
  [DataType(DataType.Password)]
  public string? Password { get; set; }
  [DataType(DataType.Password)]
  [Display(Name = "Confirm Password")]
  [Compare("Password", ErrorMessage = "Password and confirmation password do not match")]
  public string? ConfirmPassword { get; set; }
}
