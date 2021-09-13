
namespace JEDB
{
    partial class frmReportViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewerJEDB = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerJEDB
            // 
            this.crystalReportViewerJEDB.ActiveViewIndex = 0;
            this.crystalReportViewerJEDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerJEDB.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerJEDB.DisplayStatusBar = false;
            this.crystalReportViewerJEDB.DisplayToolbar = false;
            this.crystalReportViewerJEDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerJEDB.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerJEDB.Name = "crystalReportViewerJEDB";
            this.crystalReportViewerJEDB.Size = new System.Drawing.Size(1262, 731);
            this.crystalReportViewerJEDB.TabIndex = 0;
            this.crystalReportViewerJEDB.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 731);
            this.Controls.Add(this.crystalReportViewerJEDB);
            this.Name = "frmReportViewer";
            this.Text = "ReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerJEDB;
    }
}