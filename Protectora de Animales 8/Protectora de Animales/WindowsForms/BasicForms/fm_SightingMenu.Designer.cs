namespace WindowsForms.BasicForms
{
    partial class fm_SightingMenu
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dgv_Sightings = new DataGridView();
            lb_Sightings = new Label();
            btn_FilterIncoming = new Button();
            btn_FilterSeen = new Button();
            btn_ConfirmSighting = new Button();
            btn_DeleteSighting = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sightings).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(785, 475);
            button1.Name = "button1";
            button1.Size = new Size(136, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Studio_Ghibli__Cattt__;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(736, 70);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dgv_Sightings
            // 
            dgv_Sightings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sightings.Location = new Point(12, 125);
            dgv_Sightings.Name = "dgv_Sightings";
            dgv_Sightings.Size = new Size(508, 423);
            dgv_Sightings.TabIndex = 17;
            // 
            // lb_Sightings
            // 
            lb_Sightings.AutoSize = true;
            lb_Sightings.BackColor = Color.OliveDrab;
            lb_Sightings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Sightings.ForeColor = SystemColors.ButtonHighlight;
            lb_Sightings.Location = new Point(295, 73);
            lb_Sightings.Name = "lb_Sightings";
            lb_Sightings.Size = new Size(125, 21);
            lb_Sightings.TabIndex = 18;
            lb_Sightings.Text = "AVISTAMIENTOS";
            // 
            // btn_FilterIncoming
            // 
            btn_FilterIncoming.Location = new Point(554, 125);
            btn_FilterIncoming.Name = "btn_FilterIncoming";
            btn_FilterIncoming.Size = new Size(146, 23);
            btn_FilterIncoming.TabIndex = 19;
            btn_FilterIncoming.Text = "Sin Atender";
            btn_FilterIncoming.UseVisualStyleBackColor = true;
            btn_FilterIncoming.Click += btn_FilterIncoming_Click;
            // 
            // btn_FilterSeen
            // 
            btn_FilterSeen.Location = new Point(555, 174);
            btn_FilterSeen.Name = "btn_FilterSeen";
            btn_FilterSeen.Size = new Size(146, 23);
            btn_FilterSeen.TabIndex = 20;
            btn_FilterSeen.Text = "Atendidos";
            btn_FilterSeen.UseVisualStyleBackColor = true;
            btn_FilterSeen.Click += btn_FilterSeen_Click;
            // 
            // btn_ConfirmSighting
            // 
            btn_ConfirmSighting.Location = new Point(554, 228);
            btn_ConfirmSighting.Name = "btn_ConfirmSighting";
            btn_ConfirmSighting.Size = new Size(145, 23);
            btn_ConfirmSighting.TabIndex = 21;
            btn_ConfirmSighting.Text = "Marcar como atendido";
            btn_ConfirmSighting.UseVisualStyleBackColor = true;
            btn_ConfirmSighting.Click += btn_ConfirmSighting_Click;
            // 
            // btn_DeleteSighting
            // 
            btn_DeleteSighting.Location = new Point(555, 279);
            btn_DeleteSighting.Name = "btn_DeleteSighting";
            btn_DeleteSighting.Size = new Size(145, 23);
            btn_DeleteSighting.TabIndex = 22;
            btn_DeleteSighting.Text = "Eliminar Avistamiento ";
            btn_DeleteSighting.UseVisualStyleBackColor = true;
            btn_DeleteSighting.Click += btn_DeleteSighting_Click;
            // 
            // fm_SightingMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 560);
            Controls.Add(btn_DeleteSighting);
            Controls.Add(btn_ConfirmSighting);
            Controls.Add(btn_FilterSeen);
            Controls.Add(btn_FilterIncoming);
            Controls.Add(lb_Sightings);
            Controls.Add(dgv_Sightings);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "fm_SightingMenu";
            Text = "AVISTAMIENTOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Sightings).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private DataGridView dgv_Sightings;
        private Label lb_Sightings;
        private Button btn_FilterIncoming;
        private Button btn_FilterSeen;
        private Button btn_ConfirmSighting;
        private Button btn_DeleteSighting;
    }
}