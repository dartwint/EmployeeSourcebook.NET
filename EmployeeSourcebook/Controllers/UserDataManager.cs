using System.Xml.Serialization;

namespace EmployeeSourcebook.Controllers
{
    public static class UserDataManager
    {
        public static void SaveData<TData>(TData config, string path) where TData : class
        {
            try
            {
                var directory = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

                var serializer = new XmlSerializer(typeof(TData));
                using var writer = new StreamWriter(path);
                serializer.Serialize(writer, config);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on saving data with type: {typeof(TData)}. Reason:\n{ex.Message}");
            }
        }

        public static TData LoadData<TData>(string path) where TData : class, new()
        {
            if (!File.Exists(path))
                return new TData();

            try
            {
                var serializer = new XmlSerializer(typeof(TData));
                using var reader = new StreamReader(path);
                return (TData) serializer.Deserialize(reader)!;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on load data with type: {typeof(TData)}. Reason:\n{ex.Message}");
            }

            return new TData();
        }
    }
}
