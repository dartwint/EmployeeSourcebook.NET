using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("EmployeesHierarchy")]
    public class EmployeeHierarchy
    {
        [Column("AncestorId")]
        public ulong AncestorId { get; set; }

        [Column("DescendantId")]
        public ulong DescendantId { get; set; }

        [Column("Depth")]
        public ulong Depth { get; set; }
    }
}
