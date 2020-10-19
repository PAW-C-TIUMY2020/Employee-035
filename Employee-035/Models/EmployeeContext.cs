using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee-035.Models
{
    public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) :
   base(options)
    { }
    public DbSet<Employees> Employees { get; set; }
}
{
}
}
