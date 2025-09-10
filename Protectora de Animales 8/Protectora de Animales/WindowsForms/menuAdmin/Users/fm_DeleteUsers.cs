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

namespace WindowsForms.menuAdmin.Users
{
    public partial class fm_DeleteUsers : Form
    {
        public fm_DeleteUsers()
        {
            InitializeComponent();
            Load += DeleteUserFormLoad;
        }

        private void DeleteUserFormLoad(object sender, EventArgs e)
        {
            dgv_User.AutoGenerateColumns = false;
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

        private void llb_ShowAllUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fm_ShowAllUsers menuredir = new fm_ShowAllUsers();
            menuredir.ShowDialog();
            this.Close();
        }

        private void btnAcceptDelete_Click(object sender, EventArgs e)
        {
            string message = "Se eliminará el usuario seleccionado¿Desea continuar?";
            string caption = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                Shared.User WantedUser = UserService.Instance.GetByUserName(this.tb_getUsername.Text);
            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}
