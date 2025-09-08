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

namespace WindowsFormsApp1.menuAdmin.Users
{
    public partial class fm_ModifyUsers : Form
    {
        public fm_ModifyUsers()
        {
            InitializeComponent();
            Load += ModifyUserFormLoad;
        }

        private void ModifyUserFormLoad(object sender, EventArgs e)
        {
            dgv_User.AutoGenerateColumns = false;
            Shared.User WantedUser = UserService.Instance.GetByUserName(this.tb_getUsername.Text);
            dgv_User.Columns.Add("UserName", "Nombre de Usuario");
            dgv_User.Columns.Add("Name", "Nombre");
            dgv_User.Columns.Add("SurName", "Apellido");
            dgv_User.Columns.Add("DNI", "DNI");
            dgv_User.Columns.Add("Tipo Usuario", "Tipo Usuario");
            dgv_User.Columns["UserName"].DataPropertyName = "UserName";
            dgv_User.Columns["Name"].DataPropertyName = "Name";
            dgv_User.Columns["SurName"].DataPropertyName = "SurName";
            dgv_User.Columns["DNI"].DataPropertyName = "DNI";
            dgv_User.Columns["Tipo Usuario"].DataPropertyName = "UserType";
           

           
        }
        private void llb_ShowAllUsers_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fm_ShowAllUsers menuredir = new fm_ShowAllUsers();
            menuredir.ShowDialog();
            this.Close();
        }

        private void btn_AcceptUsn_Click(object sender, EventArgs e)
        {
            Shared.User WantedUser = UserService.Instance.GetByUserName(this.tb_getUsername.Text);
            
            if (WantedUser != null)
            {
                dgv_User.DataSource = new List<Shared.User> { WantedUser };
            }
            else
            {
                dgv_User.DataSource = new List<Shared.User>();
            }


            if ((UserService.Instance.GetByUserName(this.tb_getUsername.Text) == null))
            {
                string message = "El usuario no existe";
                string caption = "Error";
                MessageBox.Show(message, caption);
            }
            
            
        }

        private void btn_AcceptMod_Click(object sender, EventArgs e)
        {
            string message = "Se modificará el usuario seleccionado";
            string caption = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (dgv_User.DataSource is List<Shared.User> users && users.Count > 0)
                {
                    Shared.User userToModify = users[0];

                    // Actualizar los datos del usuario con los valores de los controles
                    userToModify.Name = tb_Name.Text;
                    userToModify.SurName = tb_SurName.Text;
                    userToModify.DNI = tb_DNI.Text;
                    userToModify.UserType = tb_UserType.Text;

                    // Guardar el usuario modificado
                    UserService.Instance.UpdateUser(userToModify);

                    MessageBox.Show("Usuario modificado correctamente.", "Éxito");
                }
            }
        }
            else if (result == DialogResult.No)
            {
            }

        }
    }
}
