namespace WindowsForms.menuAdopter
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
            pb_headerpic = new PictureBox();
            lb_MATitle = new Label();
            btn_Dog = new Button();
            btn_Cat = new Button();
            btn_Bunny = new Button();
            btn_Bird = new Button();
            dgv_animals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_animals).BeginInit();
            SuspendLayout();
            // 
            // pb_headerpic
            // 
            pb_headerpic.BackgroundImage = Properties.Resources.Studio_Ghibli__Cattt__;
            pb_headerpic.Location = new Point(-328, 24);
            pb_headerpic.Name = "pb_headerpic";
            pb_headerpic.Size = new Size(416, 414);
            pb_headerpic.TabIndex = 1;
            pb_headerpic.TabStop = false;
            // 
            // lb_MATitle
            // 
            lb_MATitle.AutoSize = true;
            lb_MATitle.Location = new Point(130, 33);
            lb_MATitle.Name = "lb_MATitle";
            lb_MATitle.Size = new Size(263, 15);
            lb_MATitle.TabIndex = 2;
            lb_MATitle.Text = "Seleccione que especie de animal desea adoptar:";
            // 
            // btn_Dog
            // 
            btn_Dog.Location = new Point(137, 97);
            btn_Dog.Name = "btn_Dog";
            btn_Dog.Size = new Size(250, 23);
            btn_Dog.TabIndex = 3;
            btn_Dog.Text = "Perro";
            btn_Dog.UseVisualStyleBackColor = true;
            btn_Dog.Click += btn_Dog_Click;
            // 
            // btn_Cat
            // 
            btn_Cat.Location = new Point(137, 126);
            btn_Cat.Name = "btn_Cat";
            btn_Cat.Size = new Size(250, 23);
            btn_Cat.TabIndex = 4;
            btn_Cat.Text = "Gato";
            btn_Cat.UseVisualStyleBackColor = true;
            btn_Cat.Click += btn_Cat_Click;
            // 
            // btn_Bunny
            // 
            btn_Bunny.Location = new Point(137, 155);
            btn_Bunny.Name = "btn_Bunny";
            btn_Bunny.Size = new Size(250, 23);
            btn_Bunny.TabIndex = 5;
            btn_Bunny.Text = "Conejo";
            btn_Bunny.UseVisualStyleBackColor = true;
            btn_Bunny.Click += btn_Bunny_Click;
            // 
            // btn_Bird
            // 
            btn_Bird.Location = new Point(137, 184);
            btn_Bird.Name = "btn_Bird";
            btn_Bird.Size = new Size(250, 23);
            btn_Bird.TabIndex = 6;
            btn_Bird.Text = "Pájaro";
            btn_Bird.UseVisualStyleBackColor = true;
            btn_Bird.Click += btn_Bird_Click;
            // 
            // dgv_animals
            // 
            dgv_animals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_animals.Location = new Point(447, 33);
            dgv_animals.Name = "dgv_animals";
            dgv_animals.Size = new Size(341, 405);
            dgv_animals.TabIndex = 7;
            // 
            // fm_ShowAvailableAnimals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_animals);
            Controls.Add(btn_Bird);
            Controls.Add(btn_Bunny);
            Controls.Add(btn_Cat);
            Controls.Add(btn_Dog);
            Controls.Add(lb_MATitle);
            Controls.Add(pb_headerpic);
            Name = "fm_ShowAvailableAnimals";
            Text = "fm_ShowAvailableAnimals";
            ((System.ComponentModel.ISupportInitialize)pb_headerpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_animals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_headerpic;
        private Label lb_MATitle;
        private Button btn_Dog;
        private Button btn_Bunny;
        private Button btn_Bird;
        private DataGridView dgv_animals;
        private Button btn_Cat;
    }
}