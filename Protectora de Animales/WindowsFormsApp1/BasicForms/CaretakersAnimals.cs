using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Domain;

namespace WindowsFormsApp1.BasicForms
{
    public partial class fm_CaretakersAnimals : Form
    {
        public fm_CaretakersAnimals()
        {
            InitializeComponent();
            Load += ShowCaretakerAnimalsFormLoad;
        }


        private void ShowCaretakerAnimalsFormLoad(object sender, EventArgs e)
        {
            User user = UserService.Instance.CurrentLoggedOnUser;
            dgv_userAnimals.AutoGenerateColumns = false;
            List<Animal> animals = AnimalService.Instance.GetAll();
            var caretakerAnimals = animals.Where(a => a.UserId == user.Id).ToList();
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
