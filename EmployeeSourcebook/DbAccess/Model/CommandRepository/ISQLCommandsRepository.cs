namespace EmployeeSourcebook.DbAccess.Model.CommandRepository
{
    public interface ISQLCommandsRepository
    {
        bool AddCommand(SQLCommandKey key, SQLCommandWrapper commandWrapper);
        bool TryGetCommand(SQLCommandKey key, out SQLCommandWrapper? commandWrapper);
    }
}
