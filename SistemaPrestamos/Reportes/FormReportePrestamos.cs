using LOGICA.LPrestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos.Reportes
{
    public partial class FormReportePrestamos : Form
    {
        public int preId;
        public FormReportePrestamos()
        {
            InitializeComponent();
        }

        private void FormReportePrestamos_Load(object sender, EventArgs e)
        {
            getPrestamo();
        }

        private void getPrestamo()
        {
            ReportePrestamoCliente reporte = new ReportePrestamoCliente();
            reporte.crearReportePrestamo(preId);

            ReportePrestamoClienteBindingSource.DataSource = reporte;
            this.reportViewer1.RefreshReport();
        }
    }
}
