using DTOs;
using Infrastructure.API;
using Infrastructure.API.DTOs_CRUDs;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms.BasicForms
{
    public partial class fm_AddMedicalCheckup : Form
    {
        private readonly AnimalDTOClient _animalClient;
        private readonly MedicalCheckUpDTOClient _medicalCheckupClient;
        private readonly AuthClient _authClient;

        public fm_AddMedicalCheckup()
        {
            InitializeComponent();
            _animalClient = ApiClientsFactory.AnimalClient();
            _medicalCheckupClient = ApiClientsFactory.MedicalCheckUpClient();
        }

        private async void btn_AcceptMC_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tb_AnimalName.Text) ||
                cbb_AnimalSpecie.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tb_MCFeedback.Text) ||
                dtp_CheckupDate.Value == default)
            {
                MessageBox.Show("Debe completar todos los campos antes de continuar.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var checkDate = dtp_CheckupDate.Value.Date;
            if (checkDate > DateTime.Today)
            {
                MessageBox.Show("La fecha del chequeo no puede ser futura.",
                                "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkDate < DateTime.Today.AddYears(-10))
            {
                MessageBox.Show("El chequeo no puede tener más de 10 años de antigüedad.",
                                "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                var criteria = new AnimalDTO
                {
                    Name = tb_AnimalName.Text.Trim(),
                    Species = cbb_AnimalSpecie.SelectedItem.ToString()
                };

                var result = await _animalClient.SearchAsync(criteria);
                if (!result.Success)
                {
                    MessageBox.Show(result.Message ?? "Error al buscar el animal.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var foundAnimal = result.Data?.FirstOrDefault();
                if (foundAnimal == null)
                {
                    MessageBox.Show("No se encontró ningún animal con ese nombre y especie.",
                                    "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                var confirm = MessageBox.Show(
                    $"¿Es correcta esta información?\n\n" +
                    $" Animal: {foundAnimal.Name}\n" +
                    $" Especie: {foundAnimal.Species}\n" +
                    $" Fecha del chequeo: {checkDate:dd/MM/yyyy}\n" +
                    $" Observaciones: {tb_MCFeedback.Text.Trim()}",
                    "Confirmar Chequeo Médico",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

       
                var medicalCheckupDto = new MedicalCheckUpRegisterDTO
                {
                    AnimalId = foundAnimal.Id,
                    CheckUpDate = checkDate,
                    Observation = tb_MCFeedback.Text.Trim()
                };

                var postResult = await _medicalCheckupClient.PostAsync(medicalCheckupDto);

                if (postResult.Success)
                {
                    MessageBox.Show("Chequeo médico registrado con éxito.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show(postResult.Message ?? "No se pudo registrar el chequeo médico.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
