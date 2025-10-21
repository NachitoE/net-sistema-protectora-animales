using WindowsForms.menuAdmin.Adoptions;

namespace WindowsForms.menuAdmin
{
    public partial class fm_AdminAdoptionMenu : Form
    {
        public fm_AdminAdoptionMenu()
        {
            InitializeComponent();
        }

        private void btn_Modify_Adoption_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ModifyAdoptions();
            
            menuredir.ShowDialog();
            this.Show();

        }

        private void btn_AdoptionFollowings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuredir = new fm_ManageAdoptions();
            menuredir.ShowDialog();
            this.Show();
        }
    }
}
