using System;
using System.Windows.Forms;
using DTOs;
using Infrastructure.API;
using Services;
using WindowsForms.menuAdopter;
using WindowsForms.menuFosters;
using WindowsForms.menuVolunteer;

namespace WindowsForms
{
    public partial class fm_loggin : Form
    {
        public fm_loggin()
        {
            InitializeComponent();
        }

      


        private async void btn_loggin_Click(object sender, EventArgs e)
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
            UserDTOClient userClient = new UserDTOClient(new APIHttpClient());
            AuthClient authClient = new AuthClient(new APIHttpClient());
            UserDTO? loggingUser = await authClient.LoginAsync(new UserLoginRequestDTO(this.tb_user.Text, this.tb_password.Text));
            if (loggingUser == null)
            {
                string message = "Usuario o contraseña incorrectos";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                SendMessage(message, caption, buttons);
                return;
            }
            //NACHO TODO: Save user on a singleton or something
                //NACHO TODO: maybe move types to another place? (type safety)
            if (loggingUser.UserType == "Admin") {
                this.Hide();
                fm_AdminMenu menuForm = new fm_AdminMenu();
                //menuForm.show();
                this.Show();
            }
            if(logUser.UserType == Domain.User.Type.Voluntario)
            {
                this.Hide();
                fm_VolunteerMenu menuForm = new fm_VolunteerMenu();
                menuForm.ShowDialog();
                this.Show();
            }
            if (logUser.UserType == Domain.User.Type.Adoptante)
            {
                this.Hide();
                fm_AdopterMenu menuForm = new fm_AdopterMenu();
                menuForm.ShowDialog();
                this.Show();
            }
            if(logUser.UserType == Domain.User.Type.Transito)
            {
                this.Hide();
                fm_FostersMenu menuForm = new fm_FostersMenu();
                menuForm.ShowDialog();
                this.Show();
            }


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
