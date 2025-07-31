namespace WindowsFormsApp1
{
    partial class fm_AdminAnimalMenu
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
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.lb_MenuTitle = new System.Windows.Forms.Label();
            this.btn_AddNewAnimal = new System.Windows.Forms.Button();
            this.btn_ShowAllAnimals = new System.Windows.Forms.Button();
            this.btn_asignResp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(-3, -1);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(376, 81);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 3;
            this.pb_headerpic.TabStop = false;
            // 
            // lb_MenuTitle
            // 
            this.lb_MenuTitle.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_MenuTitle.Enabled = false;
            this.lb_MenuTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MenuTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_MenuTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_MenuTitle.Location = new System.Drawing.Point(-10, 42);
            this.lb_MenuTitle.Name = "lb_MenuTitle";
            this.lb_MenuTitle.Size = new System.Drawing.Size(146, 38);
            this.lb_MenuTitle.TabIndex = 4;
            this.lb_MenuTitle.Text = "ANIMALES";
            // 
            // btn_AddNewAnimal
            // 
            this.btn_AddNewAnimal.Location = new System.Drawing.Point(51, 184);
            this.btn_AddNewAnimal.Name = "btn_AddNewAnimal";
            this.btn_AddNewAnimal.Size = new System.Drawing.Size(248, 28);
            this.btn_AddNewAnimal.TabIndex = 13;
            this.btn_AddNewAnimal.Text = "Añadir nuevo animal";
            this.btn_AddNewAnimal.UseVisualStyleBackColor = true;
            this.btn_AddNewAnimal.Click += new System.EventHandler(this.btn_AddNewAnimal_Click);
            // 
            // btn_ShowAllAnimals
            // 
            this.btn_ShowAllAnimals.Location = new System.Drawing.Point(51, 239);
            this.btn_ShowAllAnimals.Name = "btn_ShowAllAnimals";
            this.btn_ShowAllAnimals.Size = new System.Drawing.Size(248, 28);
            this.btn_ShowAllAnimals.TabIndex = 12;
            this.btn_ShowAllAnimals.Text = "Todos los animales";
            this.btn_ShowAllAnimals.UseVisualStyleBackColor = true;
            this.btn_ShowAllAnimals.Click += new System.EventHandler(this.btn_ShowAllAnimals_Click);
            // 
            // btn_asignResp
            // 
            this.btn_asignResp.Location = new System.Drawing.Point(51, 133);
            this.btn_asignResp.Name = "btn_asignResp";
            this.btn_asignResp.Size = new System.Drawing.Size(248, 28);
            this.btn_asignResp.TabIndex = 11;
            this.btn_asignResp.Text = "Asignar cuidador";
            this.btn_asignResp.UseVisualStyleBackColor = true;
            this.btn_asignResp.Click += new System.EventHandler(this.btn_asignResp_Click);
            // 
            // fm_AdminAnimalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 368);
            this.Controls.Add(this.btn_AddNewAnimal);
            this.Controls.Add(this.btn_ShowAllAnimals);
            this.Controls.Add(this.btn_asignResp);
            this.Controls.Add(this.lb_MenuTitle);
            this.Controls.Add(this.pb_headerpic);
            this.MaximizeBox = false;
            this.Name = "fm_AdminAnimalMenu";
            this.Text = "Animales lobby";
            this.Load += new System.EventHandler(this.fm_AdminAnimalMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        public System.Windows.Forms.Button btn_AddNewAnimal;
        private System.Windows.Forms.Button btn_ShowAllAnimals;
        public System.Windows.Forms.Button btn_asignResp;
    }
}