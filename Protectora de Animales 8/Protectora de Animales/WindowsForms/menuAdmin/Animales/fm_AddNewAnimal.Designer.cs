namespace WindowsFormsApp1.menuAdmin.Animales
{
    partial class fm_AddNewAnimal
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
            this.cb_AnimalSpc = new System.Windows.Forms.ComboBox();
            this.lb_AnimalBirthDate = new System.Windows.Forms.Label();
            this.lb_AnimalSpc = new System.Windows.Forms.Label();
            this.tb_AnimalName = new System.Windows.Forms.TextBox();
            this.lb_AnimalName = new System.Windows.Forms.Label();
            this.mtb_AnimalBd = new System.Windows.Forms.MaskedTextBox();
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.btn_AcceptnewAnimal = new System.Windows.Forms.Button();
            this.tb_AnimalDescription = new System.Windows.Forms.TextBox();
            this.lb_AnimalDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = WindowsForms.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(574, 70);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cb_AnimalSpc
            // 
            this.cb_AnimalSpc.AllowDrop = true;
            this.cb_AnimalSpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_AnimalSpc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AnimalSpc.FormattingEnabled = true;
            this.cb_AnimalSpc.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Conejo",
            "Pajaro"});
            this.cb_AnimalSpc.Location = new System.Drawing.Point(149, 146);
            this.cb_AnimalSpc.Name = "cb_AnimalSpc";
            this.cb_AnimalSpc.Size = new System.Drawing.Size(201, 21);
            this.cb_AnimalSpc.TabIndex = 33;
            // 
            // lb_AnimalBirthDate
            // 
            this.lb_AnimalBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AnimalBirthDate.AutoSize = true;
            this.lb_AnimalBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_AnimalBirthDate.Location = new System.Drawing.Point(15, 179);
            this.lb_AnimalBirthDate.Name = "lb_AnimalBirthDate";
            this.lb_AnimalBirthDate.Size = new System.Drawing.Size(109, 13);
            this.lb_AnimalBirthDate.TabIndex = 24;
            this.lb_AnimalBirthDate.Text = "Fecha de nacimiento:";
            this.lb_AnimalBirthDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_AnimalSpc
            // 
            this.lb_AnimalSpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AnimalSpc.AutoSize = true;
            this.lb_AnimalSpc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_AnimalSpc.Location = new System.Drawing.Point(15, 149);
            this.lb_AnimalSpc.Name = "lb_AnimalSpc";
            this.lb_AnimalSpc.Size = new System.Drawing.Size(45, 13);
            this.lb_AnimalSpc.TabIndex = 22;
            this.lb_AnimalSpc.Text = "Especie";
            this.lb_AnimalSpc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_AnimalName
            // 
            this.tb_AnimalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_AnimalName.Location = new System.Drawing.Point(149, 120);
            this.tb_AnimalName.Name = "tb_AnimalName";
            this.tb_AnimalName.Size = new System.Drawing.Size(201, 20);
            this.tb_AnimalName.TabIndex = 21;
            // 
            // lb_AnimalName
            // 
            this.lb_AnimalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AnimalName.AutoSize = true;
            this.lb_AnimalName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_AnimalName.Location = new System.Drawing.Point(15, 123);
            this.lb_AnimalName.Name = "lb_AnimalName";
            this.lb_AnimalName.Size = new System.Drawing.Size(47, 13);
            this.lb_AnimalName.TabIndex = 20;
            this.lb_AnimalName.Text = "Nombre:";
            this.lb_AnimalName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mtb_AnimalBd
            // 
            this.mtb_AnimalBd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtb_AnimalBd.Location = new System.Drawing.Point(149, 176);
            this.mtb_AnimalBd.Mask = "00/00/0000";
            this.mtb_AnimalBd.Name = "mtb_AnimalBd";
            this.mtb_AnimalBd.Size = new System.Drawing.Size(201, 20);
            this.mtb_AnimalBd.TabIndex = 35;
            this.mtb_AnimalBd.ValidatingType = typeof(System.DateTime);
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(131, 74);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(255, 30);
            this.lb_MenuTitle.TabIndex = 36;
            this.lb_MenuTitle.Text = "Agregar nuevo animal";
            // 
            // btn_AcceptnewAnimal
            // 
            this.btn_AcceptnewAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AcceptnewAnimal.Location = new System.Drawing.Point(457, 269);
            this.btn_AcceptnewAnimal.Name = "btn_AcceptnewAnimal";
            this.btn_AcceptnewAnimal.Size = new System.Drawing.Size(115, 28);
            this.btn_AcceptnewAnimal.TabIndex = 37;
            this.btn_AcceptnewAnimal.Text = "Aceptar";
            this.btn_AcceptnewAnimal.UseVisualStyleBackColor = true;
            this.btn_AcceptnewAnimal.Click += new System.EventHandler(this.btn_AcceptnewAnimal_Click);
            // 
            // tb_AnimalDescription
            // 
            this.tb_AnimalDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_AnimalDescription.Location = new System.Drawing.Point(149, 202);
            this.tb_AnimalDescription.Name = "tb_AnimalDescription";
            this.tb_AnimalDescription.Size = new System.Drawing.Size(201, 20);
            this.tb_AnimalDescription.TabIndex = 39;
            // 
            // lb_AnimalDescription
            // 
            this.lb_AnimalDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AnimalDescription.AutoSize = true;
            this.lb_AnimalDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb_AnimalDescription.Location = new System.Drawing.Point(15, 205);
            this.lb_AnimalDescription.Name = "lb_AnimalDescription";
            this.lb_AnimalDescription.Size = new System.Drawing.Size(116, 13);
            this.lb_AnimalDescription.TabIndex = 38;
            this.lb_AnimalDescription.Text = "Descripción del animal:";
            this.lb_AnimalDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fm_AddNewAnimal
            // 
            this.AcceptButton = this.btn_AcceptnewAnimal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(574, 303);
            this.Controls.Add(this.tb_AnimalDescription);
            this.Controls.Add(this.lb_AnimalDescription);
            this.Controls.Add(this.btn_AcceptnewAnimal);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.mtb_AnimalBd);
            this.Controls.Add(this.cb_AnimalSpc);
            this.Controls.Add(this.lb_AnimalBirthDate);
            this.Controls.Add(this.lb_AnimalSpc);
            this.Controls.Add(this.tb_AnimalName);
            this.Controls.Add(this.lb_AnimalName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fm_AddNewAnimal";
            this.Text = "Añadir Animal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_AnimalSpc;
        private System.Windows.Forms.Label lb_AnimalBirthDate;
        private System.Windows.Forms.Label lb_AnimalSpc;
        private System.Windows.Forms.TextBox tb_AnimalName;
        private System.Windows.Forms.Label lb_AnimalName;
        private System.Windows.Forms.MaskedTextBox mtb_AnimalBd;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        private System.Windows.Forms.Button btn_AcceptnewAnimal;
        private System.Windows.Forms.TextBox tb_AnimalDescription;
        private System.Windows.Forms.Label lb_AnimalDescription;
    }
}