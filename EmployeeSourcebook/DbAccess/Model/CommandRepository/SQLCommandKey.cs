namespace EmployeeSourcebook.DbAccess.Model.CommandRepository
{
    public sealed class SQLCommandKey
    {
        public TypeOfCommand CommandType { get; }
        public string Name { get; }

        public SQLCommandKey(TypeOfCommand commandType, string name)
        {
            CommandType = commandType;
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is SQLCommandKey other &&
                   CommandType == other.CommandType &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CommandType, Name);
        }

        public override string ToString() => $"{CommandType}: {Name}";
    }
}
