namespace WindowsForms.menuAdopter
{
    partial class fm_AdopterMenu
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
            label1 = new Label();
            btn_AdopterInfo = new Button();
            btn_AdoptionFollowing = new Button();
            btn_AdopterInfoa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(-161, -105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(774, 231);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Olive;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(-2, 79);
            label1.Name = "label1";
            label1.Size = new Size(119, 47);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_AdopterInfo
            // 
            btn_AdopterInfo.Location = new Point(93, 160);
            btn_AdopterInfo.Name = "btn_AdopterInfo";
            btn_AdopterInfo.Size = new Size(250, 23);
            btn_AdopterInfo.TabIndex = 2;
            btn_AdopterInfo.Text = "Requisitos para adoptar";
            btn_AdopterInfo.UseVisualStyleBackColor = true;
            // 
            // btn_AdoptionFollowing
            // 
            btn_AdoptionFollowing.Location = new Point(93, 228);
            btn_AdoptionFollowing.Name = "btn_AdoptionFollowing";
            btn_AdoptionFollowing.Size = new Size(250, 23);
            btn_AdoptionFollowing.TabIndex = 3;
            btn_AdoptionFollowing.Text = "Seguir mis Adopciones";
            btn_AdoptionFollowing.UseVisualStyleBackColor = true;
            // 
            // btn_AdopterInfoa
            // 
            btn_AdopterInfoa.Location = new Point(93, 293);
            btn_AdopterInfoa.Name = "btn_AdopterInfoa";
            btn_AdopterInfoa.Size = new Size(250, 23);
            btn_AdopterInfoa.TabIndex = 4;
            btn_AdopterInfoa.Text = "Ver Animales";
            btn_AdopterInfoa.UseVisualStyleBackColor = true;
            // 
            // fm_AdopterMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 400);
            Controls.Add(btn_AdopterInfoa);
            Controls.Add(btn_AdoptionFollowing);
            Controls.Add(btn_AdopterInfo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "fm_AdopterMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_AdopterInfo;
        private Button btn_AdoptionFollowing;
        private Button btn_AdopterInfoa;
    }
}