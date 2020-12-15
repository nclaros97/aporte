
namespace SistemaPrestamos.Reportes
{
    partial class FormReportePrestamos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportePrestamoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CuotasPrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasPrestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportePrestamo";
            reportDataSource1.Value = this.ReportePrestamoClienteBindingSource;
            reportDataSource2.Name = "Prestamo";
            reportDataSource2.Value = this.PrestamoBindingSource;
            reportDataSource3.Name = "Cuotas";
            reportDataSource3.Value = this.CuotasPrestamoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaPrestamos.Reportes.ReportePrestamo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(810, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportePrestamoClienteBindingSource
            // 
            this.ReportePrestamoClienteBindingSource.DataSource = typeof(LOGICA.LPrestamos.ReportePrestamoCliente);
            // 
            // PrestamoBindingSource
            // 
            this.PrestamoBindingSource.DataSource = typeof(LOGICA.LPrestamos.Prestamo);
            // 
            // CuotasPrestamoBindingSource
            // 
            this.CuotasPrestamoBindingSource.DataSource = typeof(LOGICA.LPrestamos.CuotasPrestamo);
            // 
            // FormReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 575);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportePrestamos";
            this.Text = "FormReportePrestamos";
            this.Load += new System.EventHandler(this.FormReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CuotasPrestamoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportePrestamoClienteBindingSource;
        private System.Windows.Forms.BindingSource PrestamoBindingSource;
        private System.Windows.Forms.BindingSource CuotasPrestamoBindingSource;
    }
}