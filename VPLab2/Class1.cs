using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLab2
{
    internal class Validation
    {
        public static void AllowNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') 
                e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != ',') && (e.KeyChar != '-'))
                e.Handled = true;

            if ((e.KeyChar == ',' && ((sender as TextBox).Text.IndexOf(',') > -1 || (sender as TextBox).SelectionStart == 0 || (sender as TextBox).Text.StartsWith("-") && (sender as TextBox).Text.Length == 1)))
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0 && (sender as TextBox).SelectionStart != 0)
                e.Handled = true;
        }
    }
}
