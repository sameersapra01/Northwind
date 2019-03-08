using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Models
{
    [Table("EmployeeTerritories")]
    public class EmployeeTerritories
    {
        [ForeignKey("FK_EmployeeTerritories_Employees")]
        public int EmployeeID { get; set; }

        //[ForeignKey("FK_EmployeeTerritories_Territories")]
        //public int TerritoryID { get; set; }

        public List<Employee> Employees { get; set; }

        
    }
}