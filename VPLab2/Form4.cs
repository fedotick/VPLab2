using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VPLab2
{
    public partial class FormCurrency : Form
    {
        private DragableForm dragableForm = new DragableForm();

        public FormCurrency()
        {
            InitializeComponent();

            this.MouseDown += dragableForm.MouseDown;
            this.MouseMove += dragableForm.MouseMove;
            this.MouseUp += dragableForm.MouseUp;
        }

        private void textBoxLei_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowNumbers(sender, e);
        }

        private void textBoxLei_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxLei.Text, out _))
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
            double MLD = Convert.ToDouble(textBoxLei.Text);

            double USD = Math.Round(MLD * (1 / 17.2360), 2);
            double EUR = Math.Round(MLD * (1 / 20.9444), 2);
            double UAH = Math.Round(MLD * (1 / 0.6147), 2);
            double RON = Math.Round(MLD * (1 / 4.2994), 2);
            double RUB = Math.Round(MLD * (1 / 0.2326), 2);

            labelUSDResult.Text = USD.ToString();
            labelEURResult.Text = EUR.ToString();
            labelUAHResult.Text = UAH.ToString();
            labelRONResult.Text = RON.ToString();
            labelRUBResult.Text = RUB.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
