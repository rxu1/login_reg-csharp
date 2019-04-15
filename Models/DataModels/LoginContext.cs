using System;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Models
{
  public class LoginContext : DbContext
  {
    public LoginContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    
  }
}