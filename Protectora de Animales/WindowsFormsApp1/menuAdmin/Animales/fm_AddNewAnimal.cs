using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Shared;

namespace WindowsFormsApp1.menuAdmin.Animales
{
    public partial class fm_AddNewAnimal : Form
    {
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

            if (!valid)
                MessageBox.Show("Por favor, completá todos los campos del formulario.");

            if(valid)
            {
                string name = tb_AnimalName.Text;
                Animal.SpeciesEn species = Animal.SpeciesEn.Conejo;
                switch (cb_AnimalSpc.Text)
                {
                    case "Perro":
                        species = Animal.SpeciesEn.Perro;
                        break;
                    case "Gato":
                        species = Animal.SpeciesEn.Gato;
                        break;
                    case "Conejo":
                        species = Animal.SpeciesEn.Conejo;
                        break;
               
                }

                DateTime birthDate = DateTime.Parse(mtb_AnimalBd.Text);
                string userId = "";
                Animal.AnimalStateEn animalState = Animal.AnimalStateEn.Disponible;
                Animal newAnimal= new Animal(Guid.NewGuid().ToString(), name, species, birthDate, userId, animalState);
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
