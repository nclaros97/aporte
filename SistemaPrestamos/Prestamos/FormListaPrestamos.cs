using LOGICA.LClientes;
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

            GridPresmosCliente.DataSource = scriptClientes.getDataCliente();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (GridPresmosCliente.SelectedRows.Count > 0)
            //{
            //    FormMantPrestamos frm = new FormMantPrestamos();
            //    frm.txtid.Text= GridPresmosCliente.CurrentRow.Cells[0].Value.ToString();
            //    frm.txtnombre.Text = GridPresmosCliente.CurrentRow.Cells[1].Value.ToString();
            //    frm.txtapellido.Text = GridPresmosCliente.CurrentRow.Cells[2].Value.ToString();
            //    frm.txtNumeroIdentidad.Text = GridPresmosCliente.CurrentRow.Cells[3].Value.ToString();
            //    frm.txtRTN.Text = GridPresmosCliente.CurrentRow.Cells[4].Value.ToString();
            //    frm.txtCorreo.Text = GridPresmosCliente.CurrentRow.Cells[5].Value.ToString();
            //    frm.txtTelefono.Text = GridPresmosCliente.CurrentRow.Cells[6].Value.ToString();
            //    frm.txtDireccion.Text = GridPresmosCliente.CurrentRow.Cells[7].Value.ToString();
            //    frm.IsInsert = false;
            //    frm.FormClosed += new FormClosedEventHandler(Form3_Closed);
            //    frm.ShowDialog();
             
            //}
            //else
            //    MessageBox.Show("seleccione una fila por favor");
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            GridPresmosCliente.DataSource = scriptClientes.getDataCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //FormMantPrestamos frm = new FormMantPrestamos();
            //frm.IsInsert = true;
            //frm.FormClosed += new FormClosedEventHandler(Form3_Closed);
            //frm.ShowDialog();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text.Equals("Buscar cliente"))
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals(""))
            {
                txtBuscar.Text = "Buscar cliente";
                txtBuscar.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Buscar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GridPresmosCliente.SelectedRows.Count == 1)
            {
                if (MessageBox.Show($"¿Está seguro de eliminar al usuario: {GridPresmosCliente.CurrentRow.Cells[1].Value.ToString()}?",
                    "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scriptClientes.deleteCliente(Convert.ToInt32(GridPresmosCliente.CurrentRow.Cells[0].Value.ToString()));
                    GridPresmosCliente.DataSource = scriptClientes.getDataCliente();
                }
                else
                {
                    MessageBox.Show("Eliminacion cancelada");
                }
            }
            else
                MessageBox.Show("seleccione una fila para poder eliminar por favor");
        }
    }
}
