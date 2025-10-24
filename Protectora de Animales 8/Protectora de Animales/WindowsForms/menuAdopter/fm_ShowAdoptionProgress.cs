using DTOs;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms.menuAdopter
{
    public partial class fm_ShowAdoptionProgress : Form
    {
        private readonly AdoptionDTOClient _adoptionClient;
        private readonly AuthClient _authClient;

        private List<AdoptionDTO>? _myAdoptions;
        private Dictionary<string, string> _animalsDict = new();

        public fm_ShowAdoptionProgress()
        {
            InitializeComponent();
            _adoptionClient = ApiClientsFactory.AdoptionClient();
            _authClient = ApiClientsFactory.AuthClient();

            dgv_UsersAdoption.ReadOnly = true;
            dgv_UsersAdoption.AllowUserToAddRows = false;
            dgv_UsersAdoption.AllowUserToDeleteRows = false;
            dgv_UsersAdoption.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_UsersAdoption.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_UsersAdoption.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_UsersAdoption.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Load += async (_, _) => await LoadAdoptions();
        }

        private async Task LoadAdoptions()
        {
            try
            {

                var userResponse = await _authClient.MeAsync();
                if (!userResponse.Success || userResponse.Data == null)
                {
                    MessageBox.Show("No se pudo obtener el usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var currentUser = userResponse.Data;


                var adoptionResponse = await _adoptionClient.GetAllAsync();
                if (!adoptionResponse.Success || adoptionResponse.Data == null)
                {
                    MessageBox.Show("No se pudieron obtener las adopciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                _myAdoptions = adoptionResponse.Data
                    .Where(a => a.UserId == currentUser.Id)
                    .OrderByDescending(a => a.State)
                    .ToList();


                var animalClient = ApiClientsFactory.AnimalClient();
                var animalsResponse = await animalClient.GetAllAsync();
                _animalsDict = animalsResponse.Data?.ToDictionary(a => a.Id, a => a.Name) ?? new();

                DisplayAdoptions(_myAdoptions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar adopciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAdoptions(List<AdoptionDTO> adoptions)
        {
            var table = new DataTable();
            table.Columns.Add("Animal");
            table.Columns.Add("Estado");
            table.Columns.Add("Motivo");
            table.Columns.Add("Fecha de Solicitud");
            table.Columns.Add("Fecha de Respuesta");

            foreach (var adoption in adoptions)
            {
                var animalName = _animalsDict.GetValueOrDefault(adoption.AnimalId, "(Desconocido)");
                table.Rows.Add(
                    animalName,
                    adoption.State,
                    adoption.Description,
                    adoption.AdoptionRequestDate.ToString("dd/MM/yyyy"),
                    adoption.AdoptionResponseDate?.ToString("dd/MM/yyyy") ?? ""
                );
            }

            dgv_UsersAdoption.DataSource = table;

            
            foreach (DataGridViewRow row in dgv_UsersAdoption.Rows)
            {
                var state = row.Cells["Estado"].Value?.ToString();
                if (state == "Pendiente") row.Cells["Estado"].Style.BackColor = Color.Khaki;
                else if (state == "Aprobada") row.Cells["Estado"].Style.BackColor = Color.LightGreen;
                else if (state == "Rechazada") row.Cells["Estado"].Style.BackColor = Color.LightCoral;
            }
        }
    }
}