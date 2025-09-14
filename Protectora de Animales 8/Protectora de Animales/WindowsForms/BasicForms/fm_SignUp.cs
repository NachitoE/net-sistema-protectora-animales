using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Services;
using Domain;
using WindowsForms.BasicForms;


namespace WindowsForms
{
    public partial class fm_SignUp : Form
    {
        private readonly Dictionary<string, User.Type> _userTypeDict = new Dictionary<string, User.Type>()
        {
            { "Adoptante", User.Type.Adoptante },
            { "Voluntario", User.Type.Voluntario },
            { "Transito", User.Type.Transito }
        };
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
                User.Type userType = _userTypeDict[cb_userType.Text];


                if (UserService.Instance.UserNameExists(userName))
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elige otro.");
                    return;
                }
                string userId = Guid.NewGuid().ToString(); 
                User user = new User(userId, name, surname, dni, userType, userName, password);


                if(userType== User.Type.Transito)
                {
                    fm_HouseLoad houseLoadForm = new fm_HouseLoad(userId);
                    houseLoadForm.ShowDialog();
                    // Verifica si el usuario completó la carga de la casa sino, vuelve a pedir la carga
                    if (houseLoadForm.DialogResult != DialogResult.OK)
                    {
                        MessageBox.Show("Debe completar la carga de la casa para finalizar el registro.");
                        return;

                    }
                    if(houseLoadForm.DialogResult == DialogResult.OK)
                        UserService.Instance.Save(user);

                }
               if (userType != User.Type.Transito)
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

       
    }

    }
    

