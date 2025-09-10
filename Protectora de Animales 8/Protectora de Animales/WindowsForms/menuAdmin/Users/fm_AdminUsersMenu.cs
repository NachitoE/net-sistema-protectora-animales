using System.Windows.Forms;
using WindowsForms.menuAdmin.Users;

namespace WindowsForms.menusAdmin
{
    public partial class fm_AdminUsersMenu : Form
    {
        public fm_AdminUsersMenu()
        {
            InitializeComponent();
        }

        private void btn_ShowAllUsers_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_ShowAllUsers menuredir = new fm_ShowAllUsers();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_ModifyUsers_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_ModifyUsers menuredir = new fm_ModifyUsers();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_DeleteUsers_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_DeleteUsers menuredir = new fm_DeleteUsers();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
