using DTOs;
using Helpers;
using Infrastructure.API;
using static Domain.Animal;

namespace WindowsForms.menuAdmin.Animals
{
    public partial class fm_AddNewAnimal : Form
    {
        public fm_AddNewAnimal()
        {
            InitializeComponent();
        }

        private async void btn_AcceptnewAnimal_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateEmpty(tb_AnimalName);
            valid &= cb_AnimalSpc.Text != "";
            valid &= ValidDate(mtb_AnimalBd.Text);
            valid &= ValidateEmpty(tb_AnimalDescription);

            if (!valid)
                MessageBox.Show("Por favor, completá todos los campos del formulario.");

            if (valid)
            {
                AnimalDTOClient animalClient = new AnimalDTOClient(new APIHttpClient()); 
                string Name = tb_AnimalName.Text;
                SpeciesEn Species = EnumConversion.StringToSpecies(cb_AnimalSpc.Text);

                DateTime BirthDate = DateTime.Parse(mtb_AnimalBd.Text);
                string UserId = "";
                AnimalStateEn AnimalState = AnimalStateEn.Disponible;
                string Description = tb_AnimalDescription.Text;

                AnimalDTO newAnimal = new AnimalDTO() {
                    Name = Name,
                    Species = EnumConversion.SpeciesToString(Species),
                    BirthDate = BirthDate,
                    UserId = UserId,
                    AnimalState = EnumConversion.AnimalStateToString(AnimalState),
                    Description = Description
                };
                await animalClient.PostAsync(newAnimal);
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
