using EmployeeSourcebook.Models.DbTableToCSType;

namespace EmployeeSourcebook.Models.DbTables
{
    [Table("Addresses")]
    public class Address
    {
        [Column("Id")]
        public ulong Id { get; set; }

        [Column("PostalAddress")]
        public string PostalAddress { get; set; }
    }
}
