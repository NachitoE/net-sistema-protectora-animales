namespace WindowsForms.menuAdmin.Houses
{
    partial class fm_HouseChangeCapacity
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
            dgv_houses = new DataGridView();
            lb_currentCapacity = new Label();
            lb_currentCapacityQuantity = new Label();
            lb_desiredCapacity = new Label();
            numud_desiredCapacity = new NumericUpDown();
            btn_accept = new Button();
            btn_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_houses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numud_desiredCapacity).BeginInit();
            SuspendLayout();
            // 
            // dgv_houses
            // 
            dgv_houses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_houses.Location = new Point(134, 24);
            dgv_houses.Name = "dgv_houses";
            dgv_houses.RowHeadersWidth = 51;
            dgv_houses.Size = new Size(723, 373);
            dgv_houses.TabIndex = 0;
            // 
            // lb_currentCapacity
            // 
            lb_currentCapacity.AutoSize = true;
            lb_currentCapacity.Location = new Point(134, 409);
            lb_currentCapacity.Name = "lb_currentCapacity";
            lb_currentCapacity.Size = new Size(121, 20);
            lb_currentCapacity.TabIndex = 1;
            lb_currentCapacity.Text = "Current Capacity:";
            // 
            // lb_currentCapacityQuantity
            // 
            lb_currentCapacityQuantity.AutoSize = true;
            lb_currentCapacityQuantity.Location = new Point(261, 409);
            lb_currentCapacityQuantity.Name = "lb_currentCapacityQuantity";
            lb_currentCapacityQuantity.Size = new Size(15, 20);
            lb_currentCapacityQuantity.TabIndex = 2;
            lb_currentCapacityQuantity.Text = "-";
            // 
            // lb_desiredCapacity
            // 
            lb_desiredCapacity.AutoSize = true;
            lb_desiredCapacity.Location = new Point(134, 446);
            lb_desiredCapacity.Name = "lb_desiredCapacity";
            lb_desiredCapacity.Size = new Size(124, 20);
            lb_desiredCapacity.TabIndex = 3;
            lb_desiredCapacity.Text = "Desired Capacity:";
            // 
            // numud_desiredCapacity
            // 
            numud_desiredCapacity.Location = new Point(261, 446);
            numud_desiredCapacity.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numud_desiredCapacity.Name = "numud_desiredCapacity";
            numud_desiredCapacity.ReadOnly = true;
            numud_desiredCapacity.Size = new Size(73, 27);
            numud_desiredCapacity.TabIndex = 5;
            // 
            // btn_accept
            // 
            btn_accept.Location = new Point(921, 472);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new Size(94, 29);
            btn_accept.TabIndex = 6;
            btn_accept.Text = "Aceptar";
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(812, 472);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // fm_HouseChangeCapacity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 513);
            Controls.Add(btn_cancel);
            Controls.Add(btn_accept);
            Controls.Add(numud_desiredCapacity);
            Controls.Add(lb_desiredCapacity);
            Controls.Add(lb_currentCapacityQuantity);
            Controls.Add(lb_currentCapacity);
            Controls.Add(dgv_houses);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fm_HouseChangeCapacity";
            Text = "fm_HouseChangeCapacity";
            ((System.ComponentModel.ISupportInitialize)dgv_houses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numud_desiredCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_houses;
        private Label lb_currentCapacity;
        private Label lb_currentCapacityQuantity;
        private Label lb_desiredCapacity;
        private NumericUpDown numud_desiredCapacity;
        private Button btn_accept;
        private Button btn_cancel;
    }
}