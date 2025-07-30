using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.menusAdmin;

namespace WindowsFormsApp1
{
    public partial class fm_AdminMenu : Form
    {
        public fm_AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_menuVolunteers_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminVolunteersmenu menuredir = new fm_AdminVolunteersmenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuFosters_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdminFostersMenu menuredir = new fm_AdminFostersMenu();
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
            fm_AdminSightingMenu menuredir = new fm_AdminSightingMenu();
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
