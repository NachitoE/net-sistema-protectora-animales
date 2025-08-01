using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace WindowsFormsApp1
{
    public partial class fm_loggin : Form
    {
        public fm_loggin()
        {
            InitializeComponent();
        }

      


        private void btn_loggin_Click(object sender, EventArgs e)
        {
            if (ControlLoginEmpty(this.tb_user.Text)) {
                string message = "Rellena el usuario";
                  string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                SendMessage(message, caption, buttons);
                return;
            }
            if (ControlLoginEmpty(this.tb_password.Text))
            {
                string message = "Rellena la contraseña";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                SendMessage(message, caption, buttons);
                return;
            }

            if (!UserService.Instance.IsValidUser(this.tb_user.Text, this.tb_password.Text))
            {
                string message = "Usuario o contraseña incorrectos";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                SendMessage(message, caption, buttons);
                return;
            }
            this.Hide();
            fm_AdminMenu menuForm= new fm_AdminMenu();
            menuForm.ShowDialog();
            this.Show(); 
        }
        private bool ControlLoginEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }
        
        private void SendMessage(string message, string caption, MessageBoxButtons buttons)
        {
            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                // Acción si se pulsa "Sí"
            }
            else if (result == DialogResult.No)
            {
                // Acción si se pulsa "No"
            }
        }

        private void llb_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fm_SignUp signupForm = new fm_SignUp();
            signupForm.ShowDialog(); 
        }

        private void fm_loggin_Load(object sender, EventArgs e)
        {

        }
    }
}
