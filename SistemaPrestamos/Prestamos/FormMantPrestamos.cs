using LOGICA.LClientes;
using LOGICA.LPrestamos;
using LOGICA.LUsuarios;
using SistemaPrestamos.Clientes;
using SistemaPrestamos.Enums;
using SistemaPrestamos.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos.Prestamos
{
    public partial class FormMantPrestamos : Form
    {
        public bool busqueda = false;
        public int idPrestamo = 0;
        public FormMantPrestamos()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaPrestamos_Load(object sender, EventArgs e)
        {
            CargarComboTipoFondos();
            CargarComboRegionales();

            //desabilitar botones
            foreach (Control item in this.Controls)
            {
                if(item is Button)
                {
                    if (!item.Name.Equals("BtnCerrar"))
                    {
                        item.Enabled = false;
                    }
                }
            }

            //validar
            validaciones.seguridadClientes(this.Controls, this.AccessibleName);

            if (busqueda)
            {
                txtClienteId.Enabled = false;
                txtDiaFechaPagoMensual.Enabled = false;
                txtDiaFechaPagoMensual.Enabled = false;
                txtMontoOtorgado.Enabled = false;
                txtPorcentajeTasaInteres.Enabled = false;
                txtPlazoMeses.Enabled = false;
                cbFondos.Enabled = false;
                cbRegional.Enabled = false;
                dateTimePicker1.Enabled = false;
                btnNuevo.Enabled = false;
                txtInteresMoratorio.Enabled = false;
                txtGastiAdmin.Enabled = false;
                GridDetallePresmosCliente.DataSource = scriptPrestamos.getDataCuotasPrestamosClientes(idPrestamo);
                GridDetallePresmosCliente.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                GridDetallePresmosCliente.Columns[2].DefaultCellStyle.Format = "N2";
                GridDetallePresmosCliente.Columns[3].DefaultCellStyle.Format = "N2";
                GridDetallePresmosCliente.Columns[4].DefaultCellStyle.Format = "N2";
                GridDetallePresmosCliente.Columns[5].DefaultCellStyle.Format = "N2";
                GridDetallePresmosCliente.Columns[6].DefaultCellStyle.Format = "N2";
                GridDetallePresmosCliente.Columns[7].DefaultCellStyle.Format = "N2";
                txtValorClicloPagar.Text = Math.Round(decimal.Parse(scriptPrestamos.getValorCiclo(idPrestamo)),2).ToString();
                if (txtValorClicloPagar.Text.Equals("0"))
                {
                    txtNoTransaccion.Enabled = false;
                    txtMontoTransaccionRecibido.Enabled = false;
                    btnPagar.Enabled = false;
                }
            }
            else
            {
                lblNoTransaccion.Visible = false;
                btnPagar.Visible = false;
                txtNoTransaccion.Visible = false;
                lblMontoTransaccion.Visible = false;
                txtMontoTransaccionRecibido.Visible = false;
                btnMostrarReporte.Visible = false;
            }

        }

        private void backgroundCuotas()
        {
            for (int i = 0; i < GridDetallePresmosCliente.Rows.Count - 1; i++)
            {
                var rows = GridDetallePresmosCliente.Rows[i];
                if (rows.Cells[13].Value.Equals("PAGADO"))
                {
                    for (int j = 0; j < rows.Cells.Count; j++)
                    {
                        var cells = rows.Cells[j];
                        cells.Style.ForeColor = Color.White;
                        cells.Style.BackColor = Color.Red;
                    }
                }
                if (rows.Cells[13].Value.Equals("PENDIENTE"))
                {
                    for (int j = 0; j < rows.Cells.Count; j++)
                    {
                        var cells = rows.Cells[j];

                    }
                }
                if (rows.Cells[13].Value.Equals("ATRASADO"))
                {
                    rows.Cells[0].Value = "56454";
                    rows.Cells[0].Style.ForeColor = Color.Red;
                    for (int j = 0; j < rows.Cells.Count; j++)
                    {
                        var cells = rows.Cells[j];
                        GridDetallePresmosCliente.Rows[0].Cells[0].Style.ForeColor = Color.White;
                        GridDetallePresmosCliente.Rows[0].Cells[0].Style.BackColor = Color.Red;
                        cells.Style.BackColor = Color.Green;
                        GridDetallePresmosCliente.CellFormatting += new DataGridViewCellFormattingEventHandler(this.GridDetallePresmosCliente_CellFormatting); this.Controls.Add(GridDetallePresmosCliente);
                    }
                }
            }
        }
        
       
        private void CargarComboTipoFondos()
        {
            try
            {
                cbFondos.ValueMember = "ID";
                cbFondos.DisplayMember = "FONDO";
                cbFondos.DataSource = scriptPrestamos.cbFondos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
        }

        private void GridDetallePresmosCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            DataGridView dgv = sender as DataGridView;
            
            if (e.Value != null && e.Value.ToString().Trim() == "ATRASADO") 
            { 
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.BackColor = Color.Red;
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            if (e.Value != null && e.Value.ToString().Trim() == "PENDIENTE")
            { 
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.BackColor = Color.Orange;
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            if (e.Value != null && e.Value.ToString().Trim() == "PAGADO")
            {
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.BackColor = Color.Green;
                dgv.Rows[e.RowIndex].Cells["ESTADO"].Style.ForeColor = Color.White;
            }

        }

        private void CargarComboRegionales()
        {
            try
            {
                cbRegional.ValueMember = "ID";
                cbRegional.DisplayMember = "REGIONAL";
                cbRegional.DataSource = scriptPrestamos.cbRegionales();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR: \n {ex.Message.ToString()}");
            }
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            GridDetallePresmosCliente.DataSource = scriptPrestamos.getDataPrestamosClientes();
        }

        private void txtClienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                FormListaClientes hijo = new FormListaClientes();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                hijo.Dock = DockStyle.Fill;
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.BringToFront();
                hijo.busqueda = true;
                hijo.Show();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDiaFechaPagoMensual.Text = dateTimePicker1.Value.Day.ToString() + " de cada mes";
        }

        private void txtClienteId_Leave_1(object sender, EventArgs e)
        {
            int id = 0;
            if (txtClienteId.Text.Equals("") || !int.TryParse(txtClienteId.Text, out id))
            {
                txtClienteNombre.Text = "";
                return;
            }
            DataTable cliente = new DataTable();
            cliente = scriptClientes.getDataClienteId(int.Parse(txtClienteId.Text));
            if (cliente.Rows.Count > 0)
            {
                txtClienteId.Text = cliente.Rows[0]["ID"].ToString();
                txtClienteNombre.Text = cliente.Rows[0]["NOMBRES"].ToString() + " " + cliente.Rows[0]["APELLIDOS"].ToString();
            }
            else
            {
                MessageBox.Show(null, "El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool valido()
        {
            int numero = 0;

            if(!int.TryParse(txtPorcentajeTasaInteres.Text, out numero))
            {
                MessageBox.Show("La tasa de interes debe ser numerico","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtInteresMoratorio.Text, out numero))
            {
                MessageBox.Show("La tasa de interes moratorio debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtPlazoMeses.Text, out numero))
            {
                MessageBox.Show("El plazo en meses debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtMontoOtorgado.Text, out numero))
            {
                MessageBox.Show("El monto otorgado debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtGastiAdmin.Text, out numero))
            {
                MessageBox.Show("Los gastos administrativos debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtClienteId.Text, out numero))
            {
                MessageBox.Show("Debe ingresar el cliente a quien le esta otorgando el prestamo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!busqueda)
            {
                if (!valido())
                {
                    return;
                }
              int creado = scriptPrestamos.insertPrestamo(int.Parse(txtClienteId.Text),int.Parse(cbFondos.SelectedValue.ToString()),int.Parse(cbRegional.SelectedValue.ToString()),
                    Math.Round(decimal.Parse(txtMontoOtorgado.Text),2), (int)PeriodosEnum.Mensual,int.Parse(txtPlazoMeses.Text),dateTimePicker1.Value,
                    Math.Round(decimal.Parse(txtPorcentajeTasaInteres.Text),2), GridDetallePresmosCliente, Math.Round(decimal.Parse(txtGastiAdmin.Text),2), Math.Round(decimal.Parse(txtInteresMoratorio.Text),2));
                if (creado>0)
                {
                    idPrestamo = creado;
                    txtNoTransaccion.Visible = true;
                    txtMontoTransaccionRecibido.Visible = true;
                    btnPagar.Visible = true;
                    btnMostrarReporte.Visible = true;
                    GridDetallePresmosCliente.DataSource = scriptPrestamos.getDataCuotasPrestamosClientes(creado);
                }
                else
                {
                    MessageBox.Show(null, "Error al insertar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtValorClicloPagar.Text = scriptPrestamos.getValorCiclo(idPrestamo);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (txtNoTransaccion.Text.Equals("") || txtMontoTransaccionRecibido.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el numero y/ó el monto de la transacción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtMontoTransaccionRecibido.Text, out numero))
            {
                MessageBox.Show("El monto a pagar debe ser numerico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (scriptPrestamos.esMontoValidoAPagar(idPrestamo, Math.Round(decimal.Parse(txtMontoTransaccionRecibido.Text),2)) == false)
            {
                MessageBox.Show(null, "El monto a pagar no es válido\n Excede el saldo pendiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (scriptPrestamos.insertCuotaPrestamo(idPrestamo,txtNoTransaccion.Text, decimal.Parse(txtMontoTransaccionRecibido.Text)))
            {
                MessageBox.Show(null, "Pagado", "Pagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecalcularValorAPagar();
                GridDetallePresmosCliente.DataSource = scriptPrestamos.getDataCuotasPrestamosClientes(idPrestamo);
            }
        }

        private void RecalcularValorAPagar()
        {
            txtValorClicloPagar.Text = scriptPrestamos.getValorCiclo(idPrestamo);
            txtNoTransaccion.Text = "";
            txtMontoTransaccionRecibido.Text = "";
            if (txtValorClicloPagar.Text.Equals("0.00"))
            {
                txtMontoTransaccionRecibido.Enabled = false;
                txtNoTransaccion.Enabled = false;
                btnPagar.Enabled = false;
            }
        }

        private void txtValorClicloPagar_Click(object sender, EventArgs e)
        {
            txtMontoTransaccionRecibido.Text = txtValorClicloPagar.Text;
        }

        private void txtValorClicloPagar_TextChanged(object sender, EventArgs e)
        {
            RecalcularValorAPagar();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            FormReportePrestamos reporte = new FormReportePrestamos();
            reporte.preId = idPrestamo;
            reporte.Show();
        }
    }
}
