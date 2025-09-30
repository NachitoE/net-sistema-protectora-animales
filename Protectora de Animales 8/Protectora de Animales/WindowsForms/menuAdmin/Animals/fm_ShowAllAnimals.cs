using DTOs;
using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_ShowAllAnimals : Form
    {
        public fm_ShowAllAnimals()
        {
            InitializeComponent();
            Load += ShowAllAnimalsFormLoad;
        }


        private async void ShowAllAnimalsFormLoad(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            AnimalDTOClient animalClient = ApiClientsFactory.AnimalClient();
            ApiResult<List<AnimalDTO>> animalDTOsResult = await animalClient.GetAllAsync();
            var animalDTOs = animalDTOsResult.Data;
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("UserId", "Responsable");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("AnimalState", "Estado");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["AnimalState"].DataPropertyName = "AnimalState";
            dgv_animals.Columns["UserId"].DataPropertyName = "UserId";
            dgv_animals.DataSource = animalDTOs;
        }

    }
}
