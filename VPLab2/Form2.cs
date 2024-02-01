using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace VPLab2
{
    public partial class FormWeight : System.Windows.Forms.Form
    {
        private DragableForm dragableForm = new DragableForm();

        public FormWeight()
        {
            InitializeComponent();

            this.MouseDown += dragableForm.MouseDown;
            this.MouseMove += dragableForm.MouseMove;
            this.MouseUp += dragableForm.MouseUp;
        }

        private void textBoxKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowNumbers(sender, e);
        }

        private void textBoxKg_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxKg.Text, out _))
            {
                btnConvert.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double kg = Convert.ToDouble(textBoxKg.Text);

            double americanPoundResult = Math.Round(kg * (1 / 0.45359237), 2);
            double russianPoundResult = Math.Round(kg * (1 / 0.4095120375), 2);
            double russianPudResult = Math.Round(kg * (1 / 16.3804815), 2);

            labelAmericanPaundResult.Text = americanPoundResult.ToString();
            labelRussianPaundResult.Text = russianPoundResult.ToString();
            labelRussianPudResult.Text = russianPudResult.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
