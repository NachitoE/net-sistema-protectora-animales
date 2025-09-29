using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.menuAdmin.Animals;

namespace WindowsForms.menuAdmin.Users
{
    public partial class fm_AdminUsersMenu : Form
    {
        public fm_AdminUsersMenu()
        {
            InitializeComponent();
        }

        private void btn_ModifyUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ModifyUsers();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_DeleteUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_DeleteUsers();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_ShowAllUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ShowAllUsers();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
