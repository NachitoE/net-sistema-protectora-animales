using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.menuAdopter
{
    public partial class fm_ShowAvailableAnimals : Form
    {
        public fm_ShowAvailableAnimals()
        {
            InitializeComponent();
            Load += ShowAvailableAnimalsFormLoad;
        }
        private void ShowAvailableAnimalsFormLoad(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Shared.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedAnimals = animals.Where(a => a.AnimalState == Shared.Animal.AnimalStateEn.Disponible).ToList();
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description","Descripción del animal");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";

            dgv_animals.DataSource = nonAdoptedAnimals;
        }

   
        private void btn_Dog_Click(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Shared.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedDogs = animals.Where(a => a.AnimalState == Shared.Animal.AnimalStateEn.Disponible&& a.Species == Shared.Animal.SpeciesEn.Perro).ToList();
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description", "Descripción del animal");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";

            dgv_animals.DataSource = nonAdoptedDogs;
        }

        private void btn_Cat_Click(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Shared.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedCats = animals.Where(a => a.AnimalState == Shared.Animal.AnimalStateEn.Disponible && a.Species == Shared.Animal.SpeciesEn.Gato).ToList();
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description", "Descripción del animal");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";

            dgv_animals.DataSource = nonAdoptedCats;
        }

        private void btn_Bunny_Click(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Shared.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedBunnies = animals.Where(a => a.AnimalState == Shared.Animal.AnimalStateEn.Disponible && a.Species == Shared.Animal.SpeciesEn.Conejo).ToList();
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description", "Descripción del animal");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";

            dgv_animals.DataSource = nonAdoptedBunnies;
        }

        private void btn_Bird_Click(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Shared.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedBirds = animals.Where(a => a.AnimalState == Shared.Animal.AnimalStateEn.Disponible && a.Species == Shared.Animal.SpeciesEn.Pajaro).ToList();
            dgv_animals.Columns.Add("Name", "Nombre");
            dgv_animals.Columns.Add("Species", "Especie");
            dgv_animals.Columns.Add("BirthDate", "Fecha de Nacimiento");
            dgv_animals.Columns.Add("Description", "Descripción del animal");
            dgv_animals.Columns["Name"].DataPropertyName = "Name";
            dgv_animals.Columns["Species"].DataPropertyName = "Species";
            dgv_animals.Columns["BirthDate"].DataPropertyName = "BirthDate";
            dgv_animals.Columns["Description"].DataPropertyName = "Description";

            dgv_animals.DataSource = nonAdoptedBirds;
        }
    };
   
    }
