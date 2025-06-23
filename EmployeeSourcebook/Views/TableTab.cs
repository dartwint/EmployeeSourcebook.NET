namespace EmployeeSourcebook.Views
{
    public class TableTab : Button
    {
        public TableTab(string text)
        {
            AutoSize = false;
            Text = text;
            Margin = Padding.Empty;
            Padding = Padding.Empty;
            FlatStyle = FlatStyle.Flat;
            Anchor = AnchorStyles.Left | AnchorStyles.Top;
        }
    }
}
