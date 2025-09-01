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
            dgv_User.Columns["UserName"].DataPropertyName = "UserName";
            dgv_User.Columns["Name"].DataPropertyName = "Name";
            dgv_User.Columns["SurName"].DataPropertyName = "SurName";
            dgv_User.Columns["DNI"].DataPropertyName = "DNI";
           

            if (WantedUser != null)
            {
                dgv_User.DataSource = new List<Shared.User> { WantedUser };
            }
            else
            {
                dgv_User.DataSource = new List<Shared.User>();
            }
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

            if ((UserService.Instance.GetByUserName(this.tb_getUsername.Text) == null))
            {
                string message = "El usuario no existe";
                string caption = "Error";
                MessageBox.Show(message, caption);
            }
            
            
        }
    }
}
