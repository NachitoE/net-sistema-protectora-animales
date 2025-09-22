using DTOs.House;
using Services;


namespace WindowsForms.BasicForms
{
    public partial class fm_HouseLoad : Form
    {
        String userId;
        public fm_HouseLoad(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private async void btn_ConfirmHouse_Click(object sender, EventArgs e)
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

            var request = new HouseRegisterRequestDTO
            {
                UserId = userId,
                Address = tb_HouseStreet.Text,
                AddressNumber = int.Parse(tb_Houseumber.Text),
                Capacity = (int)nud_HouseCapacity.Value
            };
            var _houseService = new HouseServiceClient();
            var response = await _houseService.RegisterAsync(request);

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Nueva casa agregada exitosamente.");
            this.Close();
        
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
            if (numericUpDown.Value ==0 || numericUpDown.Value >10  )
                return false;
            
            else
            {
                numericUpDown.BackColor = SystemColors.Window;
                return true;
            }
        }

    }
}
