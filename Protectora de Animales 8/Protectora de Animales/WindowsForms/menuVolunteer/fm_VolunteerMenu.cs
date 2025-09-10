using System.Windows.Forms;
using WindowsForms.BasicForms;

namespace WindowsForms.menuVolunteer
{
    public partial class fm_VolunteerMenu : Form
    {
        public fm_VolunteerMenu()
        {
            InitializeComponent();
        }

        private void btn_menuAnimals_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_VolunteerAnimalMenu menuredir = new fm_VolunteerAnimalMenu();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
