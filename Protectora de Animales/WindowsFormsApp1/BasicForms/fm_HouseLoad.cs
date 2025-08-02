using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.BasicForms
{
    public partial class fm_HouseLoad : Form
    {
        string userId;//Preguntarle a nacho, no me cierra
        public fm_HouseLoad(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btn_AcceptnewHouse_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid &= ValidateEmpty(tb_HouseAdress);
            valid &= ValidateEmpty(tb_HouseAdressNumber);
            valid &= ValidNumber(tb_HouseAdressNumber);

            if (!valid)
            {
                MessageBox.Show("Por favor, completá todos los campos del formulario.");
                return;
            }
            string Address = tb_HouseAdress.Text;
            int AddressNumber= int.Parse(tb_HouseAdressNumber.Text);
            int Capacity = (int)nud_HouseCapacity.Value;
            Shared.House newHouse = new Shared.House(Guid.NewGuid().ToString(), userId, Address, AddressNumber, Capacity);
            Services.HouseService.Instance.Save(newHouse);
            this.DialogResult = DialogResult.OK;//termina siendo irrelevante? Falta algún manejo?
            MessageBox.Show("Nueva casa agregada exitosamente.");
            this.Close();


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
        private bool ValidNumber(TextBox txt)      
        {
            string adressNumber = txt.Text;
            if (int.TryParse(adressNumber, out int number) && number > 0)
            {
                return true;
            }
            else
            {
                txt.BackColor = Color.MistyRose;
                MessageBox.Show("El número debe ser un entero positivo.");
                return false;
            }
        }
    }
    }
