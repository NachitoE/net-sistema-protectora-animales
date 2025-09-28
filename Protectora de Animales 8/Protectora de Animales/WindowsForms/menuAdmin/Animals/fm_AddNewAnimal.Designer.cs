namespace WindowsForms.menuAdmin.Animals
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
            pictureBox1 = new PictureBox();
            cb_AnimalSpc = new ComboBox();
            lb_AnimalBirthDate = new Label();
            lb_AnimalSpc = new Label();
            tb_AnimalName = new TextBox();
            lb_AnimalName = new Label();
            mtb_AnimalBd = new MaskedTextBox();
            lb_MenuTitle = new Label();
            btn_AcceptnewAnimal = new Button();
            tb_AnimalDescription = new TextBox();
            lb_AnimalDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(670, 81);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // cb_AnimalSpc
            // 
            cb_AnimalSpc.AllowDrop = true;
            cb_AnimalSpc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_AnimalSpc.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_AnimalSpc.FormattingEnabled = true;
            cb_AnimalSpc.Items.AddRange(new object[] { "Perro", "Gato", "Conejo", "Pajaro" });
            cb_AnimalSpc.Location = new Point(174, 168);
            cb_AnimalSpc.Margin = new Padding(4, 3, 4, 3);
            cb_AnimalSpc.Name = "cb_AnimalSpc";
            cb_AnimalSpc.Size = new Size(234, 23);
            cb_AnimalSpc.TabIndex = 33;
            // 
            // lb_AnimalBirthDate
            // 
            lb_AnimalBirthDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_AnimalBirthDate.AutoSize = true;
            lb_AnimalBirthDate.FlatStyle = FlatStyle.Popup;
            lb_AnimalBirthDate.Location = new Point(18, 207);
            lb_AnimalBirthDate.Margin = new Padding(4, 0, 4, 0);
            lb_AnimalBirthDate.Name = "lb_AnimalBirthDate";
            lb_AnimalBirthDate.Size = new Size(120, 15);
            lb_AnimalBirthDate.TabIndex = 24;
            lb_AnimalBirthDate.Text = "Fecha de nacimiento:";
            lb_AnimalBirthDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_AnimalSpc
            // 
            lb_AnimalSpc.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_AnimalSpc.AutoSize = true;
            lb_AnimalSpc.FlatStyle = FlatStyle.Popup;
            lb_AnimalSpc.Location = new Point(18, 172);
            lb_AnimalSpc.Margin = new Padding(4, 0, 4, 0);
            lb_AnimalSpc.Name = "lb_AnimalSpc";
            lb_AnimalSpc.Size = new Size(46, 15);
            lb_AnimalSpc.TabIndex = 22;
            lb_AnimalSpc.Text = "Especie";
            lb_AnimalSpc.TextAlign = ContentAlignment.TopCenter;
            // 
            // tb_AnimalName
            // 
            tb_AnimalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_AnimalName.Location = new Point(174, 138);
            tb_AnimalName.Margin = new Padding(4, 3, 4, 3);
            tb_AnimalName.Name = "tb_AnimalName";
            tb_AnimalName.Size = new Size(234, 23);
            tb_AnimalName.TabIndex = 21;
            // 
            // lb_AnimalName
            // 
            lb_AnimalName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_AnimalName.AutoSize = true;
            lb_AnimalName.FlatStyle = FlatStyle.Popup;
            lb_AnimalName.Location = new Point(18, 142);
            lb_AnimalName.Margin = new Padding(4, 0, 4, 0);
            lb_AnimalName.Name = "lb_AnimalName";
            lb_AnimalName.Size = new Size(54, 15);
            lb_AnimalName.TabIndex = 20;
            lb_AnimalName.Text = "Nombre:";
            lb_AnimalName.TextAlign = ContentAlignment.TopCenter;
            // 
            // mtb_AnimalBd
            // 
            mtb_AnimalBd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mtb_AnimalBd.Location = new Point(174, 203);
            mtb_AnimalBd.Margin = new Padding(4, 3, 4, 3);
            mtb_AnimalBd.Mask = "00/00/0000";
            mtb_AnimalBd.Name = "mtb_AnimalBd";
            mtb_AnimalBd.Size = new Size(234, 23);
            mtb_AnimalBd.TabIndex = 35;
            mtb_AnimalBd.ValidatingType = typeof(DateTime);
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(153, 85);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(298, 35);
            lb_MenuTitle.TabIndex = 36;
            lb_MenuTitle.Text = "Agregar nuevo animal";
            // 
            // btn_AcceptnewAnimal
            // 
            btn_AcceptnewAnimal.Anchor = AnchorStyles.None;
            btn_AcceptnewAnimal.Location = new Point(533, 310);
            btn_AcceptnewAnimal.Margin = new Padding(4, 3, 4, 3);
            btn_AcceptnewAnimal.Name = "btn_AcceptnewAnimal";
            btn_AcceptnewAnimal.Size = new Size(134, 32);
            btn_AcceptnewAnimal.TabIndex = 37;
            btn_AcceptnewAnimal.Text = "Aceptar";
            btn_AcceptnewAnimal.UseVisualStyleBackColor = true;
            btn_AcceptnewAnimal.Click += btn_AcceptnewAnimal_Click;
            // 
            // tb_AnimalDescription
            // 
            tb_AnimalDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_AnimalDescription.Location = new Point(174, 233);
            tb_AnimalDescription.Margin = new Padding(4, 3, 4, 3);
            tb_AnimalDescription.Name = "tb_AnimalDescription";
            tb_AnimalDescription.Size = new Size(234, 23);
            tb_AnimalDescription.TabIndex = 39;
            // 
            // lb_AnimalDescription
            // 
            lb_AnimalDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_AnimalDescription.AutoSize = true;
            lb_AnimalDescription.FlatStyle = FlatStyle.Popup;
            lb_AnimalDescription.Location = new Point(18, 237);
            lb_AnimalDescription.Margin = new Padding(4, 0, 4, 0);
            lb_AnimalDescription.Name = "lb_AnimalDescription";
            lb_AnimalDescription.Size = new Size(130, 15);
            lb_AnimalDescription.TabIndex = 38;
            lb_AnimalDescription.Text = "Descripción del animal:";
            lb_AnimalDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // fm_AddNewAnimal
            // 
            AcceptButton = btn_AcceptnewAnimal;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(670, 350);
            Controls.Add(tb_AnimalDescription);
            Controls.Add(lb_AnimalDescription);
            Controls.Add(btn_AcceptnewAnimal);
            Controls.Add(lb_MenuTitle);
            Controls.Add(mtb_AnimalBd);
            Controls.Add(cb_AnimalSpc);
            Controls.Add(lb_AnimalBirthDate);
            Controls.Add(lb_AnimalSpc);
            Controls.Add(tb_AnimalName);
            Controls.Add(lb_AnimalName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AddNewAnimal";
            Text = "Añadir Animal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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