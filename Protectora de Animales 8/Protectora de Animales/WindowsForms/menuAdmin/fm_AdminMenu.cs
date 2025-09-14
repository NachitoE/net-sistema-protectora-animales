using System;
using System.Windows.Forms;
using WindowsForms.menusAdmin;

namespace WindowsFormsApp1
{
    public partial class fm_AdminMenu : Form
    {
        public fm_AdminMenu()
        {
            InitializeComponent();
        }

        

        private void btn_menuUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminUsersMenu menuredir = new fm_AdminUsersMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminReportsMenu menuredir = new fm_AdminReportsMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuSightings_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_SightingMenu menuredir = new fm_SightingMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuAdoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminAdoptionMenu menuredir = new fm_AdminAdoptionMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_AnimalsMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminAnimalMenu menuredir = new fm_AdminAnimalMenu();
            menuredir.ShowDialog();
            this.Show();
        }

    }
}
