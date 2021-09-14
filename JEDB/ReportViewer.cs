using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JEDB.Data_Access;

namespace JEDB
{
    public partial class frmReportViewer : Form
    {
        private readonly string _reportName;

        public frmReportViewer(string reportName = "DebitNote.rpt")
        {
            InitializeComponent();
            _reportName = reportName;
            LoadReport();
            
        }

        private void LoadReport()
        {
            string reportPath = GetReportPath.GetReportPathFromDB();
            List<string> userData = GetReportPath.GetUserNamePassword();

            ReportDocument cryRpt = new ReportDocument();
            
            cryRpt.Load(@reportPath + _reportName);

            cryRpt.SetDatabaseLogon(userData[0], userData[1]);

            crystalReportViewerJEDB.ReportSource = cryRpt;

            crystalReportViewerJEDB.Refresh();
        }
    }
}
