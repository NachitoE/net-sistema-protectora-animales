using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.menuAdopter
{
    public partial class fm_AdopterMenu : Form
    {
        public fm_AdopterMenu()
        {
            InitializeComponent();
        }

        private void btn_AnimalsCatalog_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_ShowAvailableAnimals menuredir = new fm_ShowAvailableAnimals();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
