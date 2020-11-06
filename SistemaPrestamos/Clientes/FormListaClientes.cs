﻿using LOGICA.LClientes;
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

namespace SistemaPrestamos.Clientes
{
    public partial class FormListaClientes : Form
    {
        public bool busqueda = false;
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            //CARGAR GRID

            GridClientes.DataSource = scriptClientes.getDataCliente();

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
            if (GridClientes.SelectedRows.Count > 0)
            {
                FormMantCliente frm = new FormMantCliente();
                frm.txtid.Text= GridClientes.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = GridClientes.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = GridClientes.CurrentRow.Cells[2].Value.ToString();
                frm.txtNumeroIdentidad.Text = GridClientes.CurrentRow.Cells[3].Value.ToString();
                frm.txtRTN.Text = GridClientes.CurrentRow.Cells[4].Value.ToString();
                frm.txtCorreo.Text = GridClientes.CurrentRow.Cells[5].Value.ToString();
                frm.txtTelefono.Text = GridClientes.CurrentRow.Cells[6].Value.ToString();
                frm.txtDireccion.Text = GridClientes.CurrentRow.Cells[7].Value.ToString();
                frm.IsInsert = false;
                frm.FormClosed += new FormClosedEventHandler(Form3_Closed);
                frm.ShowDialog();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void Form3_Closed(object sender, EventArgs e)
        {
            GridClientes.DataSource = scriptClientes.getDataCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.IsInsert = true;
            frm.FormClosed += new FormClosedEventHandler(Form3_Closed);
            frm.ShowDialog();
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (busqueda)
            {
                FormMembresia frm = Owner as FormMembresia;
                //FormMembresia frm = new FormMembresia();

                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }*/
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
            if (GridClientes.SelectedRows.Count == 1)
            {
                if (MessageBox.Show($"¿Está seguro de eliminar al usuario: {GridClientes.CurrentRow.Cells[1].Value.ToString()}?",
                    "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    scriptClientes.deleteCliente(Convert.ToInt32(GridClientes.CurrentRow.Cells[0].Value.ToString()));
                    GridClientes.DataSource = scriptClientes.getDataCliente();
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
