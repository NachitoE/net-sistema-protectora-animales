using DTOs;
using System;
using System.Net.Http;
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
        private readonly HttpClient _httpClient;

        public fm_loggin()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };
        }

        private async void btn_loggin_Click(object sender, EventArgs e)
        {
            btn_loggin.Enabled = false;

            try
            {
                var request = new UserLoginRequestDTO
                {
                    UserName = tb_user.Text.Trim(),
                    Password = tb_password.Text
                };

                HttpResponseMessage httpResponse;
                try
                {
                    httpResponse = await _httpClient.PostAsJsonAsync("users/login", request);
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show($"No se pudo conectar con la API:\n{hre.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!httpResponse.IsSuccessStatusCode)
                {
                    
                    var body = await httpResponse.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error desde la API ({(int)httpResponse.StatusCode}): {httpResponse.ReasonPhrase}\n{body}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var response = await httpResponse.Content.ReadFromJsonAsync<UserLoginResponseDTO>();
                if (response == null)
                {
                    MessageBox.Show("Respuesta inválida de la API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (response.Success && response.User != null)
                {
                    MessageBox.Show($"Bienvenido {response.User.Name} {response.User.SurName}", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form menuredir = response.User.UserType switch
                    {
                        "Admin" => new fm_AdminMenu(),
                        "Adoptante" => new fm_AdopterMenu(),
                        "Voluntario" => new fm_VolunteerAdoptionMenu(),
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_loggin.Enabled = true;
            }
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                _httpClient?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void tb_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
