namespace WindowsForms.BasicForms
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
            nud_HouseCapacity = new NumericUpDown();
            tb_Houseumber = new TextBox();
            tb_HouseStreet = new TextBox();
            lb_HouseRoad = new Label();
            lb_HouseNumber = new Label();
            lb_HouseCap = new Label();
            btn_ConfirmHouse = new Button();
            lb_Info = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_HouseCapacity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(574, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // nud_HouseCapacity
            // 
            nud_HouseCapacity.Location = new Point(203, 193);
            nud_HouseCapacity.Name = "nud_HouseCapacity";
            nud_HouseCapacity.Size = new Size(229, 23);
            nud_HouseCapacity.TabIndex = 2;
            // 
            // tb_Houseumber
            // 
            tb_Houseumber.Location = new Point(203, 160);
            tb_Houseumber.MaxLength = 6;
            tb_Houseumber.Name = "tb_Houseumber";
            tb_Houseumber.Size = new Size(228, 23);
            tb_Houseumber.TabIndex = 3;
            // 
            // tb_HouseStreet
            // 
            tb_HouseStreet.Location = new Point(203, 119);
            tb_HouseStreet.Name = "tb_HouseStreet";
            tb_HouseStreet.Size = new Size(227, 23);
            tb_HouseStreet.TabIndex = 4;
            // 
            // lb_HouseRoad
            // 
            lb_HouseRoad.AutoSize = true;
            lb_HouseRoad.Location = new Point(12, 120);
            lb_HouseRoad.Name = "lb_HouseRoad";
            lb_HouseRoad.Size = new Size(36, 15);
            lb_HouseRoad.TabIndex = 5;
            lb_HouseRoad.Text = "Calle:";
            // 
            // lb_HouseNumber
            // 
            lb_HouseNumber.AutoSize = true;
            lb_HouseNumber.Location = new Point(12, 153);
            lb_HouseNumber.Name = "lb_HouseNumber";
            lb_HouseNumber.Size = new Size(42, 15);
            lb_HouseNumber.TabIndex = 6;
            lb_HouseNumber.Text = "Altura:";
            // 
            // lb_HouseCap
            // 
            lb_HouseCap.AutoSize = true;
            lb_HouseCap.Location = new Point(12, 188);
            lb_HouseCap.Name = "lb_HouseCap";
            lb_HouseCap.Size = new Size(164, 30);
            lb_HouseCap.TabIndex = 7;
            lb_HouseCap.Text = "Número máximo de animales\r\n que desee transitar:\r\n";
            // 
            // btn_ConfirmHouse
            // 
            btn_ConfirmHouse.Location = new Point(487, 268);
            btn_ConfirmHouse.Name = "btn_ConfirmHouse";
            btn_ConfirmHouse.Size = new Size(75, 23);
            btn_ConfirmHouse.TabIndex = 8;
            btn_ConfirmHouse.Text = "Aceptar\r\n";
            btn_ConfirmHouse.UseVisualStyleBackColor = true;
            btn_ConfirmHouse.Click += btn_ConfirmHouse_Click;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.BackColor = Color.OliveDrab;
            lb_Info.ForeColor = Color.LightYellow;
            lb_Info.Location = new Point(152, 83);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(200, 15);
            lb_Info.TabIndex = 9;
            lb_Info.Text = "AGREGAR DATOS DE SU PROPIEDAD:";
            // 
            // fm_HouseLoad
            // 
            AcceptButton = btn_ConfirmHouse;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 303);
            Controls.Add(lb_Info);
            Controls.Add(btn_ConfirmHouse);
            Controls.Add(lb_HouseCap);
            Controls.Add(lb_HouseNumber);
            Controls.Add(lb_HouseRoad);
            Controls.Add(tb_HouseStreet);
            Controls.Add(tb_Houseumber);
            Controls.Add(nud_HouseCapacity);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "fm_HouseLoad";
            Text = "Cargar Casa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_HouseCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown nud_HouseCapacity;
        private TextBox tb_Houseumber;
        private TextBox tb_HouseStreet;
        private Label lb_HouseRoad;
        private Label lb_HouseNumber;
        private Label lb_HouseCap;
        private Button btn_ConfirmHouse;
        private Label lb_Info;
    }
}