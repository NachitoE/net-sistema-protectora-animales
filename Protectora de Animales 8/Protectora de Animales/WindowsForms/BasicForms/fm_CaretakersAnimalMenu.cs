using WindowsForms.BasicForms;
using WindowsForms.NewFolder1;

namespace WindowsForms.menuFoster
{
    public partial class fm_CaretakersAnimalMenu : Form
    {
        public fm_CaretakersAnimalMenu()
        {
            InitializeComponent();
        }

        private void btn_CaretakersAnimals_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_CaretakersAnimals menuredir = new fm_CaretakersAnimals();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_AnimalsMedicalCheckup_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            fm_AnimalsMedicalCheckUp menuredir = new fm_AnimalsMedicalCheckUp();
            menuredir.ShowDialog();
            this.Show();
        }

    }
}
