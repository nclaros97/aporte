
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportePrestamoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReportePrestamoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReporteDePrestamoCliente";
            reportDataSource1.Value = this.ReportePrestamoClienteBindingSource;
            reportDataSource2.Name = "Cuotas";
            reportDataSource2.Value = this.ReportePrestamoClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaPrestamos.Reportes.Prestamo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(114, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(696, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportePrestamoClienteBindingSource
            // 
            this.ReportePrestamoClienteBindingSource.DataSource = typeof(LOGICA.LPrestamos.ReportePrestamoCliente);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReportePrestamoClienteBindingSource;
    }
}