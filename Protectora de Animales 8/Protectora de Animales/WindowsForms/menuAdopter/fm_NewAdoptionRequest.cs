using DTOs;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.menuAdopter
{
    public partial class fm_NewAdoptionRequest : Form
    {
        private readonly AnimalDTOClient _animalClient;
        private readonly AdoptionDTOClient _adoptionClient;

        public fm_NewAdoptionRequest()
        {
            InitializeComponent();
            _animalClient = ApiClientsFactory.AnimalClient();
            _adoptionClient = ApiClientsFactory.AdoptionClient();
        }

        private async void btn_AcceptAdoption_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_AnimalName.Text) ||
                cbb_AnimalSpecie.SelectedItem == null ||
                string.IsNullOrWhiteSpace(tb_AdoptionMotive.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de continuar.",
                                "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (foundAnimal == null|| (foundAnimal.Name != criteria.Name && foundAnimal.Species != criteria.Species) )
                {
                    MessageBox.Show("No se encontró ningún animal con ese nombre y especie.",
                                    "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var requisitesForm = new fm_AdopterRequisites())
                {
                    if (requisitesForm.ShowDialog() == DialogResult.OK)
                    {
                        var confirm = MessageBox.Show(
                            $"¿Desea enviar la solicitud de adopción?\n\n" +
                            $" Animal: {foundAnimal.Name}\n" +
                            $" Especie: {foundAnimal.Species}\n" +
                            $" Motivo: {tb_AdoptionMotive.Text.Trim()}",
                            "Confirmar adopción",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirm == DialogResult.Yes)
                        {
                            var adoptionDto = new AdoptionRequestDTO
                            {
                                AnimalId = foundAnimal.Id,
                                Description = tb_AdoptionMotive.Text.Trim(),
                                AdoptionRequestDate = DateTime.Now
                            };

                            var postResult = await _adoptionClient.PostAsync(adoptionDto);

                            if (postResult.Success)
                            {
                                MessageBox.Show("Solicitud de adopción enviada con éxito ",
                                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show(postResult.Message ?? "No se pudo registrar la solicitud de adopción.",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llb_ShowAnimals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ShowAvailableAnimals();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}