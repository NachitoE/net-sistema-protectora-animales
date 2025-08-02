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

        private void btn_AdoptionFollowing_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_ShowAdoptionProgress menuredir = new fm_ShowAdoptionProgress();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_AdopterInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AdopterRequisites menuredir = new fm_AdopterRequisites();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
