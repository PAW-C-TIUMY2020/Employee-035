﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee-035.Models
{
    public class Employees
    public int EmployeeId { get; set; }
[Column(TypeName = "nvarchar(250)")]
[Required(ErrorMessage = "This field is required.")]
[DisplayName("Full Name")]
public string FullName { get; set; }
[Column(TypeName = "varchar(10)")]
[DisplayName("Emp. Code")]
public string EmpCode { get; set; }
[Column(TypeName = "varchar(100)")]
public string Position { get; set; }
[Column(TypeName = "varchar(100)")]
[DisplayName("Office Location")]
public string OfficeLocation { get; set; }
{
}
}
