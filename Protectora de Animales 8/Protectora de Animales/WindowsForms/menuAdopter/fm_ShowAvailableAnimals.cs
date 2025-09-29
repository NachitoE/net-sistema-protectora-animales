using System.Data;
using DTOs;
using Helpers;
using Infrastructure.API;
using static Domain.Animal;

namespace WindowsForms.menuAdopter
{
    public partial class fm_ShowAvailableAnimals : Form
    {
        private List<AnimalDTO> _availableAnimals;
        public fm_ShowAvailableAnimals()
        {
            InitializeComponent();
            Load += ShowAvailableAnimalsFormLoadAsync;
        }
        private async void ShowAvailableAnimalsFormLoadAsync(object sender, EventArgs e)
        {
            SetupColumns();
            dgv_animals.AutoGenerateColumns = false;
            AnimalDTOClient animalClient = ApiClientsFactory.AnimalClient();
            ApiResult<List<AnimalDTO>> availableAnimalsResult = await animalClient.GetAllAvailableAnimalsAsync();
            var availableAnimals = availableAnimalsResult.Data ?? new List<AnimalDTO>();
            _availableAnimals = availableAnimals;
            dgv_animals.DataSource = availableAnimals;
        }
        private void SetupColumns()
        {
            if (dgv_animals.Columns.Count > 0) return;

            dgv_animals.AutoGenerateColumns = false;

            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description", "Descripción del animal");

            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";
        }

        private void btn_Dog_Click(object sender, EventArgs e)
        {
            if (!IsContentReady()) return;
            FilterBySpecies(EnumConversion.SpeciesToString(SpeciesEn.Perro));
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            if (!IsContentReady()) return;
            FilterBySpecies(EnumConversion.SpeciesToString(SpeciesEn.Gato));
        }

        private void btn_Bunny_Click(object sender, EventArgs e)
        {
            if (!IsContentReady()) return;
            FilterBySpecies(EnumConversion.SpeciesToString(SpeciesEn.Conejo));
        }

        private void btn_Bird_Click(object sender, EventArgs e)
        {
            if (!IsContentReady()) return;
            FilterBySpecies(EnumConversion.SpeciesToString(SpeciesEn.Pajaro));

        }

        private void FilterBySpecies(string selSpecies)
        {
            dgv_animals.AutoGenerateColumns = false;
            var nonAdoptedBirds = _availableAnimals.Where(a => a.Species == selSpecies).ToList();
            dgv_animals.DataSource = nonAdoptedBirds;
        }
        private bool IsContentReady() => _availableAnimals != null;
    }
}
