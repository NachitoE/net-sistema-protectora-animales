using Services;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.menuAdmin.Animales
{
    public partial class fm_AsignResp : Form
    {
        public fm_AsignResp()
        {
            InitializeComponent();
            Load += UserFormLoad;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserFormLoad(object sender, EventArgs e)
        {
            dgv_users.AutoGenerateColumns = false;
            List<User> users = UserService.Instance.GetAll()
                .Where(u => (u.UserType == User.Type.Voluntario
                            || u.UserType == User.Type.Transito) &&
                            UserService.GetRemainingCapacity(u) > 0)
                .ToList();
            dgv_users.Columns.Add("UserName", "Usuario");
            dgv_users.Columns.Add("UserType", "Tipo de Usuario");
            dgv_users.Columns.Add("RemainingCapacity", "Capacidad Restante");
            dgv_users.Columns["UserName"].DataPropertyName = "UserName";
            dgv_users.Columns["UserType"].DataPropertyName = "UserType";
            dgv_users.Columns["RemainingCapacity"].DataPropertyName = "RemainingCapacity";
            dgv_users.CellFormatting += (s, usersDGVEventArgs) =>
            {
                if (dgv_users.Columns[usersDGVEventArgs.ColumnIndex].Name == "RemainingCapacity")
                {
                    var user = dgv_users.Rows[usersDGVEventArgs.RowIndex].DataBoundItem as User;
                    if (user != null)
                    {
                        usersDGVEventArgs.Value = UserService.GetRemainingCapacity(user);
                    }
                }
            };

            dgv_users.DataSource = users;
        }
    }
}
