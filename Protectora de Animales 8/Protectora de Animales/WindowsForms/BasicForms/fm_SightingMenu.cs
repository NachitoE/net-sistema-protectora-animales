using DTOs;
using DTOs.Sighting;
using Helpers;
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

            SightingDTOClient sightingClient = new SightingDTOClient(new APIHttpClient());
            List<SightingDTO> sightings = await sightingClient.GetAllSightingsAsync();

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

            if (sighting.SightingState != "Nuevo")
            {
                MessageBox.Show("Solo se pueden eliminar avistamientos con estado 'Nuevo'.",
                                "Acción no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro de eliminar este avistamiento?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            sighting.SightingState = "Eliminado";
            SightingDTOClient sightingClient = new SightingDTOClient(new APIHttpClient());
            await sightingClient.UpdateSighting(sighting.Id, "Eliminado");

            MessageBox.Show("El avistamiento ha sido eliminado correctamente.",
                            "Eliminado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            _sightings = await sightingClient.GetAllSightingsAsync();
            dgv_Sightings.DataSource = _sightings;
        }


        private async  void btn_ConfirmSighting_Click(object sender, EventArgs e)
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
            using var apiClient = new APIHttpClient("https://localhost:7056/");
            var updated = await apiClient.PutAsync<SightingDTO>($"sightings/{selected.Id}", selected);
            MessageBox.Show("El avistamiento ha sido marcado como atendido.",
                            "Confirmación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            SightingMenuLoadAsync(null, null);
        }
    
    }
}