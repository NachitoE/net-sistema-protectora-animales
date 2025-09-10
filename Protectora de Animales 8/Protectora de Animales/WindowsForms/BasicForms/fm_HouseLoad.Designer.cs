namespace WindowsFormsApp1.BasicForms
{
    partial class fm_HouseLoad
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
            pictureBox1 = new PictureBox();
            lb_MenuTitle = new Label();
            lb_HouseCapacity = new Label();
            lb_HouseAdressNumber = new Label();
            tb_HouseAdress = new TextBox();
            lb_HouseAdress = new Label();
            btn_AcceptnewHouse = new Button();
            nud_HouseCapacity = new NumericUpDown();
            tb_HouseAdressNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_HouseCapacity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 81);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(114, 84);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(405, 35);
            lb_MenuTitle.TabIndex = 51;
            lb_MenuTitle.Text = "Agregar datos de su propiedad";
            lb_MenuTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_HouseCapacity
            // 
            lb_HouseCapacity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_HouseCapacity.AutoSize = true;
            lb_HouseCapacity.FlatStyle = FlatStyle.Popup;
            lb_HouseCapacity.Location = new Point(14, 205);
            lb_HouseCapacity.Margin = new Padding(4, 0, 4, 0);
            lb_HouseCapacity.Name = "lb_HouseCapacity";
            lb_HouseCapacity.Size = new Size(268, 15);
            lb_HouseCapacity.TabIndex = 48;
            lb_HouseCapacity.Text = "Número máximo de animales que desee transitar:";
            lb_HouseCapacity.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_HouseAdressNumber
            // 
            lb_HouseAdressNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_HouseAdressNumber.AutoSize = true;
            lb_HouseAdressNumber.FlatStyle = FlatStyle.Popup;
            lb_HouseAdressNumber.Location = new Point(14, 171);
            lb_HouseAdressNumber.Margin = new Padding(4, 0, 4, 0);
            lb_HouseAdressNumber.Name = "lb_HouseAdressNumber";
            lb_HouseAdressNumber.Size = new Size(97, 15);
            lb_HouseAdressNumber.TabIndex = 47;
            lb_HouseAdressNumber.Text = "Número de calle:";
            lb_HouseAdressNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_HouseAdress
            // 
            tb_HouseAdress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_HouseAdress.Location = new Point(301, 137);
            tb_HouseAdress.Margin = new Padding(4, 3, 4, 3);
            tb_HouseAdress.MaxLength = 46;
            tb_HouseAdress.Name = "tb_HouseAdress";
            tb_HouseAdress.Size = new Size(234, 23);
            tb_HouseAdress.TabIndex = 46;
            // 
            // lb_HouseAdress
            // 
            lb_HouseAdress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_HouseAdress.AutoSize = true;
            lb_HouseAdress.FlatStyle = FlatStyle.Popup;
            lb_HouseAdress.Location = new Point(14, 141);
            lb_HouseAdress.Margin = new Padding(4, 0, 4, 0);
            lb_HouseAdress.Name = "lb_HouseAdress";
            lb_HouseAdress.Size = new Size(60, 15);
            lb_HouseAdress.TabIndex = 45;
            lb_HouseAdress.Text = "Dirección:";
            lb_HouseAdress.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_AcceptnewHouse
            // 
            btn_AcceptnewHouse.Anchor = AnchorStyles.None;
            btn_AcceptnewHouse.Location = new Point(522, 314);
            btn_AcceptnewHouse.Margin = new Padding(4, 3, 4, 3);
            btn_AcceptnewHouse.Name = "btn_AcceptnewHouse";
            btn_AcceptnewHouse.Size = new Size(134, 32);
            btn_AcceptnewHouse.TabIndex = 52;
            btn_AcceptnewHouse.Text = "Aceptar";
            btn_AcceptnewHouse.UseVisualStyleBackColor = true;
            btn_AcceptnewHouse.Click += btn_AcceptnewHouse_Click;
            // 
            // nud_HouseCapacity
            // 
            nud_HouseCapacity.Location = new Point(301, 197);
            nud_HouseCapacity.Margin = new Padding(4, 3, 4, 3);
            nud_HouseCapacity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nud_HouseCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_HouseCapacity.Name = "nud_HouseCapacity";
            nud_HouseCapacity.Size = new Size(234, 23);
            nud_HouseCapacity.TabIndex = 53;
            nud_HouseCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tb_HouseAdressNumber
            // 
            tb_HouseAdressNumber.Location = new Point(301, 168);
            tb_HouseAdressNumber.Margin = new Padding(4, 3, 4, 3);
            tb_HouseAdressNumber.MaxLength = 4;
            tb_HouseAdressNumber.Name = "tb_HouseAdressNumber";
            tb_HouseAdressNumber.Size = new Size(234, 23);
            tb_HouseAdressNumber.TabIndex = 54;
            // 
            // fm_HouseLoad
            // 
            AcceptButton = btn_AcceptnewHouse;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 350);
            Controls.Add(tb_HouseAdressNumber);
            Controls.Add(nud_HouseCapacity);
            Controls.Add(btn_AcceptnewHouse);
            Controls.Add(lb_MenuTitle);
            Controls.Add(lb_HouseCapacity);
            Controls.Add(lb_HouseAdressNumber);
            Controls.Add(tb_HouseAdress);
            Controls.Add(lb_HouseAdress);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_HouseLoad";
            Text = "CARGAR CASA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_HouseCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.Label lb_HouseCapacity;
        private System.Windows.Forms.Label lb_HouseAdressNumber;
        private System.Windows.Forms.TextBox tb_HouseAdress;
        private System.Windows.Forms.Label lb_HouseAdress;
        private System.Windows.Forms.Button btn_AcceptnewHouse;
        private System.Windows.Forms.NumericUpDown nud_HouseCapacity;
        private System.Windows.Forms.TextBox tb_HouseAdressNumber;
    }
}