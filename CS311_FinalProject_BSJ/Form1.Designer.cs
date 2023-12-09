namespace CS311_FinalProject_BSJ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLeft = new TextBox();
            txtRight = new TextBox();
            lblLeft = new Label();
            lblRight = new Label();
            lblConversion = new Label();
            lblConvEqn = new Label();
            cmbFormat = new ComboBox();
            lblSigFigs = new Label();
            pnlConvSelect = new Panel();
            rdoKgLb = new RadioButton();
            rdoKmMiles = new RadioButton();
            rdoCF = new RadioButton();
            rdoGOz = new RadioButton();
            rdoMFt = new RadioButton();
            btnHelp = new Button();
            lblEquals = new Label();
            chkLR = new CheckBox();
            pnlConvSelect.SuspendLayout();
            SuspendLayout();
            // 
            // txtLeft
            // 
            txtLeft.Location = new Point(65, 131);
            txtLeft.Name = "txtLeft";
            txtLeft.Size = new Size(259, 23);
            txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            txtRight.Location = new Point(468, 131);
            txtRight.Name = "txtRight";
            txtRight.Size = new Size(259, 23);
            txtRight.TabIndex = 1;
            // 
            // lblLeft
            // 
            lblLeft.AutoSize = true;
            lblLeft.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLeft.Location = new Point(65, 69);
            lblLeft.Name = "lblLeft";
            lblLeft.Size = new Size(135, 47);
            lblLeft.TabIndex = 2;
            lblLeft.Text = "Meters";
            // 
            // lblRight
            // 
            lblRight.AutoSize = true;
            lblRight.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRight.Location = new Point(468, 69);
            lblRight.Name = "lblRight";
            lblRight.Size = new Size(90, 47);
            lblRight.TabIndex = 3;
            lblRight.Text = "Feet";
            // 
            // lblConversion
            // 
            lblConversion.AutoSize = true;
            lblConversion.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConversion.Location = new Point(65, 205);
            lblConversion.Name = "lblConversion";
            lblConversion.Size = new Size(162, 37);
            lblConversion.TabIndex = 4;
            lblConversion.Text = "Conversion:";
            // 
            // lblConvEqn
            // 
            lblConvEqn.AutoSize = true;
            lblConvEqn.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblConvEqn.Location = new Point(65, 252);
            lblConvEqn.Name = "lblConvEqn";
            lblConvEqn.Size = new Size(104, 25);
            lblConvEqn.TabIndex = 5;
            lblConvEqn.Text = "lblConvEqn";
            // 
            // cmbFormat
            // 
            cmbFormat.DisplayMember = "(none)";
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5" });
            cmbFormat.Location = new Point(468, 252);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(121, 23);
            cmbFormat.TabIndex = 6;
            // 
            // lblSigFigs
            // 
            lblSigFigs.AutoSize = true;
            lblSigFigs.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSigFigs.Location = new Point(468, 205);
            lblSigFigs.Name = "lblSigFigs";
            lblSigFigs.Size = new Size(198, 37);
            lblSigFigs.TabIndex = 7;
            lblSigFigs.Text = "Decimal Places";
            // 
            // pnlConvSelect
            // 
            pnlConvSelect.Controls.Add(rdoKgLb);
            pnlConvSelect.Controls.Add(rdoKmMiles);
            pnlConvSelect.Controls.Add(rdoCF);
            pnlConvSelect.Controls.Add(rdoGOz);
            pnlConvSelect.Controls.Add(rdoMFt);
            pnlConvSelect.Location = new Point(65, 310);
            pnlConvSelect.Name = "pnlConvSelect";
            pnlConvSelect.Size = new Size(662, 116);
            pnlConvSelect.TabIndex = 8;
            // 
            // rdoKgLb
            // 
            rdoKgLb.AutoSize = true;
            rdoKgLb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoKgLb.Location = new Point(382, 70);
            rdoKgLb.Name = "rdoKgLb";
            rdoKgLb.Size = new Size(161, 25);
            rdoKgLb.TabIndex = 3;
            rdoKgLb.TabStop = true;
            rdoKgLb.Text = "Kilograms/Pounds";
            rdoKgLb.UseVisualStyleBackColor = true;
            // 
            // rdoKmMiles
            // 
            rdoKmMiles.AutoSize = true;
            rdoKmMiles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoKmMiles.Location = new Point(133, 70);
            rdoKmMiles.Name = "rdoKmMiles";
            rdoKmMiles.Size = new Size(153, 25);
            rdoKmMiles.TabIndex = 1;
            rdoKmMiles.TabStop = true;
            rdoKmMiles.Text = "Kilometers/Miles";
            rdoKmMiles.UseVisualStyleBackColor = true;
            // 
            // rdoCF
            // 
            rdoCF.AutoSize = true;
            rdoCF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoCF.Location = new Point(256, 20);
            rdoCF.Name = "rdoCF";
            rdoCF.Size = new Size(152, 25);
            rdoCF.TabIndex = 2;
            rdoCF.TabStop = true;
            rdoCF.Text = "Celsius/Farenheit";
            rdoCF.UseVisualStyleBackColor = true;
            // 
            // rdoGOz
            // 
            rdoGOz.AutoSize = true;
            rdoGOz.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoGOz.Location = new Point(508, 20);
            rdoGOz.Name = "rdoGOz";
            rdoGOz.Size = new Size(135, 25);
            rdoGOz.TabIndex = 4;
            rdoGOz.TabStop = true;
            rdoGOz.Text = "Grams/Ounces";
            rdoGOz.UseVisualStyleBackColor = true;
            // 
            // rdoMFt
            // 
            rdoMFt.AutoSize = true;
            rdoMFt.Checked = true;
            rdoMFt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdoMFt.Location = new Point(34, 20);
            rdoMFt.Name = "rdoMFt";
            rdoMFt.Size = new Size(128, 25);
            rdoMFt.TabIndex = 0;
            rdoMFt.TabStop = true;
            rdoMFt.Text = "Meeters/Feet";
            rdoMFt.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHelp.Location = new Point(71, 26);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(114, 40);
            btnHelp.TabIndex = 9;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquals.Location = new Point(373, 115);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(45, 47);
            lblEquals.TabIndex = 10;
            lblEquals.Text = "=";
            // 
            // chkLR
            // 
            chkLR.AutoSize = true;
            chkLR.Checked = true;
            chkLR.CheckState = CheckState.Checked;
            chkLR.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkLR.Location = new Point(65, 174);
            chkLR.Name = "chkLR";
            chkLR.Size = new Size(272, 21);
            chkLR.TabIndex = 11;
            chkLR.Text = "Conversion Equation uses Left Measure?";
            chkLR.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkLR);
            Controls.Add(lblEquals);
            Controls.Add(btnHelp);
            Controls.Add(pnlConvSelect);
            Controls.Add(lblSigFigs);
            Controls.Add(cmbFormat);
            Controls.Add(lblConvEqn);
            Controls.Add(lblConversion);
            Controls.Add(lblRight);
            Controls.Add(lblLeft);
            Controls.Add(txtRight);
            Controls.Add(txtLeft);
            Name = "Form1";
            Text = "Unit Converter";
            pnlConvSelect.ResumeLayout(false);
            pnlConvSelect.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLeft;
        private TextBox txtRight;
        private Label lblLeft;
        private Label lblRight;
        private Label lblConversion;
        private Label lblConvEqn;
        private ComboBox cmbFormat;
        private Label lblSigFigs;
        private Panel pnlConvSelect;
        private RadioButton rdoKgLb;
        private RadioButton rdoKmMiles;
        private RadioButton rdoCF;
        private RadioButton rdoGOz;
        private RadioButton rdoMFt;
        private Button btnHelp;
        private Label lblEquals;
        private CheckBox chkLR;
    }
}