namespace WindowsForms.BasicForms
{
    partial class fm_AnimalsMedicalCheckUp
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
            lb_MedicalCheckup = new Label();
            pb_Background = new PictureBox();
            dgv_User = new DataGridView();
            btn_AcceptChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).BeginInit();
            SuspendLayout();
            // 
            // lb_MedicalCheckup
            // 
            lb_MedicalCheckup.AutoSize = true;
            lb_MedicalCheckup.BackColor = Color.OliveDrab;
            lb_MedicalCheckup.ForeColor = SystemColors.ButtonHighlight;
            lb_MedicalCheckup.Location = new Point(373, 19);
            lb_MedicalCheckup.Margin = new Padding(4, 0, 4, 0);
            lb_MedicalCheckup.Name = "lb_MedicalCheckup";
            lb_MedicalCheckup.Size = new Size(125, 15);
            lb_MedicalCheckup.TabIndex = 8;
            lb_MedicalCheckup.Text = "CHEQUEOS MEDICOS:";
            // 
            // pb_Background
            // 
            pb_Background.BackColor = Color.OliveDrab;
            pb_Background.Location = new Point(68, 53);
            pb_Background.Margin = new Padding(4, 3, 4, 3);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(773, 404);
            pb_Background.TabIndex = 13;
            pb_Background.TabStop = false;
            // 
            // dgv_User
            // 
            dgv_User.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_User.Location = new Point(87, 70);
            dgv_User.Margin = new Padding(4, 3, 4, 3);
            dgv_User.Name = "dgv_User";
            dgv_User.RowHeadersWidth = 51;
            dgv_User.Size = new Size(733, 366);
            dgv_User.TabIndex = 16;
            // 
            // btn_AcceptChanges
            // 
            btn_AcceptChanges.Location = new Point(815, 484);
            btn_AcceptChanges.Name = "btn_AcceptChanges";
            btn_AcceptChanges.Size = new Size(97, 23);
            btn_AcceptChanges.TabIndex = 17;
            btn_AcceptChanges.Text = "aceptar";
            btn_AcceptChanges.UseVisualStyleBackColor = true;
            btn_AcceptChanges.Click += btn_AcceptChanges_Click;
            // 
            // fm_AnimalsMedicalCheckUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btn_AcceptChanges);
            Controls.Add(dgv_User);
            Controls.Add(pb_Background);
            Controls.Add(lb_MedicalCheckup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AnimalsMedicalCheckUp";
            Text = "fm_AnimalsMedicalCheckUp";
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_User).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lb_MedicalCheckup;
        private PictureBox pb_Background;
        private DataGridView dgv_User;
        private Button btn_AcceptChanges;
    }
}