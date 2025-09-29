using DTOs;
using Helpers;
using Infrastructure.API;
using static Domain.Animal;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_AsignResp : Form
    {
        private UserDTO? _selectedTargetUser = null;
        private AnimalDTO? _selectedTargetAnimal = null;
        public fm_AsignResp()
        {
            InitializeComponent();
            Load += UserFormLoad;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void UserFormLoad(object sender, EventArgs e)
        {
            btn_accept.Enabled = false;
            UserDTOClient userClient = new UserDTOClient(new APIHttpClient());
            AnimalDTOClient animalClient = new AnimalDTOClient(new APIHttpClient());
            //============ Cargar Usuarios =============
            dgv_users.AutoGenerateColumns = false;
            //tiene q ser una lista de usuarios que sean voluntarios o de tránsito y que tengan capacidad restante
            List<UserDTO> availableUsersToAdopt = await userClient.GetAvailableToAdoptAsync();
            Dictionary<UserDTO, int> usersWithRemainingCapacity = new();
            availableUsersToAdopt.ForEach(async u =>
            {
                int remainingCapacity = await userClient.GetUserRemainingCapacity(u.Id);
                if (remainingCapacity > 0)
                {
                    usersWithRemainingCapacity.Add(u, remainingCapacity);
                }
            });

            dgv_users.Columns.Add("UserName", "Usuario");
            dgv_users.Columns.Add("UserType", "Tipo de Usuario");
            dgv_users.Columns.Add("RemainingCapacity", "Capacidad Restante");
            dgv_users.Columns["UserName"].DataPropertyName = "UserName";
            dgv_users.Columns["UserType"].DataPropertyName = "UserType";
            dgv_users.Columns["RemainingCapacity"].DataPropertyName = "RemainingCapacity";
            dgv_users.CellFormatting += (s, usersDGVEventArgs) =>
            {
                if (dgv_users.Columns[usersDGVEventArgs.ColumnIndex].Name == "RemainingCapacity")
                {
                    var user = dgv_users.Rows[usersDGVEventArgs.RowIndex].DataBoundItem as UserDTO;
                    if (user != null)
                    {
                        if (usersWithRemainingCapacity.ContainsKey(user)){
                            usersDGVEventArgs.Value = usersWithRemainingCapacity[user];
                        }
                    }
                }
            };

            dgv_users.SelectionChanged += (s, usersDGVEventArgs) =>
            {
                if (dgv_users.SelectedRows.Count > 0)
                {
                    _selectedTargetUser = dgv_users.SelectedRows[0].DataBoundItem as UserDTO;
                }
                else
                {
                    _selectedTargetUser = null;
                }
                UpdateAcceptButtonState();
            };
            dgv_users.DataSource = availableUsersToAdopt;
            dgv_users.ClearSelection();
            //============ Cargar Animales =============
            dgv_animals.AutoGenerateColumns = false;
            List<AnimalDTO> availableAnimals = await animalClient.GetAllAvailableAnimalsAsync();

            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.CellFormatting += (s, animalsDGVEventArgs) =>
            {
                if (dgv_animals.Columns[animalsDGVEventArgs.ColumnIndex].Name == "BirthDate")
                {
                    var animal = dgv_animals.Rows[animalsDGVEventArgs.RowIndex].DataBoundItem as AnimalDTO;
                    if (animal != null)
                    {
                        animalsDGVEventArgs.Value = animal.BirthDate.ToShortDateString();
                    }
                }
            };

            dgv_animals.SelectionChanged += (s, animalsDGVEventArgs) =>
            {
                if (dgv_animals.SelectedRows.Count > 0)
                {
                    _selectedTargetAnimal = dgv_animals.SelectedRows[0].DataBoundItem as AnimalDTO;
                }
                else
                {
                    _selectedTargetAnimal = null;
                }
                UpdateAcceptButtonState();
            };
            dgv_animals.DataSource = availableAnimals;
            dgv_animals.ClearSelection();
            //users and/or animals empty => TODO: Quizás ésto lo podríamos mover al presionar el botón que trae a este form:)
            if (availableUsersToAdopt.Count == 0 || availableAnimals.Count == 0)
            {
                string informationString =
                    availableUsersToAdopt.Count == 0 && availableAnimals.Count == 0 ? "ni usuarios ni animales" :
                    availableUsersToAdopt.Count == 0 ? "usuarios" :
                    "animales";
                MessageBox.Show($"No hay {informationString} disponibles para asignar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }


        }
        private void UpdateAcceptButtonState() => btn_accept.Enabled = _selectedTargetUser != null && _selectedTargetAnimal != null;
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_accept_Click(object sender, EventArgs e)
        {
            if (_selectedTargetUser == null || _selectedTargetAnimal == null)
            {
                //no debería llegar a este punto, pero veremos
                MessageBox.Show("Debe estar seleccionado un animal y un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AnimalDTOClient animalClient = new AnimalDTOClient(new APIHttpClient());
            await animalClient.AssignResponsible(_selectedTargetAnimal.Id, _selectedTargetUser.Id);
            MessageBox.Show($"El animal {_selectedTargetAnimal.Name} ha sido asignado a {_selectedTargetUser.UserName}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

    }
}
