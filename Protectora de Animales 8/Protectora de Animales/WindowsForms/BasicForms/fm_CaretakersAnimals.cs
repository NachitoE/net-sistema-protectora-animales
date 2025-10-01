
using Domain;
using DTOs;
using Infrastructure.API;
using System.Data;
namespace WindowsForms.NewFolder1
{
    public partial class fm_CaretakersAnimals : Form
    {
        public fm_CaretakersAnimals()
        {
            InitializeComponent();
            Load += ShowCaretakerAnimalsFormLoad;
        }


        private async void ShowCaretakerAnimalsFormLoad(object sender, EventArgs e)
        {
            var authClient = ApiClientsFactory.AuthClient();
            var thisUserResult = await authClient.MeAsync();
            UserDTO thisUser = thisUserResult.Data;
            if (!thisUserResult.Success || thisUser == null)
            {
                MessageBox.Show("No se detectó al usuario loggeado", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            UserDTOClient userClient = ApiClientsFactory.UserClient();
            ApiResult<List<AnimalDTO>> caretakerAnimalsResult = await userClient.GetUserAnimalsAsync(thisUser.Id);
            List<AnimalDTO> caretakerAnimals = caretakerAnimalsResult.Data ?? new List<AnimalDTO>();
            dgv_userAnimals.AutoGenerateColumns = false;
            dgv_userAnimals.Columns.Add("Name", "Nombre");
            dgv_userAnimals.Columns.Add("Species", "Especie");
            dgv_userAnimals.Columns.Add("UserId", "Responsable");
            dgv_userAnimals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_userAnimals.Columns.Add("AnimalState", "Estado");
            dgv_userAnimals.Columns["Name"].DataPropertyName = "Name";
            dgv_userAnimals.Columns["Species"].DataPropertyName = "Species";
            dgv_userAnimals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_userAnimals.Columns["AnimalState"].DataPropertyName = "AnimalState";
            dgv_userAnimals.Columns["UserId"].DataPropertyName = "UserId";
            dgv_userAnimals.DataSource = caretakerAnimals;
        }
    }
}
