namespace WindowsForms.BasicForms
{
    partial class fm_SightingForm
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
            lb_Info = new Label();
            lb_HouseNumber = new Label();
            lb_HouseAddress = new Label();
            tb_SightingAddress = new TextBox();
            tb_SightingAddressNumber = new TextBox();
            pictureBox1 = new PictureBox();
            lb_SightingDescription = new Label();
            lb_SightingDateTime = new Label();
            tb_SightingDescription = new TextBox();
            btn_SubmitReport = new Button();
            mtb_SightingTime = new MaskedTextBox();
            lb_SightingInfo = new Label();
            btn_Help = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.BackColor = Color.OliveDrab;
            lb_Info.BorderStyle = BorderStyle.FixedSingle;
            lb_Info.ForeColor = Color.LightYellow;
            lb_Info.Location = new Point(143, 73);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(149, 17);
            lb_Info.TabIndex = 20;
            lb_Info.Text = "DATOS DEL AVISTAMIENTO";
            // 
            // lb_HouseNumber
            // 
            lb_HouseNumber.AutoSize = true;
            lb_HouseNumber.Location = new Point(12, 190);
            lb_HouseNumber.Name = "lb_HouseNumber";
            lb_HouseNumber.Size = new Size(42, 15);
            lb_HouseNumber.TabIndex = 19;
            lb_HouseNumber.Text = "Altura:";
            // 
            // lb_HouseAddress
            // 
            lb_HouseAddress.AutoSize = true;
            lb_HouseAddress.Location = new Point(12, 149);
            lb_HouseAddress.Name = "lb_HouseAddress";
            lb_HouseAddress.Size = new Size(36, 15);
            lb_HouseAddress.TabIndex = 18;
            lb_HouseAddress.Text = "Calle:";
            // 
            // tb_SightingAddress
            // 
            tb_SightingAddress.Location = new Point(108, 146);
            tb_SightingAddress.Name = "tb_SightingAddress";
            tb_SightingAddress.Size = new Size(227, 23);
            tb_SightingAddress.TabIndex = 17;
            // 
            // tb_SightingAddressNumber
            // 
            tb_SightingAddressNumber.Location = new Point(108, 187);
            tb_SightingAddressNumber.MaxLength = 6;
            tb_SightingAddressNumber.Name = "tb_SightingAddressNumber";
            tb_SightingAddressNumber.Size = new Size(228, 23);
            tb_SightingAddressNumber.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 70);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lb_SightingDescription
            // 
            lb_SightingDescription.AutoSize = true;
            lb_SightingDescription.Location = new Point(12, 272);
            lb_SightingDescription.Name = "lb_SightingDescription";
            lb_SightingDescription.Size = new Size(59, 15);
            lb_SightingDescription.TabIndex = 24;
            lb_SightingDescription.Text = "Situación:";
            // 
            // lb_SightingDateTime
            // 
            lb_SightingDateTime.AutoSize = true;
            lb_SightingDateTime.Location = new Point(12, 231);
            lb_SightingDateTime.Name = "lb_SightingDateTime";
            lb_SightingDateTime.Size = new Size(94, 30);
            lb_SightingDateTime.TabIndex = 23;
            lb_SightingDateTime.Text = "fecha y hora del \r\navistamiento:";
            // 
            // tb_SightingDescription
            // 
            tb_SightingDescription.Location = new Point(108, 269);
            tb_SightingDescription.MaxLength = 10000;
            tb_SightingDescription.Multiline = true;
            tb_SightingDescription.Name = "tb_SightingDescription";
            tb_SightingDescription.Size = new Size(228, 136);
            tb_SightingDescription.TabIndex = 21;
            // 
            // btn_SubmitReport
            // 
            btn_SubmitReport.Location = new Point(364, 413);
            btn_SubmitReport.Name = "btn_SubmitReport";
            btn_SubmitReport.Size = new Size(75, 23);
            btn_SubmitReport.TabIndex = 25;
            btn_SubmitReport.Text = "Aceptar";
            btn_SubmitReport.UseVisualStyleBackColor = true;
            btn_SubmitReport.Click += btn_SubmitReport_Click;
            // 
            // mtb_SightingTime
            // 
            mtb_SightingTime.BeepOnError = true;
            mtb_SightingTime.Location = new Point(108, 231);
            mtb_SightingTime.Mask = "00/00/0000 00:00";
            mtb_SightingTime.Name = "mtb_SightingTime";
            mtb_SightingTime.Size = new Size(228, 23);
            mtb_SightingTime.TabIndex = 26;
            mtb_SightingTime.ValidatingType = typeof(DateTime);
            // 
            // lb_SightingInfo
            // 
            lb_SightingInfo.AutoSize = true;
            lb_SightingInfo.Location = new Point(65, 99);
            lb_SightingInfo.Name = "lb_SightingInfo";
            lb_SightingInfo.Size = new Size(298, 30);
            lb_SightingInfo.TabIndex = 27;
            lb_SightingInfo.Text = "Gracias por su preocupación. Necesitamos que nos \r\nproporcione los siguientes datos para tomar su reporte:\r\n";
            // 
            // btn_Help
            // 
            btn_Help.BackColor = SystemColors.ActiveCaption;
            btn_Help.Cursor = Cursors.Help;
            btn_Help.FlatStyle = FlatStyle.Popup;
            btn_Help.Location = new Point(77, 269);
            btn_Help.Name = "btn_Help";
            btn_Help.Size = new Size(25, 26);
            btn_Help.TabIndex = 28;
            btn_Help.Text = "?";
            btn_Help.UseVisualStyleBackColor = false;
            btn_Help.Click += btn_Help_Click;
            // 
            // fm_SightingForm
            // 
            AcceptButton = btn_SubmitReport;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 448);
            Controls.Add(btn_Help);
            Controls.Add(lb_SightingInfo);
            Controls.Add(mtb_SightingTime);
            Controls.Add(btn_SubmitReport);
            Controls.Add(lb_SightingDescription);
            Controls.Add(lb_SightingDateTime);
            Controls.Add(tb_SightingDescription);
            Controls.Add(lb_Info);
            Controls.Add(lb_HouseNumber);
            Controls.Add(lb_HouseAddress);
            Controls.Add(tb_SightingAddress);
            Controls.Add(tb_SightingAddressNumber);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "fm_SightingForm";
            Text = "SightingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Info;
        private Label lb_HouseNumber;
        private Label lb_HouseAddress;
        private TextBox tb_SightingAddress;
        private TextBox tb_SightingAddressNumber;
        private PictureBox pictureBox1;
        private Label lb_SightingDescription;
        private Label lb_SightingDateTime;
        private TextBox tb_SightingDescription;
        private Button btn_SubmitReport;
        private MaskedTextBox mtb_SightingTime;
        private Label lb_SightingInfo;
        private Button btn_Help;
    }
}