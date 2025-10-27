using WindowsForms.BasicForms;
using WindowsForms.menuFoster;

namespace WindowsForms.menuVolunteer
{
    public partial class fm_VolunteerMenu : Form
    {
        public fm_VolunteerMenu()
        {
            InitializeComponent();
        }

        private void btn_menuAdoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ManageAdoptions();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_CaretakersAnimalMenu();
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
    }
}
