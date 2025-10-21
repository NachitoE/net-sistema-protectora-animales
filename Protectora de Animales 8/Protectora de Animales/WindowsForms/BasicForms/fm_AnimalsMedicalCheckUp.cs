using DTOs;
using Infrastructure.API;
using System.Data;


namespace WindowsForms.BasicForms
{
    public partial class fm_AnimalsMedicalCheckUp : Form
    {
        private List<MedicalCheckUpDTO>? _medicalCheckUps;

        public fm_AnimalsMedicalCheckUp()
        {
            InitializeComponent();
            Load += fm_AnimalsMedicalCheckUp_Load;
            
        }

        private async void fm_AnimalsMedicalCheckUp_Load(object? sender, EventArgs e)
        {
            dgv_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_User.AllowUserToAddRows = false;
            dgv_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await ReloadData();
        }

        private async Task ReloadData()
        {
            var medicalClient = ApiClientsFactory.MedicalCheckUpClient();
            var userClient = ApiClientsFactory.UserClient();
            var animalClient = ApiClientsFactory.AnimalClient();

            var medicalResult = await medicalClient.GetAllAsync();

            if (!medicalResult.Success || medicalResult.Data == null)
            {
                MessageBox.Show("Error al cargar los chequeos médicos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _medicalCheckUps = medicalResult.Data;


            var users = await userClient.GetAllAsync();
            var animals = await animalClient.GetAllAsync();


            var table = new DataTable();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Usuario", typeof(string));
            table.Columns.Add("Animal", typeof(string));
            table.Columns.Add("FechaChequeo", typeof(DateTime));
            table.Columns.Add("Observación", typeof(string));

            foreach (var checkup in _medicalCheckUps)
            {
                var userName = users.Data?.FirstOrDefault(u => u.Id == checkup.UserId)?.Name ?? "(Desconocido)";
                var animalName = animals.Data?.FirstOrDefault(a => a.Id == checkup.AnimalId)?.Name ?? "(Desconocido)";

                table.Rows.Add(checkup.Id, userName, animalName, checkup.CheckUpDate, checkup.Observation);
            }

            dgv_User.DataSource = table;


            dgv_User.Columns["Usuario"].ReadOnly = true;
            dgv_User.Columns["Animal"].ReadOnly = true;
            dgv_User.Columns["Id"].ReadOnly = true;


            dgv_User.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_User.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            if (dgv_User.Columns.Contains("Observación"))
            {
                dgv_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_User.Columns["Observación"].FillWeight = 200;
            }
        }



        private async void btn_AcceptChanges_Click(object? sender, EventArgs e)
        {
            if (_medicalCheckUps == null)
                return;

            var medicalClient = ApiClientsFactory.MedicalCheckUpClient();
            var fechaMinima = new DateTime(2010, 1, 1);
            var fechaActual = DateTime.Now;

            foreach (DataGridViewRow row in dgv_User.Rows)
            {
                var id = row.Cells["Id"].Value?.ToString();
                var checkup = _medicalCheckUps.FirstOrDefault(x => x.Id == id);
                if (checkup == null) continue;

                if (!DateTime.TryParse(row.Cells["FechaChequeo"].Value?.ToString(), out var newDate))
                {
                    MessageBox.Show($"La fecha ingresada para el chequeo {id} no es válida.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }


                if (newDate < fechaMinima || newDate > fechaActual)
                {
                    MessageBox.Show($"La fecha del chequeo {id} debe ser entre el 01/01/2010 y hoy ({fechaActual:dd/MM/yyyy}).",
                        "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                var newObs = row.Cells["Observación"].Value?.ToString() ?? "";

                if (checkup.CheckUpDate != newDate || checkup.Observation != newObs)
                {
                    checkup.CheckUpDate = newDate;
                    checkup.Observation = newObs;

                    var result = await medicalClient.PutAsync($"{checkup.Id}", checkup);
                    if (!result.Success)
                    {
                        MessageBox.Show($"Error al actualizar chequeo {id}: {result.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await ReloadData();
        }
    }
}