using Azure.Core;
using DTOs;
using DTOs.User;
using Services;
using Infrastructure.API;

namespace WindowsForms.BasicForms
{
    public partial class fm_SignUp : Form
    {
        public fm_SignUp()
        {
            InitializeComponent();
        }

        private async void btn_ConfirmSU_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateEmpty(tb_SUName);
            valid &= ValidateEmpty(tb_SUSurname);
            valid &= ValidateEmpty(tb_SUDni);
            valid &= ValidateEmpty(tb_SUUsername);
            valid &= ValidateEmpty(tb_SUPassword);
            valid &= ValidateEmpty(tb_SUPasswordCheck);
            valid &= cb_UserType.Text != "";

            if (!valid)
                MessageBox.Show("Por favor, completá todos los campos del formulario.");


            bool SamePassword = true;
            SamePassword = ValidatePasswordCheck(tb_SUPassword, tb_SUPasswordCheck);
            if (!SamePassword)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

            if (valid && SamePassword)
            {
                var request = new UserRegisterRequestDTO
                {
                    Name = tb_SUName.Text,
                    SurName = tb_SUSurname.Text,
                    DNI = tb_SUDni.Text,
                    UserType = cb_UserType.Text,
                    UserName = tb_SUUsername.Text,
                    Password = tb_SUPassword.Text
                };

                if (request.UserType == "Transito")
                {
                    fm_HouseLoad houseLoadForm = new fm_HouseLoad();
                    if (houseLoadForm.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show("Debe completar la carga de la casa.");
                        return;
                    }

                    var houseRequest = houseLoadForm.GetHouseDTO();
                    var transitoRequest = new TransitoRegisterRequestDTO
                    {
                        Name = request.Name,
                        SurName = request.SurName,
                        DNI = request.DNI,
                        UserName = request.UserName,
                        Password = request.Password,
                        House = houseRequest
                    };

                    var transitoService = new TransitoClient();
                    var resp = await transitoService.RegisterAsync(transitoRequest);
                }
                    var authService = new AuthServiceClient();

                
                var response = await authService.RegisterAsync(request);
                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                    return;
                }

                
                

                MessageBox.Show("Usuario creado.");
                this.Hide();
            }
        }


        private bool ValidateEmpty(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.MistyRose;
                return false;
            }
            else
            {
                txt.BackColor = SystemColors.Window;
                return true;
            }
        }

        private bool ValidatePasswordCheck(TextBox txt, TextBox txt2)
        {
            if (txt.Text != txt2.Text)
            {
                txt.BackColor = Color.MistyRose;
                txt2.BackColor = Color.MistyRose;
                return false;
            }
            else
            {
                txt.BackColor = SystemColors.Window;
                txt2.BackColor = SystemColors.Window;
                return true;
            }
        }
    }
}
