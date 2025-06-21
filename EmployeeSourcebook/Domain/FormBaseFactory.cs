namespace EmployeeSourcebook.Domain
{
    public class FormBaseFactory<TForm> : IFormFactory<TForm> where TForm : Form, new()
    {
        public TForm Create()
        {
            return new TForm();
        }
    }
}
