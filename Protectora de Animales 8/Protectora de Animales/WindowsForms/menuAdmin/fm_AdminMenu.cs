using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.BasicForms;
using WindowsForms.menuAdmin.Animals;
using WindowsForms.menuAdmin.Houses;
using WindowsForms.menuAdmin.Users;

namespace WindowsForms.menuAdmin
{
    public partial class fm_AdminMenu : Form
    {
        public fm_AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_menuAdoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AdminAdoptionMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AdminAnimalMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuSightings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_SightingMenu();
            menuredir.ShowDialog();
            this.Show();

        }

        private void btn_menuReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AdminReportsMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AdminUsersMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_FosterHouses_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_HouseChangeCapacity();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
