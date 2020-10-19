namespace LOCA_CAR
{
    partial class RelatorioAluguel
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_locaçãoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Loca_CarDataSet = new LOCA_CAR.Loca_CarDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_locaçãoTableAdapter = new LOCA_CAR.Loca_CarDataSetTableAdapters.tb_locaçãoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_locaçãoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loca_CarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_locaçãoBindingSource
            // 
            this.tb_locaçãoBindingSource.DataMember = "tb_locação";
            this.tb_locaçãoBindingSource.DataSource = this.Loca_CarDataSet;
            // 
            // Loca_CarDataSet
            // 
            this.Loca_CarDataSet.DataSetName = "Loca_CarDataSet";
            this.Loca_CarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Locação";
            reportDataSource2.Value = this.tb_locaçãoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LOCA_CAR.Relatorios.RelatorioLocação.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(815, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_locaçãoTableAdapter
            // 
            this.tb_locaçãoTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 469);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioAluguel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Aluguel";
            this.Load += new System.EventHandler(this.RelatorioAluguel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tb_locaçãoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loca_CarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_locaçãoBindingSource;
        private Loca_CarDataSet Loca_CarDataSet;
        private Loca_CarDataSetTableAdapters.tb_locaçãoTableAdapter tb_locaçãoTableAdapter;
    }
}