using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms.menuAdmin.Animales
{
    public partial class fm_ShowAllAnimals : Form
    {
        public fm_ShowAllAnimals()
        {
            InitializeComponent();
            Load += ShowAllAnimalsFormLoad;
        }

       
        private void ShowAllAnimalsFormLoad(object sender, EventArgs e)
        {
            dgv_animals.AutoGenerateColumns = false;
            List<Domain.Animal> animals = Services.AnimalService.Instance.GetAll();
            var nonAdoptedAnimals = animals.Where(a => a.AnimalState == Domain.Animal.AnimalStateEn.Disponible).ToList();
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
            dgv_animals.DataSource = nonAdoptedAnimals;
        }
      
       
    }
}
