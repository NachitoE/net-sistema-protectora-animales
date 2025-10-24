using Infrastructure.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Handlers;

namespace WindowsForms.menuAdmin
{
    public partial class fm_AdminReportsMenu : Form
    {
        public fm_AdminReportsMenu()
        {
            InitializeComponent();
        }

        private async void btn_AdoptionReport_Click(object sender, EventArgs e)
        {
            var cli = ApiClientsFactory.ReportClient(new WinFormDownloadHandler());
            await cli.DownloadAdoptionMonthReportAsync();
        }

        private async void btn_CaretakersHReport_Click(object sender, EventArgs e)
        {
            var cli = ApiClientsFactory.ReportClient(new WinFormDownloadHandler());
            await cli.DownloadAnimalsHistoryAsync();
        }
    }
}
