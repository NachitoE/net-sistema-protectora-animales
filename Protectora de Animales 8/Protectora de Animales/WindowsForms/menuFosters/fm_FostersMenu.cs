using WindowsForms.BasicForms;
using WindowsForms.menuFoster;

namespace WindowsForms.menuFosters
{
    public partial class fm_FostersMenu : Form
    {
        public fm_FostersMenu()
        {
            InitializeComponent();
        }

        private void btn_menuAdoptions_Click(object sender, EventArgs e)
        {
           this.Hide();
            var menuredir= new fm_FosterAdoptionMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_FosterAnimalMenu();
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
