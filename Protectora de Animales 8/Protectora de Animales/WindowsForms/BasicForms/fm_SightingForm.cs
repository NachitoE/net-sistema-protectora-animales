
using DTOs.Sighting;
using Infrastructure.API;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WindowsForms.BasicForms
{
    public partial class fm_SightingForm : Form
    {
        private const string ApiBaseUrl = "https://localhost:7056/";
        private readonly HttpClient _httpClient;
        public fm_SightingForm()
        {

            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri(ApiBaseUrl) };

        }

        private async void btn_SubmitReport_Click(object sender, EventArgs e)
        {
            bool valid = true;
            bool fechavalida = true;
            valid &= ValidateEmpty(tb_SightingAddress);
            valid &= ValidateEmpty(tb_SightingAddressNumber);
            valid &= ValidateEmpty(tb_SightingDescription);
            fechavalida = FechaHoraValida(mtb_SightingTime, out DateTime sightingDate);

            if (!valid)
            {
                MessageBox.Show("Por favor, completá todos los campos del formulario.");
                return;
            }
            if (!fechavalida)
            {
                MessageBox.Show("La fecha y hora ingresadas no son válidas");
            }

            if (valid && fechavalida)
            {
                var request = new SightingRegisterDTO
                {
                    SightingAddressName = tb_SightingAddress.Text,
                    SightingAddressNumber = tb_SightingAddressNumber.Text,
                    SightingDescription = tb_SightingDescription.Text,
                    SightingDateTime = DateTime.Parse(mtb_SightingTime.Text)
                };
                try
                {
                    using var apiClient = new APIHttpClient(ApiBaseUrl);

                    var created = await apiClient.PostAsync<SightingDTO>("sightings", request);

                    MessageBox.Show($"Avistamiento guardado con éxito. ID: {created.Id}");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el avistamiento: " + ex.Message);
                }
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

        public bool FechaHoraValida(MaskedTextBox mtb, out DateTime fecha)
        {
            bool valido = DateTime.TryParse(mtb.Text, out fecha);

         
            if (valido)
            {
                if (fecha < DateTime.Now)
                {
                    valido = false;
                }
            }

            return valido;
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Ejemplo de descripción:\n\n" +
    "Perro pequeño con manchas en la espalda vagando solo por la calle.\n" +
    "Sociable, parece perdido, retienen en... estaba entre...\n" +
    "Toda descripción que recuerde nos es de ayuda.",
    "Ayuda",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information
);
        }
    }
}
