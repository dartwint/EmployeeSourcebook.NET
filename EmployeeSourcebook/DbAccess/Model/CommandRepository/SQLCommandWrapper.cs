namespace EmployeeSourcebook.DbAccess.Model.CommandRepository
{
    public class SQLCommandWrapper
    {
        public string CommandText { get; set; }

        public SQLCommandWrapper(string commandText)
        {
            CommandText = commandText;
        }
    }
}
