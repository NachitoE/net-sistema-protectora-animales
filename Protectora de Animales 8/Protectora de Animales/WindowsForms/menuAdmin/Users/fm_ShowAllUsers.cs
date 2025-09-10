using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.menuAdmin.Users
{
    public partial class fm_ShowAllUsers : Form
    {
        public fm_ShowAllUsers()
        {
            InitializeComponent();
            Load += ShowUsersFormLoad;
        }
        private void ShowUsersFormLoad(object sender, EventArgs e)
        {
            SetupColumns();
            dgv_Users.AutoGenerateColumns = false;
            List<Shared.User> users = Services.UserService.Instance.GetAll();
            List<Shared.User> nonAdmins = users.Where(u => u.UserType != Shared.User.Type.Admin).ToList();
            List<Shared.User> orderbyUN = nonAdmins.OrderBy(u => u.UserName).ToList();
            dgv_Users.DataSource = orderbyUN;
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
            SetupColumns();
            dgv_Users.AutoGenerateColumns = false;
            List<Shared.User> users = Services.UserService.Instance.GetAll();
            List<Shared.User> nonAdmins = users.Where(u => u.UserType != Shared.User.Type.Admin).ToList();
            List<Shared.User> orderbyUN = nonAdmins.OrderBy(u => u.UserName).ToList();
            dgv_Users.DataSource = orderbyUN;
        }

        private void btn_filterbyAdopters_Click(object sender, EventArgs e)
        {
            dgv_Users.AutoGenerateColumns = false;
            List<Shared.User> users = Services.UserService.Instance.GetAll();
            List<Shared.User> adopters = users.Where(u => u.UserType == Shared.User.Type.Adoptante).ToList();
            List<Shared.User>orderedAdopters = adopters.OrderBy(u => u.UserName).ToList();
            dgv_Users.DataSource = orderedAdopters;
        }

        private void btn_FilterByFosters_Click(object sender, EventArgs e)
        {
            dgv_Users.AutoGenerateColumns = false;
            List<Shared.User> users = Services.UserService.Instance.GetAll();
            List<Shared.User> fosters = users.Where(u => u.UserType == Shared.User.Type.Transito).ToList();
            List<Shared.User> orderedFosters = fosters.OrderBy(u => u.UserName).ToList();
            dgv_Users.DataSource = orderedFosters;


        }

        private void btn_FilterByVolunteers_Click(object sender, EventArgs e)
        {
            dgv_Users.AutoGenerateColumns = false;
            List<Shared.User> users = Services.UserService.Instance.GetAll();
            List<Shared.User> volunteers = users.Where(u => u.UserType == Shared.User.Type.Voluntario).ToList();
            List<Shared.User> orderedVolunteers = volunteers.OrderBy(u => u.UserName).ToList();
            dgv_Users.DataSource = orderedVolunteers;
        }
    }
}
