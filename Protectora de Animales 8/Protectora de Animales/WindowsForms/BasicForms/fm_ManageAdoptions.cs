using DTOs;
using DTOs.Adoption;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.BasicForms
{
    public partial class fm_ManageAdoptions : Form
    {
        private List<AdoptionDTO>? _adoptions;
        private Dictionary<string, string> _usersDict = new();
        private Dictionary<string, string> _animalsDict = new();

        public fm_ManageAdoptions()
        {
            InitializeComponent();
            Load += async (_, _) => await LoadData();

            btn_filterAccepted.Click += (_, _) => FilterAdoptions("Aprobada");
            btn_RejectedAdoptions.Click += (_, _) => FilterAdoptions("Rechazada");
            btn_awaitingAdoptions.Click += (_, _) => FilterAdoptions("Pendiente");
            btn_ShowAll.Click += (_, _) => FilterAdoptions(null);

            btn_Accept.Click += async (_, _) => await ApproveSelected();
            btn_reject.Click += async (_, _) => await RejectSelected();
        }

        private async Task LoadData()
        {
            try
            {
                var adoptionClient = ApiClientsFactory.AdoptionClient();
                var userClient = ApiClientsFactory.UserClient();
                var animalClient = ApiClientsFactory.AnimalClient();


                var adoptionResult = await adoptionClient.GetAllAsync();
                if (!adoptionResult.Success || adoptionResult.Data == null)
                {
                    MessageBox.Show($"Error al cargar adopciones: {adoptionResult.Message}");
                    return;
                }
                _adoptions = adoptionResult.Data.ToList();


                var users = await userClient.GetAllAsync();
                var animals = await animalClient.GetAllAsync();
                _usersDict = users.Data?.ToDictionary(u => u.Id, u => $"{u.Name} {u.SurName}") ?? new();
                _animalsDict = animals.Data?.ToDictionary(a => a.Id, a => a.Name) ?? new();

                DisplayAdoptions(_adoptions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void DisplayAdoptions(List<AdoptionDTO> adoptions)
        {
            var table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Usuario");
            table.Columns.Add("Animal");
            table.Columns.Add("Fecha Solicitud");
            table.Columns.Add("Fecha Respuesta");
            table.Columns.Add("Estado");
            table.Columns.Add("Descripción");

            foreach (var adoption in adoptions)
            {
                table.Rows.Add(
                    adoption.Id,
                    _usersDict.GetValueOrDefault(adoption.UserId, "Desconocido"),
                    _animalsDict.GetValueOrDefault(adoption.AnimalId, "Desconocido"),
                    adoption.AdoptionRequestDate.ToString("yyyy-MM-dd"),
                    adoption.AdoptionResponseDate?.ToString("yyyy-MM-dd") ?? "",
                    adoption.State,
                    adoption.Description
                );
            }

            dgv_Manage_Adoptions.DataSource = table;

            dgv_Manage_Adoptions.Columns["Id"].ReadOnly = true;
            dgv_Manage_Adoptions.Columns["Usuario"].ReadOnly = true;
            dgv_Manage_Adoptions.Columns["Animal"].ReadOnly = true;
            dgv_Manage_Adoptions.Columns["Fecha Solicitud"].ReadOnly = true;
            dgv_Manage_Adoptions.Columns["Fecha Respuesta"].ReadOnly = true;


            dgv_Manage_Adoptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Manage_Adoptions.Columns["Descripción"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Manage_Adoptions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            foreach (DataGridViewRow row in dgv_Manage_Adoptions.Rows)
            {
                var state = row.Cells["Estado"].Value?.ToString();
                if (state == "Pendiente") row.Cells["Estado"].Style.BackColor = Color.Yellow;
                else if (state == "Aprobada") row.Cells["Estado"].Style.BackColor = Color.LightGreen;
                else if (state == "Rechazada") row.Cells["Estado"].Style.BackColor = Color.IndianRed;
            }
        }

        private void FilterAdoptions(string? state)
        {
            if (_adoptions == null) return;
            if (state == null) DisplayAdoptions(_adoptions);
            else DisplayAdoptions(_adoptions.Where(a => a.State == state).ToList());
        }

        private AdoptionDTO? GetSelectedAdoption()
        {
            if (dgv_Manage_Adoptions.SelectedRows.Count == 0) return null;
            var id = dgv_Manage_Adoptions.SelectedRows[0].Cells["Id"].Value?.ToString();
            return _adoptions?.FirstOrDefault(a => a.Id == id);
        }

        private async Task ApproveSelected()
        {
            var selected = GetSelectedAdoption();
            if (selected == null || selected.State != "Pendiente") return;

            var dto = new AdoptionRejectApproveDTO
            {
                Approved = true,
                AdoptionResponseDate = DateTime.Now
            };

            var result = await ApiClientsFactory.AdoptionClient().ApproveOrRejectPendingAsync(selected.Id, dto);
            if (!result.Success)
                MessageBox.Show($"Error al aprobar: {result.Message}");
            else
                MessageBox.Show("Adopción aprobada");

            await LoadData();
        }

        private async Task RejectSelected()
        {
            var selected = GetSelectedAdoption();
            if (selected == null || selected.State != "Pendiente") return;

            var dto = new AdoptionRejectApproveDTO
            {
                Approved = false,
                AdoptionResponseDate = DateTime.Now
            };

            var result = await ApiClientsFactory.AdoptionClient().ApproveOrRejectPendingAsync(selected.Id, dto);
            if (!result.Success)
                MessageBox.Show($"Error al rechazar: {result.Message}");
            else
                MessageBox.Show("Adopción rechazada");

            await LoadData();
        }

    }
}