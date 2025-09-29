using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_AdminAnimalMenu : Form
    {
        public fm_AdminAnimalMenu()
        {
            InitializeComponent();
        }

        private void btn_asignResp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AsignResp();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_AddNewAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_AddNewAnimal();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_ShowAllAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ShowAllAnimals();
            menuredir.ShowDialog();
            this.Show();

        }

        private void btn_AnimalModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ModifyAnimals();
            menuredir.ShowDialog();
            this.Show();

        }
    }
}
