namespace WindowsForms.menuAdopter
{
    partial class fm_NewAdoptionRequest
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
            tb_AnimalName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lb_AnimalInput = new Label();
            tb_AdoptionMotive = new TextBox();
            cbb_AnimalSpecie = new ComboBox();
            lb_AnimalSpecie = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            llb_ShowAnimals = new LinkLabel();
            lb_AdoptionMotive = new Label();
            btn_AcceptAdoption = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tb_AnimalName
            // 
            tb_AnimalName.Location = new Point(106, 142);
            tb_AnimalName.Name = "tb_AnimalName";
            tb_AnimalName.Size = new Size(262, 23);
            tb_AnimalName.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(928, 82);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(145, 33);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 2;
            label1.Text = "Adoptar un animal";
            // 
            // lb_AnimalInput
            // 
            lb_AnimalInput.AutoSize = true;
            lb_AnimalInput.BackColor = Color.OliveDrab;
            lb_AnimalInput.ForeColor = SystemColors.ButtonHighlight;
            lb_AnimalInput.Location = new Point(106, 109);
            lb_AnimalInput.Name = "lb_AnimalInput";
            lb_AnimalInput.Size = new Size(262, 15);
            lb_AnimalInput.TabIndex = 3;
            lb_AnimalInput.Text = "Ingrese el nombre del animal que desea Adoptar";
            // 
            // tb_AdoptionMotive
            // 
            tb_AdoptionMotive.Location = new Point(82, 331);
            tb_AdoptionMotive.Multiline = true;
            tb_AdoptionMotive.Name = "tb_AdoptionMotive";
            tb_AdoptionMotive.Size = new Size(315, 144);
            tb_AdoptionMotive.TabIndex = 4;
            // 
            // cbb_AnimalSpecie
            // 
            cbb_AnimalSpecie.FormattingEnabled = true;
            cbb_AnimalSpecie.Items.AddRange(new object[] { "Perro", "Gato", "Conejo", "Pajaro" });
            cbb_AnimalSpecie.Location = new Point(106, 214);
            cbb_AnimalSpecie.Name = "cbb_AnimalSpecie";
            cbb_AnimalSpecie.Size = new Size(262, 23);
            cbb_AnimalSpecie.TabIndex = 5;
            // 
            // lb_AnimalSpecie
            // 
            lb_AnimalSpecie.AutoSize = true;
            lb_AnimalSpecie.BackColor = Color.OliveDrab;
            lb_AnimalSpecie.ForeColor = Color.LightGoldenrodYellow;
            lb_AnimalSpecie.Location = new Point(106, 187);
            lb_AnimalSpecie.Name = "lb_AnimalSpecie";
            lb_AnimalSpecie.Size = new Size(259, 15);
            lb_AnimalSpecie.TabIndex = 6;
            lb_AnimalSpecie.Text = "Ingrese la especie del animal que desea Adoptar";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OliveDrab;
            pictureBox2.Location = new Point(73, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(334, 395);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.OliveDrab;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(106, 256);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 8;
            label2.Text = "No recuerda su nombre? ";
            // 
            // llb_ShowAnimals
            // 
            llb_ShowAnimals.AutoSize = true;
            llb_ShowAnimals.BackColor = Color.OliveDrab;
            llb_ShowAnimals.LinkColor = Color.White;
            llb_ShowAnimals.Location = new Point(257, 256);
            llb_ShowAnimals.Name = "llb_ShowAnimals";
            llb_ShowAnimals.Size = new Size(95, 15);
            llb_ShowAnimals.TabIndex = 9;
            llb_ShowAnimals.TabStop = true;
            llb_ShowAnimals.Text = "Haga Click Aquí!";
            llb_ShowAnimals.LinkClicked += llb_ShowAnimals_LinkClicked;
            // 
            // lb_AdoptionMotive
            // 
            lb_AdoptionMotive.AutoSize = true;
            lb_AdoptionMotive.BackColor = Color.OliveDrab;
            lb_AdoptionMotive.ForeColor = SystemColors.ButtonHighlight;
            lb_AdoptionMotive.Location = new Point(82, 303);
            lb_AdoptionMotive.Name = "lb_AdoptionMotive";
            lb_AdoptionMotive.Size = new Size(117, 15);
            lb_AdoptionMotive.TabIndex = 10;
            lb_AdoptionMotive.Text = "Motivo de adopción:";
            // 
            // btn_AcceptAdoption
            // 
            btn_AcceptAdoption.Location = new Point(403, 504);
            btn_AcceptAdoption.Name = "btn_AcceptAdoption";
            btn_AcceptAdoption.Size = new Size(75, 23);
            btn_AcceptAdoption.TabIndex = 11;
            btn_AcceptAdoption.Text = "Aceptar";
            btn_AcceptAdoption.UseVisualStyleBackColor = true;
            btn_AcceptAdoption.Click += btn_AcceptAdoption_Click;
            // 
            // fm_NewAdoptionRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 539);
            Controls.Add(btn_AcceptAdoption);
            Controls.Add(lb_AdoptionMotive);
            Controls.Add(llb_ShowAnimals);
            Controls.Add(label2);
            Controls.Add(lb_AnimalSpecie);
            Controls.Add(cbb_AnimalSpecie);
            Controls.Add(tb_AdoptionMotive);
            Controls.Add(lb_AnimalInput);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(tb_AnimalName);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_NewAdoptionRequest";
            Text = "fm_NewAdoptionRequest";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_AnimalName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lb_AnimalInput;
        private TextBox tb_AdoptionMotive;
        private ComboBox cbb_AnimalSpecie;
        private Label lb_AnimalSpecie;
        private PictureBox pictureBox2;
        private Label label2;
        private LinkLabel llb_ShowAnimals;
        private Label lb_AdoptionMotive;
        private Button btn_AcceptAdoption;
    }
}