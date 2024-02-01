namespace VPLab2
{
    partial class FormWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeight));
            this.labelAmericanPound = new System.Windows.Forms.Label();
            this.labelRussianPound = new System.Windows.Forms.Label();
            this.labelRussianPud = new System.Windows.Forms.Label();
            this.unitsOfMass = new System.Windows.Forms.GroupBox();
            this.labelRussianPudResult = new System.Windows.Forms.Label();
            this.labelRussianPaundResult = new System.Windows.Forms.Label();
            this.labelAmericanPaundResult = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.textBoxKg = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.unitsOfMass.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAmericanPound
            // 
            this.labelAmericanPound.AutoSize = true;
            this.labelAmericanPound.Location = new System.Drawing.Point(20, 20);
            this.labelAmericanPound.Name = "labelAmericanPound";
            this.labelAmericanPound.Size = new System.Drawing.Size(87, 13);
            this.labelAmericanPound.TabIndex = 1;
            this.labelAmericanPound.Text = "American pound:";
            // 
            // labelRussianPound
            // 
            this.labelRussianPound.AutoSize = true;
            this.labelRussianPound.Location = new System.Drawing.Point(20, 40);
            this.labelRussianPound.Name = "labelRussianPound";
            this.labelRussianPound.Size = new System.Drawing.Size(81, 13);
            this.labelRussianPound.TabIndex = 2;
            this.labelRussianPound.Text = "Russian pound:";
            // 
            // labelRussianPud
            // 
            this.labelRussianPud.AutoSize = true;
            this.labelRussianPud.Location = new System.Drawing.Point(20, 60);
            this.labelRussianPud.Name = "labelRussianPud";
            this.labelRussianPud.Size = new System.Drawing.Size(69, 13);
            this.labelRussianPud.TabIndex = 3;
            this.labelRussianPud.Text = "Russian pud:";
            // 
            // unitsOfMass
            // 
            this.unitsOfMass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unitsOfMass.Controls.Add(this.labelRussianPudResult);
            this.unitsOfMass.Controls.Add(this.labelRussianPaundResult);
            this.unitsOfMass.Controls.Add(this.labelAmericanPaundResult);
            this.unitsOfMass.Controls.Add(this.labelRussianPud);
            this.unitsOfMass.Controls.Add(this.labelRussianPound);
            this.unitsOfMass.Controls.Add(this.labelAmericanPound);
            this.unitsOfMass.ForeColor = System.Drawing.Color.White;
            this.unitsOfMass.Location = new System.Drawing.Point(20, 63);
            this.unitsOfMass.Name = "unitsOfMass";
            this.unitsOfMass.Size = new System.Drawing.Size(200, 93);
            this.unitsOfMass.TabIndex = 4;
            this.unitsOfMass.TabStop = false;
            this.unitsOfMass.Text = "Convert kilograms to";
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
            this.btnConvert.Location = new System.Drawing.Point(20, 162);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
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
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(145, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.TextChanged += new System.EventHandler(this.textBoxKg_TextChanged);
            this.btnClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxKg
            // 
            this.textBoxKg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxKg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKg.ForeColor = System.Drawing.Color.White;
            this.textBoxKg.Location = new System.Drawing.Point(20, 37);
            this.textBoxKg.Name = "textBoxKg";
            this.textBoxKg.Size = new System.Drawing.Size(200, 20);
            this.textBoxKg.TabIndex = 0;
            this.textBoxKg.TextChanged += new System.EventHandler(this.textBoxKg_TextChanged);
            this.textBoxKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKg_KeyPress);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(20, 10);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(58, 17);
            this.labelHeader.TabIndex = 7;
            this.labelHeader.Text = "Weight";
            // 
            // FormWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(240, 205);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.unitsOfMass);
            this.Controls.Add(this.textBoxKg);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weight";
            this.unitsOfMass.ResumeLayout(false);
            this.unitsOfMass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAmericanPound;
        private System.Windows.Forms.Label labelRussianPound;
        private System.Windows.Forms.Label labelRussianPud;
        private System.Windows.Forms.GroupBox unitsOfMass;
        private System.Windows.Forms.Label labelAmericanPaundResult;
        private System.Windows.Forms.Label labelRussianPudResult;
        private System.Windows.Forms.Label labelRussianPaundResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textBoxKg;
        private System.Windows.Forms.Label labelHeader;
    }
}