using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsForms.BasicForms
{
    public partial class fm_SightingForm : Form
    {
        public fm_SightingForm()
        {
            InitializeComponent();
        }

        private void btn_SubmitReport_Click(object sender, EventArgs e)
        {
            bool valid = true;
            bool fechavalida = true;
            valid &= ValidateEmpty(tb_SightingAddress);
            valid &= ValidateEmpty(tb_SightingAddressNumber);
            valid &= ValidateEmpty(tb_SightingDescription);

            if (!valid)
            {
                MessageBox.Show("Por favor, completá todos los campos del formulario.");
                return;
            }
            if (!fechavalida) {
                MessageBox.Show("La fecha y hora ingresadas no son válidas");
            }

            if(valid && fechavalida)
            {

            }
        }

        private bool ValidateEmpty(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.MistyRose;
                return false;
            }
            else
            {
                txt.BackColor = SystemColors.Window;
                return true;
            }
        }

        public bool FechaHoraValida(MaskedTextBox mtb)
        {
            DateTime dt;
            return DateTime.TryParse(mtb.Text, out dt);
        }
    }
}
