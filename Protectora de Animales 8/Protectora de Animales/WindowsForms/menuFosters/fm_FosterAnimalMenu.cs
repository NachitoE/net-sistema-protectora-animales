using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.NewFolder1;

namespace WindowsForms.menuFoster
{
    public partial class fm_FosterAnimalMenu : Form
    {
        public fm_FosterAnimalMenu()
        {
            InitializeComponent();
        }

        private void btn_CaretakersAnimals_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir= new fm_CaretakersAnimals();
        }
    }
}
