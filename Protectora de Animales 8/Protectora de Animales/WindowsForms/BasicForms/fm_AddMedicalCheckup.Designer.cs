namespace WindowsForms.BasicForms
{
    partial class fm_AddMedicalCheckup
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
            pb_headerpic = new PictureBox();
            lb_MedicalCheckup = new Label();
            lb_animalName = new Label();
            lb_MCFeedBack = new Label();
            lb_AnimalSpecie = new Label();
            cbb_AnimalSpecie = new ComboBox();
            tb_MCFeedback = new TextBox();
            tb_AnimalName = new TextBox();
            pictureBox2 = new PictureBox();
            lb_CheckupDate = new Label();
            dtp_CheckupDate = new DateTimePicker();
            btn_AcceptMC = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pb_headerpic
            // 
            pb_headerpic.Dock = DockStyle.Top;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(0, 0);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(522, 76);
            pb_headerpic.TabIndex = 9;
            pb_headerpic.TabStop = false;
            // 
            // lb_MedicalCheckup
            // 
            lb_MedicalCheckup.AutoSize = true;
            lb_MedicalCheckup.BackColor = Color.OliveDrab;
            lb_MedicalCheckup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MedicalCheckup.ForeColor = SystemColors.ButtonFace;
            lb_MedicalCheckup.Location = new Point(127, 25);
            lb_MedicalCheckup.Name = "lb_MedicalCheckup";
            lb_MedicalCheckup.Size = new Size(239, 30);
            lb_MedicalCheckup.TabIndex = 10;
            lb_MedicalCheckup.Text = "Registrar control médico";
            // 
            // lb_animalName
            // 
            lb_animalName.AutoSize = true;
            lb_animalName.BackColor = Color.OliveDrab;
            lb_animalName.ForeColor = SystemColors.Control;
            lb_animalName.Location = new Point(109, 147);
            lb_animalName.Name = "lb_animalName";
            lb_animalName.Size = new Size(175, 15);
            lb_animalName.TabIndex = 11;
            lb_animalName.Text = "Ingrese el nombre de su animal:";
            // 
            // lb_MCFeedBack
            // 
            lb_MCFeedBack.AutoSize = true;
            lb_MCFeedBack.BackColor = Color.OliveDrab;
            lb_MCFeedBack.ForeColor = SystemColors.ButtonHighlight;
            lb_MCFeedBack.Location = new Point(85, 327);
            lb_MCFeedBack.Name = "lb_MCFeedBack";
            lb_MCFeedBack.Size = new Size(122, 15);
            lb_MCFeedBack.TabIndex = 17;
            lb_MCFeedBack.Text = "Feedback del médico:";
            // 
            // lb_AnimalSpecie
            // 
            lb_AnimalSpecie.AutoSize = true;
            lb_AnimalSpecie.BackColor = Color.OliveDrab;
            lb_AnimalSpecie.ForeColor = Color.LightGoldenrodYellow;
            lb_AnimalSpecie.Location = new Point(109, 210);
            lb_AnimalSpecie.Name = "lb_AnimalSpecie";
            lb_AnimalSpecie.Size = new Size(105, 15);
            lb_AnimalSpecie.TabIndex = 15;
            lb_AnimalSpecie.Text = "Ingrese su especie:";
            // 
            // cbb_AnimalSpecie
            // 
            cbb_AnimalSpecie.FormattingEnabled = true;
            cbb_AnimalSpecie.Items.AddRange(new object[] { "Perro", "Gato", "Conejo", "Pajaro" });
            cbb_AnimalSpecie.Location = new Point(109, 237);
            cbb_AnimalSpecie.Name = "cbb_AnimalSpecie";
            cbb_AnimalSpecie.Size = new Size(262, 23);
            cbb_AnimalSpecie.TabIndex = 14;
            // 
            // tb_MCFeedback
            // 
            tb_MCFeedback.Location = new Point(85, 354);
            tb_MCFeedback.Multiline = true;
            tb_MCFeedback.Name = "tb_MCFeedback";
            tb_MCFeedback.Size = new Size(315, 144);
            tb_MCFeedback.TabIndex = 13;
            // 
            // tb_AnimalName
            // 
            tb_AnimalName.Location = new Point(109, 165);
            tb_AnimalName.Name = "tb_AnimalName";
            tb_AnimalName.Size = new Size(262, 23);
            tb_AnimalName.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OliveDrab;
            pictureBox2.Location = new Point(76, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(334, 395);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // lb_CheckupDate
            // 
            lb_CheckupDate.AutoSize = true;
            lb_CheckupDate.BackColor = Color.OliveDrab;
            lb_CheckupDate.ForeColor = Color.LightGoldenrodYellow;
            lb_CheckupDate.Location = new Point(109, 273);
            lb_CheckupDate.Name = "lb_CheckupDate";
            lb_CheckupDate.Size = new Size(269, 15);
            lb_CheckupDate.TabIndex = 18;
            lb_CheckupDate.Text = "Ingrese la fecha y hora en la que realizó el control:";
            // 
            // dtp_CheckupDate
            // 
            dtp_CheckupDate.Location = new Point(109, 291);
            dtp_CheckupDate.Name = "dtp_CheckupDate";
            dtp_CheckupDate.Size = new Size(269, 23);
            dtp_CheckupDate.TabIndex = 19;
            // 
            // btn_AcceptMC
            // 
            btn_AcceptMC.Location = new Point(435, 496);
            btn_AcceptMC.Name = "btn_AcceptMC";
            btn_AcceptMC.Size = new Size(75, 23);
            btn_AcceptMC.TabIndex = 20;
            btn_AcceptMC.Text = "Aceptar";
            btn_AcceptMC.UseVisualStyleBackColor = true;
            btn_AcceptMC.Click += btn_AcceptMC_Click;
            // 
            // fm_AddMedicalCheckup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 531);
            Controls.Add(btn_AcceptMC);
            Controls.Add(dtp_CheckupDate);
            Controls.Add(lb_CheckupDate);
            Controls.Add(lb_MCFeedBack);
            Controls.Add(lb_AnimalSpecie);
            Controls.Add(cbb_AnimalSpecie);
            Controls.Add(tb_MCFeedback);
            Controls.Add(tb_AnimalName);
            Controls.Add(lb_animalName);
            Controls.Add(lb_MedicalCheckup);
            Controls.Add(pb_headerpic);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_AddMedicalCheckup";
            Text = "fm_AddMedicalCheckup";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_headerpic;
        private Label lb_MedicalCheckup;
        private Label lb_animalName;
        private Label lb_MCFeedBack;
        private Label lb_AnimalSpecie;
        private ComboBox cbb_AnimalSpecie;
        private TextBox tb_MCFeedback;
        private TextBox tb_AnimalName;
        private PictureBox pictureBox2;
        private Label lb_CheckupDate;
        private DateTimePicker dtp_CheckupDate;
        private Button btn_AcceptMC;
    }
}