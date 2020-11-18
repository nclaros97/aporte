using LOGICA.LClientes;
using LOGICA.LPrestamos;
using LOGICA.LUsuarios;
using SistemaPrestamos.Clientes;
using SistemaPrestamos.Enums;
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

            //CARGAR COMBOBOX DE TIPOS DE FONDOS

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
                btnNuevo.Enabled = false;
                GridDetallePresmosCliente.DataSource = scriptPrestamos.getDataCuotasPrestamosClientes(idPrestamo);
                GridDetallePresmosCliente.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                GridDetallePresmosCliente.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                GridDetallePresmosCliente.Columns[4].DefaultCellStyle.Format = "N";

                GridDetallePresmosCliente.Columns[5].DefaultCellStyle.Format = "N";
                GridDetallePresmosCliente.Columns[6].DefaultCellStyle.Format = "N";
                GridDetallePresmosCliente.Columns[7].DefaultCellStyle.Format = "N";
                GridDetallePresmosCliente.Columns[8].DefaultCellStyle.Format = "N";
            }
            else
            {
                lblNoTransaccion.Visible = false;
                btnPagar.Visible = false;
                txtNoTransaccion.Visible = false;
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
            //GridDetallePresmosCliente.DataSource = scriptClientes.getDataCliente();
        }

        private void txtClienteId_Leave(object sender, EventArgs e)
        {
            if (txtClienteId.AutoCompleteCustomSource.Contains(txtClienteId.Text))
            {
                
            }
        }

        public void SetDataCliente(string Id, string Nombre)
        {
            MessageBox.Show(Id + " " + Nombre);
            txtClienteId.Text = Id;
            txtClienteNombre.Text = Nombre;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDiaFechaPagoMensual.Text = dateTimePicker1.Value.Day.ToString() + " de cada mes";
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClienteId_Leave_1(object sender, EventArgs e)
        {
            DataTable cliente = new DataTable();
            cliente = scriptClientes.getDataClienteId(int.Parse(txtClienteId.Text));
            if (cliente.Rows.Count > 0)
            {
                txtClienteId.Text = cliente.Rows[0]["ID"].ToString();
                txtClienteNombre.Text = cliente.Rows[0]["NOMBRES"].ToString() + " " + cliente.Rows[0]["APELLIDOS"].ToString();
            }
            else
            {
                MessageBox.Show(null,"El cliente no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (busqueda)
            {
              bool creado = scriptPrestamos.insertPrestamo(int.Parse(txtClienteId.Text),int.Parse(cbFondos.SelectedValue.ToString()),int.Parse(cbRegional.SelectedValue.ToString()),
                    float.Parse(txtMontoOtorgado.Text), (int)PeriodosEnum.Mensual,int.Parse(txtPlazoMeses.Text),dateTimePicker1.Value,
                    float.Parse(txtPorcentajeTasaInteres.Text), GridDetallePresmosCliente);
                if (creado)
                {
                    //this.Close();
                }
                else
                {
                    MessageBox.Show(null, "Error al insertar registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Editar");
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtNoTransaccion.Text.Equals(""))
            {
                MessageBox.Show(null, "Ingrese el numero transaccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(GridDetallePresmosCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show(null, "Seleccione la fila de la cuota a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GridDetallePresmosCliente.SelectedRows.Count > 1)
            {
                MessageBox.Show(null, "Seleccione la fila de la cuota a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(null, "Pagado", "Pagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
