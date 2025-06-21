namespace EmployeeSourcebook.Views
{
    public interface ITabButtonDecorator<in TButton> where TButton : Button
    {
        void DecorateAsNotSelected(TButton button);
        void DecorateAsSelected(TButton button);
    }
}
