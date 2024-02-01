using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPLab2
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private Button btnWeight;
        private Button btnSpeed;
        private Button btnCurrency;
        private Button btnExit;

        private DragableForm dragableForm = new DragableForm();

        public FormMain()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            Bitmap image = new Bitmap(Properties.Resources.main);
            this.Size = image.Size;

            this.BackgroundImage = image;
            this.TransparencyKey = Color.Black;

            this.Icon = Properties.Resources.logo_white;

            btnWeight = CreateButton(new Point(160, 63), Properties.Resources.weight, btnWeight_Click);
            btnSpeed = CreateButton(new Point(130, 170), Properties.Resources.speed, btnSpeed_Click);
            btnCurrency = CreateButton(new Point(130, 260), Properties.Resources.currency, btnCurrency_Click);
            btnExit = CreateButton(new Point(190, 370), Properties.Resources.exit, btnExit_Click);

            this.MouseDown += dragableForm.MouseDown;
            this.MouseMove += dragableForm.MouseMove;
            this.MouseUp += dragableForm.MouseUp;
        }

        private Button CreateButton(Point location, Image image, EventHandler clickHandler)
        {
            Button button = new Button();
            button.Cursor = Cursors.Hand;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.Image = image;
            button.Size = image.Size;
            button.Location = location;
            button.Click += clickHandler;
            Controls.Add(button);
            return button;
        }


        private void btnWeight_Click(object sender, EventArgs e)
        {
            FormWeight formWeight = new FormWeight(); ;
            formWeight.FormClosed += FormWeight_FormClosed;
            formWeight.Show();
            this.Hide();

        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            FormSpeed formSpeed = new FormSpeed(); ;
            formSpeed.FormClosed += FormWeight_FormClosed;
            formSpeed.Show();
            this.Hide();
        }

        private void btnCurrency_Click(object sender, EventArgs e)
        {
            FormCurrency formCurrency = new FormCurrency(); ;
            formCurrency.FormClosed += FormWeight_FormClosed;
            formCurrency.Show();
            this.Hide();
        }

        private void FormWeight_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}