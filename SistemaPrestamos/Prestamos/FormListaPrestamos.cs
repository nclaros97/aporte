using LOGICA.LClientes;
using LOGICA.LPrestamos;
using LOGICA.LUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos.Prestamos
{
    public partial class FormListaPrestamos : Form
    {
        public bool busqueda = false;
        public FormListaPrestamos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaPrestamos_Load(object sender, EventArgs e)
        {
            //CARGAR GRID
            
            GridPresmosCliente.DataSource = scriptPrestamos.getDataPrestamosClientes();
            if(GridPresmosCliente.Rows.Count == 0)
            {
                MessageBox.Show(null,"No hay datos registrados","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //CARGAR COMBOBOX DE TIPOS DE FONDOS
            GridPresmosCliente.Columns[10].Visible = false;
            GridPresmosCliente.Columns[11].Visible = false;
            GridPresmosCliente.Columns[5].DefaultCellStyle.Format = "N";
            GridPresmosCliente.Columns[6].DefaultCellStyle.Format = "N";

            GridPresmosCliente.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            GridPresmosCliente.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";
            GridPresmosCliente.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy";

            CargarComboTipoFondos();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (GridPresmosCliente.SelectedRows.Count > 0)
            {
                DataTable prestamo = scriptPrestamos.getDataPrestamoClienteId(int.Parse(GridPresmosCliente.CurrentRow.Cells[10].Value.ToString()));

                FormMantPrestamos hijo = new FormMantPrestamos();
                AddOwnedForm(hijo);
                hijo.FormBorderStyle = FormBorderStyle.None;
                hijo.TopLevel = false;
                hijo.Dock = DockStyle.Fill;
                hijo.FormClosed += new FormClosedEventHandler(Form3_Closed);
                this.Controls.Add(hijo);
                this.Tag = hijo;
                hijo.busqueda = true;
                hijo.txtClienteId.Text = prestamo.Rows[0]["CLIID"].ToString();
                hijo.txtClienteNombre.Text = prestamo.Rows[0]["NOMBRE"].ToString();
                hijo.idPrestamo = int.Parse(prestamo.Rows[0]["ID"].ToString());
                hijo.cbFondos.SelectedItem = prestamo.Rows[0]["fonId"].ToString();
                hijo.cbRegional.SelectedItem = prestamo.Rows[0]["regId"].ToString();
                hijo.txtPorcentajeTasaInteres.Text = prestamo.Rows[0]["INTERES"].ToString();
                hijo.txtPlazoMeses.Text = prestamo.Rows[0]["PLAZO"].ToString();
                hijo.txtGastiAdmin.Text = prestamo.Rows[0]["GASTOADM"].ToString();
                hijo.txtMontoOtorgado.Text = prestamo.Rows[0]["MONTO L"].ToString();
                hijo.dateTimePicker1.Value = DateTime.Parse(prestamo.Rows[0]["PAGO INICIAL"].ToString());
                hijo.txtInteresMoratorio.Text = prestamo.Rows[0]["preInteresMoratorio"].ToString();
                hijo.BringToFront();
                hijo.Show();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            GridPresmosCliente.DataSource = scriptPrestamos.getDataPrestamosClientes();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantPrestamos hijo = new FormMantPrestamos();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            hijo.FormClosed += new FormClosedEventHandler(Form3_Closed);
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Equals("Buscar prestamo de cliente"))
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Buscar prestamo de cliente";
                txtBuscar.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GridPresmosCliente.SelectedRows.Count == 1)
            {
                if (MessageBox.Show($"¿Está seguro de eliminar al prestamo?",
                    "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scriptPrestamos.deletePrestamo(Convert.ToInt32(GridPresmosCliente.CurrentRow.Cells[10].Value.ToString()));
                    GridPresmosCliente.DataSource = scriptPrestamos.getDataPrestamosClientes();
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada");
                }
            }
            else
                MessageBox.Show("seleccione una fila para poder eliminar por favor");
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            GridPresmosCliente.DataSource = scriptPrestamos.getDataPrestamosClientesBusqueda(txtBuscar.Text);
        }
    }
}
