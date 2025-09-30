using DTOs;
using Infrastructure.API;
using System.Net.Http.Json;
using WindowsForms.menuAdmin;
using WindowsForms.menuAdopter;
using WindowsForms.menuFosters;
using WindowsForms.menuVolunteer;

namespace WindowsForms.BasicForms
{
    public partial class fm_loggin : Form
    {

        private const string ApiBaseUrl = "https://localhost:7056/";

        public fm_loggin()
        {
            InitializeComponent();
            Session.LogOff();
        }

        private async void btn_loggin_Click(object sender, EventArgs e)
        {
            btn_loggin.Enabled = false;

            AuthClient authClient = ApiClientsFactory.AuthClient();
            var response = await authClient.LoginAsync(new UserLoginRequestDTO() { UserName = tb_user.Text, Password = tb_password.Text });
            if (response.Success && response.Data != null)
            {
                var token = response.Data.Token;
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("No se recibió el token. Abortando", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TokenBroker.SetToken(response.Data.Token);
                MessageBox.Show($"Bienvenido {response.Data.User.Name} {response.Data.User.SurName}", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form menuredir = response.Data.User.UserType switch
                {
                    "Admin" => new fm_AdminMenu(),
                    "Adoptante" => new fm_AdopterMenu(),
                    "Voluntario" => new fm_VolunteerMenu(),
                    "Transito" => new fm_FostersMenu(),
                    _ => null
                };

                if (menuredir != null)
                {
                    this.Hide();
                    menuredir.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(response.Message ?? "Usuario o contraseña incorrectos", "Error de login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            btn_loggin.Enabled = true;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }


        private void llb_singup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fm_SignUp signUpForm = new fm_SignUp();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void btn_ReportSighting_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_SightingForm redir = new fm_SightingForm();
            redir.ShowDialog();
            this.Show();
        }
    }
}
