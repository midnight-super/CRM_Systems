using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Role_based_authentication;

public class ApplicationDbContext : IdentityDbContext
{
  public ApplicationDbContext(DbContextOptions options) : base(options)
  {
  }

  protected ApplicationDbContext()
  {
  }
}
