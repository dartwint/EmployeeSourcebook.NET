using System.Data.Common;
using System.Reflection;

namespace EmployeeSourcebook.Models.DbTableToCSType
{
    public static class DbAttributeMapper
    {
        public static async Task<List<T>> MapToListAsync<T>(DbCommand command) where T : new()
        {
            var list = new List<T>();

            using var reader = await command.ExecuteReaderAsync();

            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => Attribute.IsDefined(p, typeof(ColumnAttribute)));

            var columnMap = properties.ToDictionary(
                prop => prop.GetCustomAttribute<ColumnAttribute>()!.Name,
                prop => prop
            );

            while (await reader.ReadAsync())
            {
                var obj = new T();

                foreach (var column in columnMap)
                {
                    if (!reader.HasColumn(column.Key))
                        continue;

                    var value = reader[column.Key];
                    if (value is DBNull)
                        column.Value.SetValue(obj, null);
                    else
                        column.Value.SetValue(obj, Convert.ChangeType(value, column.Value.PropertyType));
                }

                list.Add(obj);
            }

            return list;
        }

        private static bool HasColumn(this DbDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
