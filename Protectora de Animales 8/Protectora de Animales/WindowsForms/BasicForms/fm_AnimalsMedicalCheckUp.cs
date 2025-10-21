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
            var authClient = ApiClientsFactory.AuthClient();


            var currentUserResult = await authClient.MeAsync();
            if (!currentUserResult.Success || currentUserResult.Data == null)
            {
                MessageBox.Show("No se pudo obtener la información del usuario actual.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var currentUser = currentUserResult.Data;


            var medicalResult = await medicalClient.GetAllAsync();
            if (!medicalResult.Success || medicalResult.Data == null)
            {
                MessageBox.Show("Error al cargar los chequeos médicos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _medicalCheckUps = medicalResult.Data;

            
            if (!string.Equals(currentUser.UserType, "Admin", StringComparison.OrdinalIgnoreCase))
            {
                var caretakerAnimalsResult = await userClient.GetUserAnimalsAsync(currentUser.Id);
                if (!caretakerAnimalsResult.Success || caretakerAnimalsResult.Data == null)
                {
                    MessageBox.Show("No se pudieron obtener los animales a cargo del usuario.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _medicalCheckUps = new List<MedicalCheckUpDTO>();
                }
                else
                {
                    var caretakerAnimalIds = caretakerAnimalsResult.Data.Select(a => a.Id).ToHashSet();
                    _medicalCheckUps = _medicalCheckUps
                        .Where(mc => caretakerAnimalIds.Contains(mc.AnimalId))
                        .ToList();
                }
            }


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

        private async void btn_AcceptChanges_Click(object sender, EventArgs e)
        {
            if (_medicalCheckUps == null)
                return;

            var medicalClient = ApiClientsFactory.MedicalCheckUpClient();
            bool cambios = false;

            foreach (DataGridViewRow row in dgv_User.Rows)
            {
                var id = row.Cells["Id"].Value?.ToString();
                var checkup = _medicalCheckUps.FirstOrDefault(x => x.Id == id);
                if (checkup == null)
                    continue;

                
                if (!DateTime.TryParse(row.Cells["FechaChequeo"].Value?.ToString(), out var nuevaFecha))
                {
                    MessageBox.Show($"La fecha ingresada para el chequeo {id} no es válida.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                var nuevaObs = row.Cells["Observación"].Value?.ToString() ?? "";

                
                var hoy = DateTime.Now;
                if (nuevaFecha > hoy)
                {
                    MessageBox.Show($"La fecha del chequeo {id} no puede ser futura.",
                        "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                if ((hoy - nuevaFecha).TotalDays > 3650)
                {
                    MessageBox.Show($"El chequeo {id} no puede tener más de 10 años.",
                        "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    continue;
                }

                
                if (checkup.CheckUpDate != nuevaFecha || checkup.Observation != nuevaObs)
                {
                    checkup.CheckUpDate = nuevaFecha;
                    checkup.Observation = nuevaObs;

                    var result = await medicalClient.PutAsync($"{checkup.Id}", checkup);
                    if (!result.Success)
                    {
                        MessageBox.Show($"Error al actualizar chequeo {id}: {result.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cambios = true;
                    }
                }
            }

            if (cambios)
            {
                MessageBox.Show("Cambios guardados correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await ReloadData();
            }
            else
            {
                MessageBox.Show("No se realizaron cambios.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}