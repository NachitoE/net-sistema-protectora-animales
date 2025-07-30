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
using Shared;


namespace WindowsFormsApp1
{
    public partial class fm_SignUp : Form
    {
        public fm_SignUp()
        {
            InitializeComponent();
        }

        private void btn_SingUpconfirm_Click(object sender, EventArgs e)
        {   
                bool valid = true;
                valid &= ValidateEmpty(tb_SignUpName);
                valid &= ValidateEmpty(tb_SignUpSurName);
                valid &= ValidateEmpty(tb_SignUpDni);
                valid &= ValidateEmpty(tb_SignUpUserName);
                valid &= ValidateEmpty(tb_SignUpPassword);
                valid &= ValidateEmpty(tb_SignUpPasswordCheck);
                valid &= cb_userType.Text != "";

            if (!valid)
                    MessageBox.Show("Por favor, completá todos los campos del formulario.");


                bool SamePassword = true;
                SamePassword = ValidatePasswordCheck(tb_SignUpPassword, tb_SignUpPasswordCheck);
                if (!SamePassword)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

             

            if(valid && SamePassword) {
                
                string userName = tb_SignUpUserName.Text;
                string password = tb_SignUpPassword.Text;
                string name = tb_SignUpName.Text;
                string surname = tb_SignUpSurName.Text;
                string dni = tb_SignUpDni.Text;
                User.Type userType = User.Type.Transito;
                switch (cb_userType.Text)
                {
                    case "Adoptante":
                        userType = User.Type.Adoptante;
                        break;
                    case "Voluntario":
                        userType = User.Type.Voluntario;
                        break;
                    case "Transito":
                        userType = User.Type.Transito;
                        break;
                    default:
                        MessageBox.Show("Por favor, selecciona un tipo de usuario válido.");
                        return;
                }

                if(UserService.Instance.UserNameExists(userName))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                    return;
                }
                var user = new User(Guid.NewGuid().ToString(), name, surname, dni, userType, userName, password); /// preguntar a nacho algo no cierra
                UserService.Instance.Save(user);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    }
    

