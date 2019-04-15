using System.ComponentModel.DataAnnotations;

namespace LoginRegistration.Models
{
  public class Login
  {
    [Required]
    public string LoginEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string LoginPassword { get; set; }
  }
}