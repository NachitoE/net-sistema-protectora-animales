namespace WindowsForms.BasicForms
{
    partial class fm_ManageAdoptions
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
            pb_Background = new PictureBox();
            btn_AcceptChanges = new Button();
            dgv_Manage_Adoptions = new DataGridView();
            label1 = new Label();
            btn_filterAccepted = new Button();
            btn_RejectedAdoptions = new Button();
            btn_awaitingAdoptions = new Button();
            btn_ShowAll = new Button();
            label2 = new Label();
            btn_Accept = new Button();
            btn_reject = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Background).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Manage_Adoptions).BeginInit();
            SuspendLayout();
            // 
            // pb_Background
            // 
            pb_Background.BackColor = Color.OliveDrab;
            pb_Background.Location = new Point(51, 144);
            pb_Background.Margin = new Padding(4, 3, 4, 3);
            pb_Background.Name = "pb_Background";
            pb_Background.Size = new Size(843, 573);
            pb_Background.TabIndex = 23;
            pb_Background.TabStop = false;
            // 
            // btn_AcceptChanges
            // 
            btn_AcceptChanges.Location = new Point(1111, 765);
            btn_AcceptChanges.Name = "btn_AcceptChanges";
            btn_AcceptChanges.Size = new Size(97, 23);
            btn_AcceptChanges.TabIndex = 24;
            btn_AcceptChanges.Text = "aceptar";
            btn_AcceptChanges.UseVisualStyleBackColor = true;
            // 
            // dgv_Manage_Adoptions
            // 
            dgv_Manage_Adoptions.BackgroundColor = SystemColors.ButtonFace;
            dgv_Manage_Adoptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Manage_Adoptions.Location = new Point(86, 181);
            dgv_Manage_Adoptions.Name = "dgv_Manage_Adoptions";
            dgv_Manage_Adoptions.Size = new Size(765, 506);
            dgv_Manage_Adoptions.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.OliveDrab;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 26;
            label1.Text = "Administrar Adopciones";
            // 
            // btn_filterAccepted
            // 
            btn_filterAccepted.Location = new Point(86, 103);
            btn_filterAccepted.Name = "btn_filterAccepted";
            btn_filterAccepted.Size = new Size(174, 23);
            btn_filterAccepted.TabIndex = 27;
            btn_filterAccepted.Text = " APROBADAS";
            btn_filterAccepted.UseVisualStyleBackColor = true;
            // 
            // btn_RejectedAdoptions
            // 
            btn_RejectedAdoptions.Location = new Point(275, 103);
            btn_RejectedAdoptions.Name = "btn_RejectedAdoptions";
            btn_RejectedAdoptions.Size = new Size(180, 23);
            btn_RejectedAdoptions.TabIndex = 28;
            btn_RejectedAdoptions.Text = "RECHAZADAS";
            btn_RejectedAdoptions.UseVisualStyleBackColor = true;
            // 
            // btn_awaitingAdoptions
            // 
            btn_awaitingAdoptions.Location = new Point(461, 103);
            btn_awaitingAdoptions.Name = "btn_awaitingAdoptions";
            btn_awaitingAdoptions.Size = new Size(204, 23);
            btn_awaitingAdoptions.TabIndex = 29;
            btn_awaitingAdoptions.Text = "PENDIENTES";
            btn_awaitingAdoptions.UseVisualStyleBackColor = true;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.Location = new Point(671, 103);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(204, 23);
            btn_ShowAll.TabIndex = 30;
            btn_ShowAll.Text = "Mostrar todas";
            btn_ShowAll.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 85);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 31;
            label2.Text = "Filtrar Adopciones por:";
            // 
            // btn_Accept
            // 
            btn_Accept.Location = new Point(962, 239);
            btn_Accept.Name = "btn_Accept";
            btn_Accept.Size = new Size(174, 23);
            btn_Accept.TabIndex = 32;
            btn_Accept.Text = " APROBAR";
            btn_Accept.UseVisualStyleBackColor = true;
            // 
            // btn_reject
            // 
            btn_reject.Location = new Point(962, 310);
            btn_reject.Name = "btn_reject";
            btn_reject.Size = new Size(174, 23);
            btn_reject.TabIndex = 33;
            btn_reject.Text = "RECHAZAR";
            btn_reject.UseVisualStyleBackColor = true;
            // 
            // fm_ManageAdoptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 800);
            Controls.Add(btn_reject);
            Controls.Add(btn_Accept);
            Controls.Add(label2);
            Controls.Add(btn_ShowAll);
            Controls.Add(btn_awaitingAdoptions);
            Controls.Add(btn_RejectedAdoptions);
            Controls.Add(btn_filterAccepted);
            Controls.Add(label1);
            Controls.Add(dgv_Manage_Adoptions);
            Controls.Add(btn_AcceptChanges);
            Controls.Add(pb_Background);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fm_ManageAdoptions";
            Text = "fm_ManageAdoptions";
            ((System.ComponentModel.ISupportInitialize)pb_Background).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Manage_Adoptions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Background;
        private Button btn_AcceptChanges;
        private DataGridView dgv_Manage_Adoptions;
        private Label label1;
        private Button btn_filterAccepted;
        private Button button2;
        private Button button3;
        private Button btn_RejectedAdoptions;
        private Button btn_awaitingAdoptions;
        private Button btn_ShowAll;
        private Label label2;
        private Button btn_Accept;
        private Button btn_reject;
    }
}