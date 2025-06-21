namespace EmployeeSourcebook.Domain
{
    public interface IFormFactory<TForm> where TForm : Form
    {
        TForm Create();
    }
}
