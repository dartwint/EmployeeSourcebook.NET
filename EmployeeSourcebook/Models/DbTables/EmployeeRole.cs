using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("EmployeeRoles")]
    public class EmployeeRole
    {
        [Column("Id")]
        public ulong Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
