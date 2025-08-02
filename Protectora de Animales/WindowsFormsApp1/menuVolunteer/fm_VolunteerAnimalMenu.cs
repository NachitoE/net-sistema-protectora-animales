using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BasicForms;

namespace WindowsFormsApp1.menuVolunteer
{
    public partial class fm_VolunteerAnimalMenu : Form
    {
        public fm_VolunteerAnimalMenu()
        {
            InitializeComponent();
        }

        private void btn_CaretakersAnimals_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            fm_CaretakersAnimals menuredir = new fm_CaretakersAnimals();
           menuredir.ShowDialog();
           this.show();*/
        }

        private void btn_AnimalsMedicalCheckup_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_AnimalsMedicalCheckUp menuredir = new fm_AnimalsMedicalCheckUp();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
