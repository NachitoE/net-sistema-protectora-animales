using DTOs;
using Infrastructure.API;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_ModifyAnimals : Form
    {
        public fm_ModifyAnimals()
        {
            InitializeComponent();
            Load += ModifyAnimalFormLoad;
        }

        private async void ModifyAnimalFormLoad(object sender, EventArgs e)
        {
            dgv_User.AutoGenerateColumns = false;
            
            dgv_User.Columns.Add("Name", "Nombre");
            dgv_User.Columns.Add("Species", "Especie");
            dgv_User.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_User.Columns.Add("Description", "Descripción");
            dgv_User.Columns.Add("AnimalState", "Estado");
            
            dgv_User.Columns["Name"].DataPropertyName = "Name";
            dgv_User.Columns["Species"].DataPropertyName = "Species";
            dgv_User.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_User.Columns["Description"].DataPropertyName = "Description";
            dgv_User.Columns["AnimalState"].DataPropertyName = "AnimalState";
        }

        private void llb_ShowAllUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fm_ShowAllAnimals menuredir = new fm_ShowAllAnimals();
            menuredir.ShowDialog();
            this.Close();
        }

        private async void btn_AcceptUsn_Click(object sender, EventArgs e)
        {
            AnimalDTOClient animalClient = ApiClientsFactory.AnimalClient();
            ApiResult<List<AnimalDTO>> filteredAnimalListResult = await animalClient.SearchAsync(
                new AnimalDTO()
                {
                    Name = tb_getAnimalName.Text
                });

            if (!filteredAnimalListResult.Success)
            {
                MessageBox.Show(filteredAnimalListResult.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filteredAnimalList = filteredAnimalListResult.Data ?? new List<AnimalDTO>();
            
            if (filteredAnimalList.Count > 0)
            {
                Console.Error.WriteLine("Filtered animal list by name having more than one animal with the same name");
            }
            
            if (filteredAnimalList.Count == 0)
            {
                string message = "El animal no existe";
                string caption = "Error";
                MessageBox.Show(message, caption);
                Close();
            }

            dgv_User.DataSource = filteredAnimalList;
        }

        private async void btn_AcceptMod_Click(object sender, EventArgs e)
        {
            string message = "Se modificará el animal seleccionado";
            string caption = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (dgv_User.DataSource is List<AnimalDTO> animals && animals.Count > 0)
                {
                    AnimalDTO animalToModify = animals[0];
                    AnimalDTOClient animalClient = ApiClientsFactory.AnimalClient();
                    var putResult = await animalClient.PutAsync(animalToModify.Id, animalToModify);
                    if (!putResult.Success)
                    {
                        MessageBox.Show(putResult.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Animal modificado correctamente.", "Éxito");
                }
            }
            else if (result == DialogResult.No)
            {
            }
        }
    }
}