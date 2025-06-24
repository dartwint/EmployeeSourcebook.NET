using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("Positions")]
    public class Positions
    {
        [Column("Id")]
        public ulong Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }
}
