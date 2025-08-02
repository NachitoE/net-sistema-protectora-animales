using System.Windows.Forms;

namespace WindowsFormsApp1.menuFosters
{
    public partial class fm_FostersMenu : Form
    {
        public fm_FostersMenu()
        {
            InitializeComponent();
        }

        private void btn_menuAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_FosterAnimalMenu menuredir = new fm_FosterAnimalMenu();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_menuAdoptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_FosterAdoptionMenu menuredir = new fm_FosterAdoptionMenu();
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
    }
}
