﻿namespace CoX_Character_Information
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.characterDataSet = new CoX_Character_Information.characterDataSet();
            this.characterTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableTableAdapter = new CoX_Character_Information.characterDataSetTableAdapters.characterTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "characterDataSet_characterTable";
            reportDataSource1.Value = this.characterTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CoX_Character_Information.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 264);
            this.reportViewer1.TabIndex = 0;
            // 
            // characterDataSet
            // 
            this.characterDataSet.DataSetName = "characterDataSet";
            this.characterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characterTableBindingSource
            // 
            this.characterTableBindingSource.DataMember = "characterTable";
            this.characterTableBindingSource.DataSource = this.characterDataSet;
            // 
            // characterTableTableAdapter
            // 
            this.characterTableTableAdapter.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource characterTableBindingSource;
        private characterDataSet characterDataSet;
        private CoX_Character_Information.characterDataSetTableAdapters.characterTableTableAdapter characterTableTableAdapter;
    }
}