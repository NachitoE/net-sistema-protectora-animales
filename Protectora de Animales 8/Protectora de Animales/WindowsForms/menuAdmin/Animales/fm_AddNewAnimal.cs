using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Services;
using Domain;

namespace WindowsForms.menuAdmin.Animales
{
    public partial class fm_AddNewAnimal : Form
    {
        private readonly Dictionary<string, Animal.SpeciesEn> speciesDict = new Dictionary<string, Animal.SpeciesEn>()
        {
            { "Perro", Animal.SpeciesEn.Perro },
            { "Gato", Animal.SpeciesEn.Gato },
            { "Conejo", Animal.SpeciesEn.Conejo },
            { "Pajaro", Animal.SpeciesEn.Pajaro },
        };
        public fm_AddNewAnimal()
        {
            InitializeComponent();
        }

        private void btn_AcceptnewAnimal_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateEmpty(tb_AnimalName);
            valid &= cb_AnimalSpc.Text != "";
            valid &=ValidDate(mtb_AnimalBd.Text);
            valid &= ValidateEmpty(tb_AnimalDescription);

            if (!valid)
                MessageBox.Show("Por favor, completá todos los campos del formulario.");

            if(valid)
            {
                string Name = tb_AnimalName.Text;
                Animal.SpeciesEn Species = speciesDict[cb_AnimalSpc.Text];

                DateTime BirthDate = DateTime.Parse(mtb_AnimalBd.Text);
                string UserId = "";
                Animal.AnimalStateEn AnimalState = Animal.AnimalStateEn.Disponible;
                string Description = tb_AnimalDescription.Text;
                Animal newAnimal= new Animal(Guid.NewGuid().ToString(), Name, Species, BirthDate, UserId, AnimalState,Description);
                AnimalService.Instance.Save(newAnimal);
                MessageBox.Show("Nuevo animal agregado exitosamente.");
                this.Close();
            }
        }
        private bool ValidateEmpty(TextBox txt)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.MistyRose;
                return false;
            }
            else
            {
                txt.BackColor = SystemColors.Window;
                return true;
            }
        }
        private bool ValidDate(string date)
        {
            /// verifica que la fecha sea coherente (no mayor a la actual, no antes de 1980)
            /// 
            DateTime dt;
            if (DateTime.TryParse(date, out dt))
            {
                if (dt > DateTime.Now || dt < new DateTime(1980, 1, 1))
                {
                    MessageBox.Show("Fecha inválida. Debe ser una fecha válida entre 1980 y la fecha actual.");
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Formato de fecha inválido. Por favor, ingrese una fecha válida.");
                return false;
            }






        }
}
}
