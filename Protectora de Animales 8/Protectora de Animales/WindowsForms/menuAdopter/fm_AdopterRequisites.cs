using System;
using System.Windows.Forms;

namespace WindowsForms.menuAdopter
{
    public partial class fm_AdopterRequisites : Form
    {
        public fm_AdopterRequisites()
        {
            InitializeComponent();
        }

        private void btn_AcceptRequisites_Click(object? sender, EventArgs e)
        {
            if (!ckb_TermsofAdoption.Checked)
            {
                MessageBox.Show(
                    "Debe leer y aceptar los requisitos de adopción antes de continuar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            MessageBox.Show(
                "¡Gracias! Puede continuar con el proceso de adopción.",
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ckb_TermsofAdoption_CheckedChanged(object sender, EventArgs e)
        {
            btn_AcceptRequisites.Enabled = ckb_TermsofAdoption.Checked;
        }
    }
}