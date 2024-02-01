using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPLab2
{
    internal class DragableForm
    {
        private bool isDragging;
        private int mouseX, mouseY;

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Form form = sender as Form;

                form.Left += e.X - mouseX;
                form.Top += e.Y - mouseY;
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
