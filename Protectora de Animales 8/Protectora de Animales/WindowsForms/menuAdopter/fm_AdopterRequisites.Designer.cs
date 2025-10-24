namespace WindowsForms.menuAdopter
{
    partial class fm_AdopterRequisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_AdopterRequisites));
            ckb_TermsofAdoption = new CheckBox();
            lb_AdoptionRQ = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_AcceptRequisites = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ckb_TermsofAdoption
            // 
            ckb_TermsofAdoption.AutoSize = true;
            ckb_TermsofAdoption.Location = new Point(12, 368);
            ckb_TermsofAdoption.Name = "ckb_TermsofAdoption";
            ckb_TermsofAdoption.Size = new Size(259, 19);
            ckb_TermsofAdoption.TabIndex = 0;
            ckb_TermsofAdoption.Text = "He leído y acepto los requisitos de adopción";
            ckb_TermsofAdoption.UseVisualStyleBackColor = true;
            ckb_TermsofAdoption.CheckedChanged += ckb_TermsofAdoption_CheckedChanged;
            // 
            // lb_AdoptionRQ
            // 
            lb_AdoptionRQ.AutoSize = true;
            lb_AdoptionRQ.BackColor = Color.OliveDrab;
            lb_AdoptionRQ.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_AdoptionRQ.ForeColor = SystemColors.ButtonHighlight;
            lb_AdoptionRQ.Location = new Point(256, 25);
            lb_AdoptionRQ.Name = "lb_AdoptionRQ";
            lb_AdoptionRQ.Size = new Size(269, 32);
            lb_AdoptionRQ.TabIndex = 1;
            lb_AdoptionRQ.Text = "Requisitos para adoptar:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.OliveDrab;
            pictureBox1.Location = new Point(39, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(745, 293);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(51, 79);
            label1.Name = "label1";
            label1.Size = new Size(733, 225);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btn_AcceptRequisites
            // 
            btn_AcceptRequisites.Location = new Point(712, 368);
            btn_AcceptRequisites.Name = "btn_AcceptRequisites";
            btn_AcceptRequisites.Size = new Size(86, 23);
            btn_AcceptRequisites.TabIndex = 4;
            btn_AcceptRequisites.Text = "Aceptar";
            btn_AcceptRequisites.UseVisualStyleBackColor = true;
            btn_AcceptRequisites.Click += btn_AcceptRequisites_Click;
            // 
            // fm_AdopterRequisites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 398);
            Controls.Add(btn_AcceptRequisites);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lb_AdoptionRQ);
            Controls.Add(ckb_TermsofAdoption);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "fm_AdopterRequisites";
            Text = "fm_AdopterRequisites";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckb_TermsofAdoption;
        private Label lb_AdoptionRQ;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_AcceptRequisites;
    }
}