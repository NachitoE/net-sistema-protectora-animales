using DTOs;
using Infrastructure.API;
using static Domain.User;
using System.Data;
using Domain;
using Helpers;


namespace WindowsForms.menuAdmin.Users
{
    public partial class fm_ShowAllUsers : Form
    {
        List<UserDTO> _allUsers = new List<UserDTO>();
        public fm_ShowAllUsers()
        {
            InitializeComponent();
            Load += ShowUsersFormLoad;
           
        }
        private async void ShowUsersFormLoad(object sender, EventArgs e)
        {
            SetupColumns();
            dgv_Users.AutoGenerateColumns = false;
            UserDTOClient userClient = ApiClientsFactory.UserClient();
            var allUsersResult = await userClient.GetAllAsync();
            _allUsers = allUsersResult.Data ?? new List<UserDTO>();
            dgv_Users.DataSource = _allUsers;
        }
        private void SetupColumns()
        {
            if (dgv_Users.Columns.Count > 0) return;

            dgv_Users.AutoGenerateColumns = false;

            dgv_Users.Columns.Add("UserName", "Nombre de Usuario");
            dgv_Users.Columns.Add("Name", "Nombre");
            dgv_Users.Columns.Add("SurName", "Apellido");
            dgv_Users.Columns.Add("DNI", "DNI");
            dgv_Users.Columns.Add("UserType", "Tipo de Usuario");


            dgv_Users.Columns["UserName"].DataPropertyName = "UserName";
            dgv_Users.Columns["Name"].DataPropertyName = "Name";
            dgv_Users.Columns["SurName"].DataPropertyName = "SurName";
            dgv_Users.Columns["DNI"].DataPropertyName = "DNI";
            dgv_Users.Columns["UserType"].DataPropertyName = "UserType";
        }

        private void btn_AllUsers_Click(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void btn_filterbyAdopters_Click(object sender, EventArgs e)
        {
            FilterUsers(EnumConversion.UserTypeToString(UserType.Adoptante));
        }

        private void btn_FilterByFosters_Click(object sender, EventArgs e)
        {
            FilterUsers(EnumConversion.UserTypeToString(UserType.Transito));
        }

        private void btn_FilterByVolunteers_Click(object sender, EventArgs e)
        {
            FilterUsers(EnumConversion.UserTypeToString(UserType.Voluntario));
        }

        private void FilterUsers(string? selType = null)
        {
            dgv_Users.AutoGenerateColumns = false;
            var filteredUsers = _allUsers
                .Where(u => selType == null || u.UserType == selType)
                .ToList();
            dgv_Users.DataSource = filteredUsers;
        }

    }
}
