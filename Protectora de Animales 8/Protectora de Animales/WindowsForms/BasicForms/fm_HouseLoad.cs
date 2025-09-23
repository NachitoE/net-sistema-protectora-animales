using DTOs.House;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms.BasicForms
{
    public partial class fm_HouseLoad : Form
    {
        public fm_HouseLoad()
        {
            InitializeComponent();
        }

        private void btn_ConfirmHouse_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateEmpty(tb_HouseStreet);
            valid &= ValidateEmpty(tb_Houseumber);
            valid &= ValidNumber(nud_HouseCapacity);

            if (!valid)
            {
                MessageBox.Show("Por favor, completá todos los campos del formulario.");
                return;
            }

            // No llamamos a la API aquí, solo cerramos el form con OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public HouseRegisterRequestDTO GetHouseRegDTO()
        {
            return new HouseRegisterRequestDTO
            {
                Address = tb_HouseStreet.Text,
                AddressNumber = int.TryParse(tb_Houseumber.Text, out var num) ? num : 0,
                Capacity = (int)nud_HouseCapacity.Value
            };
        }

        private bool ValidateEmpty(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = Color.LightCoral;
                return false;
            }
            else
            {
                textBox.BackColor = SystemColors.Window;
                return true;
            }
        }

        private bool ValidNumber(NumericUpDown numericUpDown)
        {
            numericUpDown.BackColor = Color.LightCoral;
            if (numericUpDown.Value == 0 || numericUpDown.Value > 10)
                return false;

            numericUpDown.BackColor = SystemColors.Window;
            return true;
        }
    }
}