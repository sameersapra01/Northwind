using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Northwind.Models
{
    public class ModelContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}