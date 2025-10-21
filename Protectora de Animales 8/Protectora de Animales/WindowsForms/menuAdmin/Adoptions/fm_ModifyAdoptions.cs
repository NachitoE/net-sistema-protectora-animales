using DTOs;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.menuAdmin.Adoptions
{
    public partial class fm_ModifyAdoptions : Form
    {
        private List<AdoptionDTO>? _adoptions;

        public fm_ModifyAdoptions()
        {
            InitializeComponent();
            Load += async (_, _) => await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                var adoptionClient = ApiClientsFactory.AdoptionClient();
                var userClient = ApiClientsFactory.UserClient();
                var animalClient = ApiClientsFactory.AnimalClient();

                var result = await adoptionClient.GetAllAsync();
                if (!result.Success || result.Data == null)
                {
                    MessageBox.Show($"Error al cargar adopciones: {result.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _adoptions = result.Data.ToList();

                var users = await userClient.GetAllAsync();
                var animals = await animalClient.GetAllAsync();

                var userDict = users.Data?.ToDictionary(u => u.Id, u => $"{u.Name} {u.SurName}") ?? new();
                var animalDict = animals.Data?.ToDictionary(a => a.Id, a => a.Name) ?? new();

                var table = new DataTable();
                table.Columns.Add("Id");
                table.Columns.Add("Usuario");
                table.Columns.Add("Animal");
                table.Columns.Add("Fecha Solicitud");
                table.Columns.Add("Fecha Respuesta");
                table.Columns.Add("Estado");
                table.Columns.Add("Descripción");

                foreach (var adoption in _adoptions)
                {
                    table.Rows.Add(
                        adoption.Id,
                        userDict.GetValueOrDefault(adoption.UserId, "Desconocido"),
                        animalDict.GetValueOrDefault(adoption.AnimalId, "Desconocido"),
                        adoption.AdoptionRequestDate.ToString("yyyy-MM-dd"),
                        adoption.AdoptionResponseDate?.ToString("yyyy-MM-dd") ?? "",
                        adoption.State,
                        adoption.Description
                    );
                }

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Refresh();
                if (dataGridView1.Columns.Contains("Estado"))
                {
                    int index = dataGridView1.Columns["Estado"].Index;
                    dataGridView1.Columns.RemoveAt(index);

                    var comboEstado = new DataGridViewComboBoxColumn
                    {
                        Name = "Estado",
                        HeaderText = "Estado",
                        DataPropertyName = "Estado",
                        Items = { "Pendiente", "Aprobada", "Rechazada" }
                    };

                    dataGridView1.Columns.Insert(index, comboEstado);
                }


                dataGridView1.Columns["Id"].ReadOnly = true;
                dataGridView1.Columns["Usuario"].ReadOnly = true;
                dataGridView1.Columns["Animal"].ReadOnly = true;
                dataGridView1.Columns["Fecha Solicitud"].ReadOnly = true;
                dataGridView1.Columns["Fecha Respuesta"].ReadOnly = true;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    var estado = row.Cells["Estado"].Value?.ToString();
                    bool editable = estado == "Pendiente";


                    row.Cells["Estado"].ReadOnly = !editable;
                    row.Cells["Descripción"].ReadOnly = !editable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_AcceptChanges_Click(object? sender, EventArgs e)
        {
            if (_adoptions == null) return;

            var adoptionClient = ApiClientsFactory.AdoptionClient();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var id = row.Cells["Id"].Value?.ToString();
                var adoption = _adoptions.FirstOrDefault(x => x.Id == id);
                if (adoption == null) continue;

                var newState = row.Cells["Estado"].Value?.ToString() ?? adoption.State;
                var newDesc = row.Cells["Descripción"].Value?.ToString() ?? "";
                var newDate = DateTime.Now;

                if (adoption.State != "Pendiente")
                    continue;

                if (newState != adoption.State || newDesc != adoption.Description)
                {
                    adoption.State = newState;
                    adoption.Description = newDesc;
                    adoption.AdoptionResponseDate = newDate;

                    var result = await adoptionClient.PutAsync(adoption.Id, adoption);
                    if (!result.Success)
                        MessageBox.Show($"Error al actualizar adopción {id}: {result.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Cambios guardados correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadData();
        }
    }
}