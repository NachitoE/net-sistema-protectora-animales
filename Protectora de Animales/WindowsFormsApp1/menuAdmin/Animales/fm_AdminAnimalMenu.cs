using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.menuAdmin.Animales;

namespace WindowsFormsApp1
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
            fm_AsignResp menuredir = new fm_AsignResp();
            menuredir.ShowDialog();
            this.Show();

        }

        private void btn_AddNewAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AddNewAnimal menuredir = new fm_AddNewAnimal();
            menuredir.ShowDialog();
            this.Show();
        }

        private void btn_ShowAllAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_ShowAllAnimals menuredir = new fm_ShowAllAnimals();
            menuredir.ShowDialog();
            this.Show();
        }

        private void fm_AdminAnimalMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
