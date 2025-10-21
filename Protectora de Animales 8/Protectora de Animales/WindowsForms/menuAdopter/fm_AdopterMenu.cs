using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.menuAdopter
{
    public partial class fm_AdopterMenu : Form
    {
        public fm_AdopterMenu()
        {
            InitializeComponent();
        }

        private void btn_AdopterInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_NewAdoptionRequest();
            menuredir.ShowDialog();
            this.Show();

        }

        private void btn_AdoptionFollowing_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ShowAdoptionProgress();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_AdopterAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ShowAvailableAnimals();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
