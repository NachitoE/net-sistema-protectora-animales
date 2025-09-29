using DTOs;
using DTOs.House;
using Infrastructure.API;

namespace WindowsForms.menuAdmin.Houses
{
    public partial class fm_HouseChangeCapacity : Form
    {
        private HouseDTO? _currentSelectedHouse = null;
        public fm_HouseChangeCapacity()
        {
            InitializeComponent();
            Load += fm_HouseChangeCapacity_Load;
        }
        private async void fm_HouseChangeCapacity_Load(object sender, EventArgs e)
        {
            btn_accept.Enabled = false;
            await ReloadData();
            dgv_houses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_houses.SelectionChanged += new EventHandler(OnHouseSelectionChanged);
        }
        private void OnHouseSelectionChanged(object? sender, EventArgs e)
        {
            if (dgv_houses.SelectedRows.Count > 0)
            {
                _currentSelectedHouse = (HouseDTO)dgv_houses.SelectedRows[0].DataBoundItem;
                lb_currentCapacityQuantity.Text = _currentSelectedHouse.Capacity.ToString();
                numud_desiredCapacity.ReadOnly = false;
                numud_desiredCapacity.Value = _currentSelectedHouse.Capacity;
                btn_accept.Enabled = true;
            }
            else
            {
                _currentSelectedHouse = null;
                lb_currentCapacityQuantity.Text = "-";
                numud_desiredCapacity.ReadOnly = true;
                numud_desiredCapacity.Value = 0;
                btn_accept.Enabled = false;
            }
        }
        private async void btn_accept_Click(object sender, EventArgs e)
        {
            if (_currentSelectedHouse == null) return;
            var houseClient = ApiClientsFactory.HouseClient();
            var changeCapacityResult = await houseClient.ChangeCapacity(new HouseChangeCapacityDTO()
            {
                HouseId = _currentSelectedHouse.Id,
                NewCapacity = (int)numud_desiredCapacity.Value
            });

            if (!changeCapacityResult.Success)
            {
                MessageBox.Show(changeCapacityResult.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Capacidad actualizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await ReloadData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task ReloadData()
        {
            var houseClient = ApiClientsFactory.HouseClient();
            var housesResult = await houseClient.GetAllAsync();

            dgv_houses.DataSource = housesResult.Data;
        }
    }
}
