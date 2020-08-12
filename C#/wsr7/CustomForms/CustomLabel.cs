using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsr7.CustomForms
{
    public class CustomLabel : Label
    {
        public CustomLabel() : base()
        {
            Font = new Font("Roboto", 12, FontStyle.Bold);
            ForeColor = Color.FromArgb(84, 110, 122);
        }
    }
}
