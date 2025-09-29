using DTOs;
using Infrastructure.API;

namespace WindowsForms.menuAdmin.Users
{
    public partial class fm_ModifyUsers : Form
    {
        public fm_ModifyUsers()
        {
            InitializeComponent();
            Load += ModifyUserFormLoad;
        }

        private async void ModifyUserFormLoad(object sender, EventArgs e)
        {
            dgv_User.AutoGenerateColumns = false;
            //Shared.User WantedUser = UserService.Instance.GetByUserName(this.tb_getUsername.Text);
            dgv_User.Columns.Add("UserName", "Nombre de Usuario");
            dgv_User.Columns.Add("Name", "Nombre");
            dgv_User.Columns.Add("SurName", "Apellido");
            dgv_User.Columns.Add("DNI", "DNI");
            dgv_User.Columns.Add("Tipo Usuario", "Tipo Usuario");
            dgv_User.Columns["UserName"].DataPropertyName = "UserName";
            dgv_User.Columns["Name"].DataPropertyName = "Name";
            dgv_User.Columns["SurName"].DataPropertyName = "SurName";
            dgv_User.Columns["DNI"].DataPropertyName = "DNI";
            dgv_User.Columns["Tipo Usuario"].DataPropertyName = "UserType";



        }
        private void llb_ShowAllUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            fm_ShowAllUsers menuredir = new fm_ShowAllUsers();
            menuredir.ShowDialog();
            this.Close();
        }

        private async void btn_AcceptUsn_Click(object sender, EventArgs e)
        {
            UserDTOClient userClient = ApiClientsFactory.UserClient();
            ApiResult<List<UserDTO>> filteredUserListResult = await userClient.SearchAsync(
                new UserDTO()
                {
                    UserName = tb_getUsername.Text
                });
            var filteredUserList = filteredUserListResult.Data ?? new List<UserDTO>();
            if (filteredUserList.Count > 0)
            {
                Console.Error.WriteLine("Filtered user list by username having more than one user with the same username");
            }
            if (filteredUserList.Count == 0)
            {
                string message = "El usuario no existe";
                string caption = "Error";
                MessageBox.Show(message, caption);
                Close();
            }

            dgv_User.DataSource = filteredUserList;


        }


        private async void btn_AcceptMod_Click(object sender, EventArgs e)
        {
            string message = "Se modificará el usuario seleccionado";
            string caption = "Advertencia";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                if (dgv_User.DataSource is List<UserDTO> users && users.Count > 0)
                {
                    UserDTO userToModify = users[0];
                    UserDTOClient userClient = ApiClientsFactory.UserClient();
                    var putResult = await userClient.PutAsync(userToModify.Id, userToModify);
                    if (!putResult.Success)
                    {
                        MessageBox.Show(putResult.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito");
                }
            }
            else if (result == DialogResult.No)
            {
            }

        }
    }

}