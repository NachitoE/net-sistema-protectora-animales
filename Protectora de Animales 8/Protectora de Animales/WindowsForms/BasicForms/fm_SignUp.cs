using DTOs;
using DTOs.User;
using Services;
using Infrastructure.API.Clients;
using System;
using System.Drawing;
using System.Windows.Forms;

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
            {
                MessageBox.Show("Por favor, completá todos los campos del formulario.");
                return;
            }

            if (!ValidatePasswordCheck(tb_SUPassword, tb_SUPasswordCheck))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            var userType = cb_UserType.Text;

            if (userType == "Transito")
            {
                // Abrimos form de la casa
                fm_HouseLoad houseForm = new fm_HouseLoad();
                if (houseForm.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Debe completar la carga de la casa.");
                    return;
                }

                var houseDto = houseForm.GetHouseDTO();

                var transitoRequest = new TransitoRegisterRequestDTO
                {
                    Name = tb_SUName.Text,
                    SurName = tb_SUSurname.Text,
                    DNI = tb_SUDni.Text,
                    UserName = tb_SUUsername.Text,
                    Password = tb_SUPassword.Text,
                    Address = houseDto.Address,
                    AddressNumber = houseDto.AddressNumber,
                    Capacity = houseDto.Capacity
                };

                var transitoService = new TransitoClient();
                var response = await transitoService.RegisterAsync(transitoRequest);

                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                    return;
                }

                MessageBox.Show("Transito y casa registrados exitosamente.");
                this.Hide();
                return;
            }

            // Si no es tránsito, registramos usuario normal
            var userRequest = new UserRegisterRequestDTO
            {
                Name = tb_SUName.Text,
                SurName = tb_SUSurname.Text,
                DNI = tb_SUDni.Text,
                UserType = userType,
                UserName = tb_SUUsername.Text,
                Password = tb_SUPassword.Text
            };

            var authService = new AuthServiceClient();
            var authResponse = await authService.RegisterAsync(userRequest);

            if (!authResponse.Success)
            {
                MessageBox.Show(authResponse.Message);
                return;
            }

            MessageBox.Show("Usuario creado exitosamente.");
            this.Hide();
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
