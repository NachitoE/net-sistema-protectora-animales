using DTOs.Sighting;
using Infrastructure.API;
using Infrastructure.API.DTOs_CRUDs;

namespace WindowsForms.BasicForms
{
    public partial class fm_SightingMenu : Form
    {
        private List<SightingDTO> _sightings;

        public fm_SightingMenu()
        {
            InitializeComponent();
            Load += SightingMenuLoadAsync;
        }

        private async void SightingMenuLoadAsync(object sender, EventArgs e)
        {
            SetupColumns();
            dgv_Sightings.AutoGenerateColumns = false;

            SightingDTOClient sightingClient = ApiClientsFactory.SightingClient();

            var sightingResult = await sightingClient.GetAllAsync();
            List<SightingDTO> sightings = sightingResult.Data;
            _sightings = sightings;
            dgv_Sightings.DataSource = sightings;
        }

        private void SetupColumns()
        {
            if (dgv_Sightings.Columns.Count > 0) return;
            dgv_Sightings.AutoGenerateColumns = false;
            dgv_Sightings.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_Sightings.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Sightings.Columns.Add("SightingAdressName", "Dirección");
            dgv_Sightings.Columns["SightingAdressName"].DataPropertyName = "SightingAdressName";
            dgv_Sightings.Columns["SightingAdressName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Sightings.Columns.Add("SightingAdressNumber", "Número");
            dgv_Sightings.Columns["SightingAdressNumber"].DataPropertyName = "SightingAdressNumber";
            dgv_Sightings.Columns["SightingAdressNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Sightings.Columns.Add("SightingDateTime", "Fecha");
            dgv_Sightings.Columns["SightingDateTime"].DataPropertyName = "SightingDateTime";
            dgv_Sightings.Columns["SightingDateTime"].DefaultCellStyle.Format = "g"; 
            dgv_Sightings.Columns["SightingDateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Sightings.Columns.Add("SightingDescription", "Descripción");
            dgv_Sightings.Columns["SightingDescription"].DataPropertyName = "SightingDescription";
            dgv_Sightings.Columns["SightingDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Sightings.Columns.Add("SightingState", "Estado");
            dgv_Sightings.Columns["SightingState"].DataPropertyName = "SightingState";
            dgv_Sightings.Columns["SightingState"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btn_FilterIncoming_Click(object sender, EventArgs e)
        {
            if (_sightings == null) return;
            dgv_Sightings.DataSource = _sightings.Where(s => s.SightingState == "Nuevo").ToList();
        }

        private void btn_FilterSeen_Click(object sender, EventArgs e)
        {
            if (_sightings == null) return;
            dgv_Sightings.DataSource = _sightings.Where(s => s.SightingState == "Atendido").ToList();
        }

        private async void btn_DeleteSighting_Click(object sender, EventArgs e)
        {
            if (dgv_Sightings.CurrentRow == null) return;

            var sighting = (SightingDTO)dgv_Sightings.CurrentRow.DataBoundItem;

            var confirm = MessageBox.Show("¿Está seguro de eliminar este avistamiento?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            SightingDTOClient sightingClient = ApiClientsFactory.SightingClient();
            var res = await sightingClient.DisableSighting(sighting.Id);

            if (!res.Success)
            {
                MessageBox.Show(res.Message,
                                "Acción no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            

            MessageBox.Show("El avistamiento ha sido eliminado correctamente.",
                            "Eliminado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            var sightingResult = await sightingClient.GetAllAsync();
            if(sightingResult.Success && sightingResult.Data != null)
                _sightings = sightingResult.Data;
            dgv_Sightings.DataSource = _sightings;
        }


        private async void btn_ConfirmSighting_Click(object sender, EventArgs e)
        {
            if (dgv_Sightings.CurrentRow == null) return;

            var selected = (SightingDTO)dgv_Sightings.CurrentRow.DataBoundItem;

            if (selected.SightingState != "Nuevo")
            {
                MessageBox.Show("Solo se pueden confirmar avistamientos con estado 'Nuevo'.",
                                "Acción no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            selected.SightingState = "Atendido";
            var apiClient = ApiClientsFactory.SightingClient();
            var result = await apiClient.PutAsync(selected.Id, selected);
            if (result.Success)
            {
                MessageBox.Show("El avistamiento ha sido marcado como atendido.",
                                            "Confirmación",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Error al actualizar el avistamiento: {result.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            SightingMenuLoadAsync(null, null);
        }
    
    }
}