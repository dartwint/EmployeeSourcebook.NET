using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("Departments")]
    public class Department
    {
        [Column("Id")]
        public ulong Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
