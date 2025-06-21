using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSourcebook.Views
{
    internal class TabButtonDecorator<TButton> : ITabButtonDecorator<TButton>
        where TButton : Button
    {
        public void DecorateAsNotSelected(TButton button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Gray;
            button.BackColor = SystemColors.Control;
            button.ForeColor = SystemColors.ControlText;
            button.Font = new Font(button.Font, FontStyle.Regular);
        }

        public void DecorateAsSelected(TButton button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.DarkGray;
            button.BackColor = SystemColors.Window;
            button.ForeColor = SystemColors.ControlText;
            button.Font = new Font(button.Font, FontStyle.Bold);
        }
    }
}
