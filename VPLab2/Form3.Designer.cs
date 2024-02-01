namespace VPLab2
{
    partial class FormSpeed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpeed));
            this.textBoxKmh = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.unitsOfSpeed = new System.Windows.Forms.GroupBox();
            this.labelFeetPerSecondResult = new System.Windows.Forms.Label();
            this.labelMilesPerHourResult = new System.Windows.Forms.Label();
            this.labelKnotResult = new System.Windows.Forms.Label();
            this.labelMeterPerSecondResult = new System.Windows.Forms.Label();
            this.labelRussianPudResult = new System.Windows.Forms.Label();
            this.labelRussianPaundResult = new System.Windows.Forms.Label();
            this.labelAmericanPaundResult = new System.Windows.Forms.Label();
            this.labelFeetPerSecond = new System.Windows.Forms.Label();
            this.labelMilesPerHour = new System.Windows.Forms.Label();
            this.labelKnot = new System.Windows.Forms.Label();
            this.labelMeterPerSecond = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.unitsOfSpeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxKmh
            // 
            this.textBoxKmh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxKmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxKmh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKmh.ForeColor = System.Drawing.Color.White;
            this.textBoxKmh.Location = new System.Drawing.Point(20, 37);
            this.textBoxKmh.Name = "textBoxKmh";
            this.textBoxKmh.Size = new System.Drawing.Size(200, 20);
            this.textBoxKmh.TabIndex = 0;
            this.textBoxKmh.TextChanged += new System.EventHandler(this.textBoxKmh_TextChanged);
            this.textBoxKmh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKmh_KeyPress);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConvert.Enabled = false;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(20, 183);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(145, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // unitsOfSpeed
            // 
            this.unitsOfSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitsOfSpeed.Controls.Add(this.labelFeetPerSecondResult);
            this.unitsOfSpeed.Controls.Add(this.labelMilesPerHourResult);
            this.unitsOfSpeed.Controls.Add(this.labelKnotResult);
            this.unitsOfSpeed.Controls.Add(this.labelMeterPerSecondResult);
            this.unitsOfSpeed.Controls.Add(this.labelRussianPudResult);
            this.unitsOfSpeed.Controls.Add(this.labelRussianPaundResult);
            this.unitsOfSpeed.Controls.Add(this.labelAmericanPaundResult);
            this.unitsOfSpeed.Controls.Add(this.labelFeetPerSecond);
            this.unitsOfSpeed.Controls.Add(this.labelMilesPerHour);
            this.unitsOfSpeed.Controls.Add(this.labelKnot);
            this.unitsOfSpeed.Controls.Add(this.labelMeterPerSecond);
            this.unitsOfSpeed.ForeColor = System.Drawing.Color.White;
            this.unitsOfSpeed.Location = new System.Drawing.Point(20, 63);
            this.unitsOfSpeed.Name = "unitsOfSpeed";
            this.unitsOfSpeed.Size = new System.Drawing.Size(200, 113);
            this.unitsOfSpeed.TabIndex = 5;
            this.unitsOfSpeed.TabStop = false;
            this.unitsOfSpeed.Text = "Convert kilometers per hour to";
            // 
            // labelFeetPerSecondResult
            // 
            this.labelFeetPerSecondResult.AutoSize = true;
            this.labelFeetPerSecondResult.Location = new System.Drawing.Point(116, 80);
            this.labelFeetPerSecondResult.Name = "labelFeetPerSecondResult";
            this.labelFeetPerSecondResult.Size = new System.Drawing.Size(0, 13);
            this.labelFeetPerSecondResult.TabIndex = 5;
            // 
            // labelMilesPerHourResult
            // 
            this.labelMilesPerHourResult.AutoSize = true;
            this.labelMilesPerHourResult.Location = new System.Drawing.Point(116, 60);
            this.labelMilesPerHourResult.Name = "labelMilesPerHourResult";
            this.labelMilesPerHourResult.Size = new System.Drawing.Size(0, 13);
            this.labelMilesPerHourResult.TabIndex = 5;
            // 
            // labelKnotResult
            // 
            this.labelKnotResult.AutoSize = true;
            this.labelKnotResult.Location = new System.Drawing.Point(116, 40);
            this.labelKnotResult.Name = "labelKnotResult";
            this.labelKnotResult.Size = new System.Drawing.Size(0, 13);
            this.labelKnotResult.TabIndex = 5;
            // 
            // labelMeterPerSecondResult
            // 
            this.labelMeterPerSecondResult.AutoSize = true;
            this.labelMeterPerSecondResult.Location = new System.Drawing.Point(116, 20);
            this.labelMeterPerSecondResult.Name = "labelMeterPerSecondResult";
            this.labelMeterPerSecondResult.Size = new System.Drawing.Size(0, 13);
            this.labelMeterPerSecondResult.TabIndex = 5;
            // 
            // labelRussianPudResult
            // 
            this.labelRussianPudResult.AutoSize = true;
            this.labelRussianPudResult.Location = new System.Drawing.Point(110, 60);
            this.labelRussianPudResult.Name = "labelRussianPudResult";
            this.labelRussianPudResult.Size = new System.Drawing.Size(0, 13);
            this.labelRussianPudResult.TabIndex = 4;
            // 
            // labelRussianPaundResult
            // 
            this.labelRussianPaundResult.AutoSize = true;
            this.labelRussianPaundResult.Location = new System.Drawing.Point(110, 40);
            this.labelRussianPaundResult.Name = "labelRussianPaundResult";
            this.labelRussianPaundResult.Size = new System.Drawing.Size(0, 13);
            this.labelRussianPaundResult.TabIndex = 4;
            // 
            // labelAmericanPaundResult
            // 
            this.labelAmericanPaundResult.AutoSize = true;
            this.labelAmericanPaundResult.Location = new System.Drawing.Point(110, 20);
            this.labelAmericanPaundResult.Name = "labelAmericanPaundResult";
            this.labelAmericanPaundResult.Size = new System.Drawing.Size(0, 13);
            this.labelAmericanPaundResult.TabIndex = 4;
            // 
            // labelFeetPerSecond
            // 
            this.labelFeetPerSecond.AutoSize = true;
            this.labelFeetPerSecond.Location = new System.Drawing.Point(20, 80);
            this.labelFeetPerSecond.Name = "labelFeetPerSecond";
            this.labelFeetPerSecond.Size = new System.Drawing.Size(87, 13);
            this.labelFeetPerSecond.TabIndex = 3;
            this.labelFeetPerSecond.Text = "Feet per second:";
            // 
            // labelMilesPerHour
            // 
            this.labelMilesPerHour.AutoSize = true;
            this.labelMilesPerHour.Location = new System.Drawing.Point(20, 60);
            this.labelMilesPerHour.Name = "labelMilesPerHour";
            this.labelMilesPerHour.Size = new System.Drawing.Size(76, 13);
            this.labelMilesPerHour.TabIndex = 3;
            this.labelMilesPerHour.Text = "Miles per hour:";
            // 
            // labelKnot
            // 
            this.labelKnot.AutoSize = true;
            this.labelKnot.Location = new System.Drawing.Point(20, 40);
            this.labelKnot.Name = "labelKnot";
            this.labelKnot.Size = new System.Drawing.Size(32, 13);
            this.labelKnot.TabIndex = 2;
            this.labelKnot.Text = "Knot:";
            // 
            // labelMeterPerSecond
            // 
            this.labelMeterPerSecond.AutoSize = true;
            this.labelMeterPerSecond.Location = new System.Drawing.Point(20, 20);
            this.labelMeterPerSecond.Name = "labelMeterPerSecond";
            this.labelMeterPerSecond.Size = new System.Drawing.Size(93, 13);
            this.labelMeterPerSecond.TabIndex = 1;
            this.labelMeterPerSecond.Text = "Meter per second:";
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(20, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(54, 17);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "Speed";
            // 
            // FormSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(240, 226);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.unitsOfSpeed);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBoxKmh);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSpeed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed";
            this.unitsOfSpeed.ResumeLayout(false);
            this.unitsOfSpeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKmh;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox unitsOfSpeed;
        private System.Windows.Forms.Label labelRussianPudResult;
        private System.Windows.Forms.Label labelRussianPaundResult;
        private System.Windows.Forms.Label labelAmericanPaundResult;
        private System.Windows.Forms.Label labelMilesPerHour;
        private System.Windows.Forms.Label labelKnot;
        private System.Windows.Forms.Label labelMeterPerSecond;
        private System.Windows.Forms.Label labelFeetPerSecond;
        private System.Windows.Forms.Label labelMeterPerSecondResult;
        private System.Windows.Forms.Label labelFeetPerSecondResult;
        private System.Windows.Forms.Label labelMilesPerHourResult;
        private System.Windows.Forms.Label labelKnotResult;
        private System.Windows.Forms.Label labelHeader;
    }
}