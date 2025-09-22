/*using DTOs;
using System.Data;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_AsignResp : Form
    {
        private UserDTO _selectedTargetUser = null;
        private AnimalDTO _selectedTargetAnimal = null;
        public fm_AsignResp()
        {
            InitializeComponent();
            Load += UserFormLoad;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserFormLoad(object sender, EventArgs e)
        {
            btn_accept.Enabled = false;

            //============ Cargar Usuarios =============
            dgv_users.AutoGenerateColumns = false;
            //tiene q ser una lista de usuarios que sean voluntarios o de tránsito y que tengan capacidad restante
            List<UserDTO> users = 
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
                    var user = dgv_users.Rows[usersDGVEventArgs.RowIndex].DataBoundItem as User;
                    if (user != null)
                    {
                        usersDGVEventArgs.Value = UserService.GetRemainingCapacity(user);
                    }
                }
            };

            dgv_users.SelectionChanged += (s, usersDGVEventArgs) =>
            {
                if (dgv_users.SelectedRows.Count > 0)
                {
                    _selectedTargetUser = dgv_users.SelectedRows[0].DataBoundItem as User;
                }
                else
                {
                    _selectedTargetUser = null;
                }
                UpdateAcceptButtonState();
            };
            dgv_users.DataSource = users;
            dgv_users.ClearSelection();
            //============ Cargar Animales =============
            dgv_animals.AutoGenerateColumns = false;
            List<Animal> animals = AnimalService.Instance.GetAll()
                .Where(a => a.AnimalState == Animal.AnimalStateEn.Disponible)
                .ToList();

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
                    var animal = dgv_animals.Rows[animalsDGVEventArgs.RowIndex].DataBoundItem as Animal;
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
                    _selectedTargetAnimal = dgv_animals.SelectedRows[0].DataBoundItem as Animal;
                }
                else
                {
                    _selectedTargetAnimal = null;
                }
                UpdateAcceptButtonState();
            };
            dgv_animals.DataSource = animals;
            dgv_animals.ClearSelection();
            //users and/or animals empty => TODO: Quizás ésto lo podríamos mover al presionar el botón que trae a este form:)
            if (users.Count == 0 || animals.Count == 0)
            {
                string informationString =
                    users.Count == 0 && animals.Count == 0 ? "ni usuarios ni animales" :
                    users.Count == 0 ? "usuarios" :
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

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if (_selectedTargetUser == null || _selectedTargetAnimal == null)
            {
                //no debería llegar a este punto, pero veremos
                MessageBox.Show("Debe estar seleccionado un animal y un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _selectedTargetAnimal.UserId = _selectedTargetUser.Id;
            _selectedTargetAnimal.AnimalState = Animal.AnimalStateEn.Adoptado;
            AnimalService.Instance.Save(_selectedTargetAnimal);
            MessageBox.Show($"El animal {_selectedTargetAnimal.Name} ha sido asignado a {_selectedTargetUser.UserName}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
*/