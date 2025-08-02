namespace WindowsFormsApp1.menuAdopter
{
    partial class fm_ShowAvailableAnimals
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
            this.lb_MATitle = new System.Windows.Forms.Label();
            this.pb_headerpic = new System.Windows.Forms.PictureBox();
            this.dgv_animals = new System.Windows.Forms.DataGridView();
            this.btn_Dog = new System.Windows.Forms.Button();
            this.btn_Cat = new System.Windows.Forms.Button();
            this.btn_Bunny = new System.Windows.Forms.Button();
            this.btn_Bird = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animals)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_MATitle
            // 
            this.lb_MATitle.AutoSize = true;
            this.lb_MATitle.Location = new System.Drawing.Point(61, 27);
            this.lb_MATitle.Name = "lb_MATitle";
            this.lb_MATitle.Size = new System.Drawing.Size(243, 13);
            this.lb_MATitle.TabIndex = 8;
            this.lb_MATitle.Text = "Seleccione que especie de animal desea adoptar:";
            // 
            // pb_headerpic
            // 
            this.pb_headerpic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_headerpic.Image = global::WindowsFormsApp1.Properties.Resources.Studio_Ghibli__Cattt__;
            this.pb_headerpic.Location = new System.Drawing.Point(0, 0);
            this.pb_headerpic.Name = "pb_headerpic";
            this.pb_headerpic.Size = new System.Drawing.Size(55, 450);
            this.pb_headerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_headerpic.TabIndex = 7;
            this.pb_headerpic.TabStop = false;
            // 
            // dgv_animals
            // 
            this.dgv_animals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_animals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_animals.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_animals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_animals.GridColor = System.Drawing.Color.ForestGreen;
            this.dgv_animals.Location = new System.Drawing.Point(315, 27);
            this.dgv_animals.Name = "dgv_animals";
            this.dgv_animals.ReadOnly = true;
            this.dgv_animals.Size = new System.Drawing.Size(473, 411);
            this.dgv_animals.TabIndex = 6;
            // 
            // btn_Dog
            // 
            this.btn_Dog.Location = new System.Drawing.Point(89, 57);
            this.btn_Dog.Name = "btn_Dog";
            this.btn_Dog.Size = new System.Drawing.Size(186, 23);
            this.btn_Dog.TabIndex = 9;
            this.btn_Dog.Text = "PERRO";
            this.btn_Dog.UseVisualStyleBackColor = true;
            this.btn_Dog.Click += new System.EventHandler(this.btn_Dog_Click);
            // 
            // btn_Cat
            // 
            this.btn_Cat.Location = new System.Drawing.Point(89, 96);
            this.btn_Cat.Name = "btn_Cat";
            this.btn_Cat.Size = new System.Drawing.Size(186, 23);
            this.btn_Cat.TabIndex = 10;
            this.btn_Cat.Text = "GATO";
            this.btn_Cat.UseVisualStyleBackColor = true;
            this.btn_Cat.Click += new System.EventHandler(this.btn_Cat_Click);
            // 
            // btn_Bunny
            // 
            this.btn_Bunny.Location = new System.Drawing.Point(89, 131);
            this.btn_Bunny.Name = "btn_Bunny";
            this.btn_Bunny.Size = new System.Drawing.Size(186, 23);
            this.btn_Bunny.TabIndex = 11;
            this.btn_Bunny.Text = "CONEJO";
            this.btn_Bunny.UseVisualStyleBackColor = true;
            this.btn_Bunny.Click += new System.EventHandler(this.btn_Bunny_Click);
            // 
            // btn_Bird
            // 
            this.btn_Bird.Location = new System.Drawing.Point(89, 172);
            this.btn_Bird.Name = "btn_Bird";
            this.btn_Bird.Size = new System.Drawing.Size(186, 23);
            this.btn_Bird.TabIndex = 12;
            this.btn_Bird.Text = "PÁJARO";
            this.btn_Bird.UseVisualStyleBackColor = true;
            this.btn_Bird.Click += new System.EventHandler(this.btn_Bird_Click);
            // 
            // fm_ShowAvailableAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Bird);
            this.Controls.Add(this.btn_Bunny);
            this.Controls.Add(this.btn_Cat);
            this.Controls.Add(this.btn_Dog);
            this.Controls.Add(this.lb_MATitle);
            this.Controls.Add(this.pb_headerpic);
            this.Controls.Add(this.dgv_animals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fm_ShowAvailableAnimals";
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_animals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_MATitle;
        private System.Windows.Forms.PictureBox pb_headerpic;
        private System.Windows.Forms.DataGridView dgv_animals;
        private System.Windows.Forms.Button btn_Dog;
        private System.Windows.Forms.Button btn_Cat;
        private System.Windows.Forms.Button btn_Bunny;
        private System.Windows.Forms.Button btn_Bird;
    }
}