namespace WindowsForms.menuAdmin.Animals
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
            lb_MenuTitle = new Label();
            btn_AddNewAnimal = new Button();
            btn_ShowAllAnimals = new Button();
            btn_asignResp = new Button();
            pb_headerpic = new PictureBox();
            btn_AnimalModify = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            SuspendLayout();
            // 
            // lb_MenuTitle
            // 
            lb_MenuTitle.BackColor = Color.DarkOliveGreen;
            lb_MenuTitle.Enabled = false;
            lb_MenuTitle.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_MenuTitle.ForeColor = SystemColors.ButtonHighlight;
            lb_MenuTitle.ImageAlign = ContentAlignment.MiddleRight;
            lb_MenuTitle.Location = new Point(-6, 48);
            lb_MenuTitle.Margin = new Padding(4, 0, 4, 0);
            lb_MenuTitle.Name = "lb_MenuTitle";
            lb_MenuTitle.Size = new Size(170, 44);
            lb_MenuTitle.TabIndex = 4;
            lb_MenuTitle.Text = "ANIMALES";
            // 
            // btn_AddNewAnimal
            // 
            btn_AddNewAnimal.Location = new Point(59, 212);
            btn_AddNewAnimal.Margin = new Padding(4, 3, 4, 3);
            btn_AddNewAnimal.Name = "btn_AddNewAnimal";
            btn_AddNewAnimal.Size = new Size(289, 32);
            btn_AddNewAnimal.TabIndex = 13;
            btn_AddNewAnimal.Text = "Añadir nuevo animal";
            btn_AddNewAnimal.UseVisualStyleBackColor = true;
            btn_AddNewAnimal.Click += btn_AddNewAnimal_Click;
            // 
            // btn_ShowAllAnimals
            // 
            btn_ShowAllAnimals.Location = new Point(59, 276);
            btn_ShowAllAnimals.Margin = new Padding(4, 3, 4, 3);
            btn_ShowAllAnimals.Name = "btn_ShowAllAnimals";
            btn_ShowAllAnimals.Size = new Size(289, 32);
            btn_ShowAllAnimals.TabIndex = 12;
            btn_ShowAllAnimals.Text = "Todos los animales";
            btn_ShowAllAnimals.UseVisualStyleBackColor = true;
            btn_ShowAllAnimals.Click += btn_ShowAllAnimals_Click;
            // 
            // btn_asignResp
            // 
            btn_asignResp.Location = new Point(59, 153);
            btn_asignResp.Margin = new Padding(4, 3, 4, 3);
            btn_asignResp.Name = "btn_asignResp";
            btn_asignResp.Size = new Size(289, 32);
            btn_asignResp.TabIndex = 11;
            btn_asignResp.Text = "Asignar cuidador";
            btn_asignResp.UseVisualStyleBackColor = true;
            btn_asignResp.Click += btn_asignResp_Click;
            // 
            // pb_headerpic
            // 
            pb_headerpic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_headerpic.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(-4, -1);
            pb_headerpic.Margin = new Padding(4, 3, 4, 3);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(439, 93);
            pb_headerpic.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_headerpic.TabIndex = 3;
            pb_headerpic.TabStop = false;
            // 
            // btn_AnimalModify
            // 
            btn_AnimalModify.Location = new Point(59, 343);
            btn_AnimalModify.Margin = new Padding(4, 3, 4, 3);
            btn_AnimalModify.Name = "btn_AnimalModify";
            btn_AnimalModify.Size = new Size(289, 32);
            btn_AnimalModify.TabIndex = 14;
            btn_AnimalModify.Text = "Modificar Animales";
            btn_AnimalModify.UseVisualStyleBackColor = true;
            btn_AnimalModify.Click += btn_AnimalModify_Click;
            // 
            // fm_AdminAnimalMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 425);
            Controls.Add(btn_AnimalModify);
            Controls.Add(btn_AddNewAnimal);
            Controls.Add(btn_ShowAllAnimals);
            Controls.Add(btn_asignResp);
            Controls.Add(lb_MenuTitle);
            Controls.Add(pb_headerpic);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_AdminAnimalMenu";
            Text = "Animales lobby";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_headerpic;
        protected internal System.Windows.Forms.Label lb_MenuTitle;
        public System.Windows.Forms.Button btn_AddNewAnimal;
        private System.Windows.Forms.Button btn_ShowAllAnimals;
        public System.Windows.Forms.Button btn_asignResp;
        private System.Windows.Forms.Button btn_AnimalModify;
    }
}