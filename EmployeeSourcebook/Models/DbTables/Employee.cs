using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("Employees")]
    public class Employee
    {
        [Column("Id")]
        public ulong Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Surname")]
        public string Surname { get; set; }

        [Column("Patronymic")]
        public string Patronymic { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("PositionId")]
        public ulong PositionId { get; set; }

        [Column("DepartmentId")]
        public ulong DepartmentId { get; set; }

        [Column("AddressId")]
        public ulong AddressId { get; set; }

        [Column("EmployeeRoleId")]
        public ulong EmployeeRoleId { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
