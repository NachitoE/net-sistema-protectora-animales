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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.lb_HouseCapacity = new System.Windows.Forms.Label();
            this.lb_HouseAdressNumber = new System.Windows.Forms.Label();
            this.tb_HouseAdress = new System.Windows.Forms.TextBox();
            this.lb_HouseAdress = new System.Windows.Forms.Label();
            this.btn_AcceptnewHouse = new System.Windows.Forms.Button();
            this.nud_HouseCapacity = new System.Windows.Forms.NumericUpDown();
            this.tb_HouseAdressNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HouseCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 70);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(98, 73);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(347, 30);
            this.lb_MenuTitle.TabIndex = 51;
            this.lb_MenuTitle.Text = "Agregar datos de su propiedad";
            this.lb_MenuTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_HouseCapacity
            // 
            this.lb_HouseCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HouseCapacity.AutoSize = true;
            this.lb_HouseCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_HouseCapacity.Location = new System.Drawing.Point(12, 178);
            this.lb_HouseCapacity.Name = "lb_HouseCapacity";
            this.lb_HouseCapacity.Size = new System.Drawing.Size(237, 13);
            this.lb_HouseCapacity.TabIndex = 48;
            this.lb_HouseCapacity.Text = "Número máximo de animales que desee transitar:";
            this.lb_HouseCapacity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_HouseAdressNumber
            // 
            this.lb_HouseAdressNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HouseAdressNumber.AutoSize = true;
            this.lb_HouseAdressNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_HouseAdressNumber.Location = new System.Drawing.Point(12, 148);
            this.lb_HouseAdressNumber.Name = "lb_HouseAdressNumber";
            this.lb_HouseAdressNumber.Size = new System.Drawing.Size(87, 13);
            this.lb_HouseAdressNumber.TabIndex = 47;
            this.lb_HouseAdressNumber.Text = "Número de calle:";
            this.lb_HouseAdressNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_HouseAdress
            // 
            this.tb_HouseAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_HouseAdress.Location = new System.Drawing.Point(258, 119);
            this.tb_HouseAdress.MaxLength = 46;
            this.tb_HouseAdress.Name = "tb_HouseAdress";
            this.tb_HouseAdress.Size = new System.Drawing.Size(201, 20);
            this.tb_HouseAdress.TabIndex = 46;
            // 
            // lb_HouseAdress
            // 
            this.lb_HouseAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HouseAdress.AutoSize = true;
            this.lb_HouseAdress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_HouseAdress.Location = new System.Drawing.Point(12, 122);
            this.lb_HouseAdress.Name = "lb_HouseAdress";
            this.lb_HouseAdress.Size = new System.Drawing.Size(55, 13);
            this.lb_HouseAdress.TabIndex = 45;
            this.lb_HouseAdress.Text = "Dirección:";
            this.lb_HouseAdress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_AcceptnewHouse
            // 
            this.btn_AcceptnewHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AcceptnewHouse.Location = new System.Drawing.Point(447, 272);
            this.btn_AcceptnewHouse.Name = "btn_AcceptnewHouse";
            this.btn_AcceptnewHouse.Size = new System.Drawing.Size(115, 28);
            this.btn_AcceptnewHouse.TabIndex = 52;
            this.btn_AcceptnewHouse.Text = "Aceptar";
            this.btn_AcceptnewHouse.UseVisualStyleBackColor = true;
            this.btn_AcceptnewHouse.Click += new System.EventHandler(this.btn_AcceptnewHouse_Click);
            // 
            // nud_HouseCapacity
            // 
            this.nud_HouseCapacity.Location = new System.Drawing.Point(258, 171);
            this.nud_HouseCapacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_HouseCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_HouseCapacity.Name = "nud_HouseCapacity";
            this.nud_HouseCapacity.Size = new System.Drawing.Size(201, 20);
            this.nud_HouseCapacity.TabIndex = 53;
            this.nud_HouseCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_HouseAdressNumber
            // 
            this.tb_HouseAdressNumber.Location = new System.Drawing.Point(258, 146);
            this.tb_HouseAdressNumber.MaxLength = 4;
            this.tb_HouseAdressNumber.Name = "tb_HouseAdressNumber";
            this.tb_HouseAdressNumber.Size = new System.Drawing.Size(201, 20);
            this.tb_HouseAdressNumber.TabIndex = 54;
            // 
            // fm_HouseLoad
            // 
            this.AcceptButton = this.btn_AcceptnewHouse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 303);
            this.Controls.Add(this.tb_HouseAdressNumber);
            this.Controls.Add(this.nud_HouseCapacity);
            this.Controls.Add(this.btn_AcceptnewHouse);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.lb_HouseCapacity);
            this.Controls.Add(this.lb_HouseAdressNumber);
            this.Controls.Add(this.tb_HouseAdress);
            this.Controls.Add(this.lb_HouseAdress);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_HouseLoad";
            this.Text = "CARGAR CASA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HouseCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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