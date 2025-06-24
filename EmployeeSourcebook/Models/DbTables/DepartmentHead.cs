using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("DepartmentHeads")]
    public class DepartmentHead
    {
        [Column("DepartmentId")]
        public ulong DepartmentId { get; set; }

        [Column("EmployeeId")]
        public ulong EmployeeId { get; set; }
    }
}
