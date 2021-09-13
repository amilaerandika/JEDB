using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JEDB
{
    public partial class JEDB : Form
    {
        public JEDB()
        {
            InitializeComponent();
        }

        private void DebitNoteButton_Click(object sender, EventArgs e)
        {
            ReminderPages.SetPage("tabPage5");
        }

        private void FirstReminderButton_Click(object sender, EventArgs e)
        {
            ReminderPages.SetPage("tabPage3");
        }

        private void SecondReminderButton_Click(object sender, EventArgs e)
        {
            ReminderPages.SetPage("tabPage4");
        }

        private void EvictionButton_Click(object sender, EventArgs e)
        {
            ReminderPages.SetPage("tabPage6");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AddData frmAddData = new AddData();
            frmAddData.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage7");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            frmReportViewer frmReportViewer = new frmReportViewer();
            frmReportViewer.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage9");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage1");
        }

        private void AddLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void debitnotenotitale_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
