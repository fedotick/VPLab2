using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VPLab2
{
    public partial class FormSpeed : Form
    {
        private DragableForm dragableForm = new DragableForm();

        public FormSpeed()
        {
            InitializeComponent();

            this.MouseDown += dragableForm.MouseDown;
            this.MouseMove += dragableForm.MouseMove;
            this.MouseUp += dragableForm.MouseUp;
        }

        private void textBoxKmh_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.AllowNumbers(sender, e);
        }

        private void textBoxKmh_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxKmh.Text, out _))
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
            double kmh = Convert.ToDouble(textBoxKmh.Text);

            double meterPerSecondResult = Math.Round(kmh * (1 / 3.6), 2);
            double knotResult = Math.Round(kmh * (1 / 1.852), 2);
            double milesPerHourResult = Math.Round(kmh * (1 / 1.609), 2);
            double feetPerSecondResult = Math.Round(kmh * (1 / 1.09728), 2);

            labelMeterPerSecondResult.Text = meterPerSecondResult.ToString();
            labelKnotResult.Text = knotResult.ToString();
            labelMilesPerHourResult.Text = milesPerHourResult.ToString();
            labelFeetPerSecondResult.Text = feetPerSecondResult.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
