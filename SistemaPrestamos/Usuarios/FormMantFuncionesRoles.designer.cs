﻿namespace SistemaVentaFacturacion.Usuarios
{
    partial class FormMantFuncionesRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbAsignarPermisos = new System.Windows.Forms.GroupBox();
            this.chkbAccion = new System.Windows.Forms.CheckBox();
            this.lblFunRol = new System.Windows.Forms.Label();
            this.cbPermisos = new System.Windows.Forms.ComboBox();
            this.btnAsignarPermiso = new System.Windows.Forms.Button();
            this.txtBuscarPermisoRol = new System.Windows.Forms.TextBox();
            this.GridPermiso = new System.Windows.Forms.DataGridView();
            this.Eliminar_Permiso_Asignado = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbAsignarRol = new System.Windows.Forms.GroupBox();
            this.lblFuncionActual = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.txtBuscarFuncionRol = new System.Windows.Forms.TextBox();
            this.btnAsignarPermisoAc = new System.Windows.Forms.Button();
            this.GridRolFuncion = new System.Windows.Forms.DataGridView();
            this.Editar_Funcion_Rol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAsignarRol = new System.Windows.Forms.Button();
            this.gbFunciones = new System.Windows.Forms.GroupBox();
            this.btnCancelarAccionFuncion = new System.Windows.Forms.Button();
            this.txtBuscarFuncion = new System.Windows.Forms.TextBox();
            this.btnAsignarRolAc = new System.Windows.Forms.Button();
            this.GridFunciones = new System.Windows.Forms.DataGridView();
            this.Editar_Funcion = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar_Funcion = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbAsignarPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermiso)).BeginInit();
            this.gbAsignarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRolFuncion)).BeginInit();
            this.gbFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1350, 38);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.AccessibleName = "Cerrar";
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SistemaPrestamos.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(1313, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(38, 38);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SistemaPrestamos.Properties.Resources.editar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 251;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 250;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFunciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 729);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbAsignarRol);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(686, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 729);
            this.panel2.TabIndex = 4;
            // 
            // gbAsignarPermisos
            // 
            this.gbAsignarPermisos.AccessibleName = "Formulario Permisos Funcion Rol";
            this.gbAsignarPermisos.Controls.Add(this.chkbAccion);
            this.gbAsignarPermisos.Controls.Add(this.lblFunRol);
            this.gbAsignarPermisos.Controls.Add(this.cbPermisos);
            this.gbAsignarPermisos.Controls.Add(this.btnAsignarPermiso);
            this.gbAsignarPermisos.Controls.Add(this.txtBuscarPermisoRol);
            this.gbAsignarPermisos.Controls.Add(this.GridPermiso);
            this.gbAsignarPermisos.Enabled = false;
            this.gbAsignarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarPermisos.Location = new System.Drawing.Point(686, 407);
            this.gbAsignarPermisos.Name = "gbAsignarPermisos";
            this.gbAsignarPermisos.Size = new System.Drawing.Size(656, 357);
            this.gbAsignarPermisos.TabIndex = 27;
            this.gbAsignarPermisos.TabStop = false;
            this.gbAsignarPermisos.Text = "3 Permisos";
            // 
            // chkbAccion
            // 
            this.chkbAccion.AutoSize = true;
            this.chkbAccion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkbAccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkbAccion.Location = new System.Drawing.Point(293, 74);
            this.chkbAccion.Name = "chkbAccion";
            this.chkbAccion.Size = new System.Drawing.Size(210, 22);
            this.chkbAccion.TabIndex = 28;
            this.chkbAccion.Text = "Permitir/Denegar Accion";
            this.chkbAccion.UseVisualStyleBackColor = true;
            // 
            // lblFunRol
            // 
            this.lblFunRol.AutoSize = true;
            this.lblFunRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFunRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFunRol.Location = new System.Drawing.Point(6, 33);
            this.lblFunRol.Name = "lblFunRol";
            this.lblFunRol.Size = new System.Drawing.Size(221, 24);
            this.lblFunRol.TabIndex = 27;
            this.lblFunRol.Text = "Nombre Rol y Funcion";
            this.lblFunRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPermisos
            // 
            this.cbPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.cbPermisos.DropDownHeight = 100;
            this.cbPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPermisos.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPermisos.FormattingEnabled = true;
            this.cbPermisos.IntegralHeight = false;
            this.cbPermisos.ItemHeight = 24;
            this.cbPermisos.Location = new System.Drawing.Point(6, 69);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(281, 32);
            this.cbPermisos.TabIndex = 26;
            // 
            // btnAsignarPermiso
            // 
            this.btnAsignarPermiso.AccessibleDescription = "Asignar permisos a una funcion con un rol";
            this.btnAsignarPermiso.AccessibleName = "Insertar";
            this.btnAsignarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnAsignarPermiso.FlatAppearance.BorderSize = 0;
            this.btnAsignarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermiso.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPermiso.Location = new System.Drawing.Point(521, 69);
            this.btnAsignarPermiso.Name = "btnAsignarPermiso";
            this.btnAsignarPermiso.Size = new System.Drawing.Size(100, 32);
            this.btnAsignarPermiso.TabIndex = 25;
            this.btnAsignarPermiso.Text = "Asignar";
            this.btnAsignarPermiso.UseVisualStyleBackColor = false;
            this.btnAsignarPermiso.Click += new System.EventHandler(this.btnAsignarPermiso_Click);
            // 
            // txtBuscarPermisoRol
            // 
            this.txtBuscarPermisoRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarPermisoRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPermisoRol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscarPermisoRol.Location = new System.Drawing.Point(0, 107);
            this.txtBuscarPermisoRol.Multiline = true;
            this.txtBuscarPermisoRol.Name = "txtBuscarPermisoRol";
            this.txtBuscarPermisoRol.Size = new System.Drawing.Size(411, 38);
            this.txtBuscarPermisoRol.TabIndex = 23;
            this.txtBuscarPermisoRol.Text = "Buscar permiso";
            this.txtBuscarPermisoRol.Enter += new System.EventHandler(this.txtBuscarPermisoRol_Enter);
            this.txtBuscarPermisoRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPermisoRol_KeyPress);
            this.txtBuscarPermisoRol.Leave += new System.EventHandler(this.txtBuscarPermisoRol_Leave);
            // 
            // GridPermiso
            // 
            this.GridPermiso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPermiso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridPermiso.BackgroundColor = System.Drawing.Color.White;
            this.GridPermiso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPermiso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridPermiso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPermiso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridPermiso.ColumnHeadersHeight = 30;
            this.GridPermiso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar_Permiso_Asignado});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPermiso.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridPermiso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridPermiso.EnableHeadersVisualStyles = false;
            this.GridPermiso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridPermiso.Location = new System.Drawing.Point(3, 148);
            this.GridPermiso.Name = "GridPermiso";
            this.GridPermiso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPermiso.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridPermiso.RowHeadersWidth = 51;
            this.GridPermiso.Size = new System.Drawing.Size(650, 206);
            this.GridPermiso.TabIndex = 21;
            this.GridPermiso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPermiso_CellClick);
            // 
            // Eliminar_Permiso_Asignado
            // 
            this.Eliminar_Permiso_Asignado.HeaderText = "";
            this.Eliminar_Permiso_Asignado.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.Eliminar_Permiso_Asignado.MinimumWidth = 6;
            this.Eliminar_Permiso_Asignado.Name = "Eliminar_Permiso_Asignado";
            this.Eliminar_Permiso_Asignado.ReadOnly = true;
            // 
            // gbAsignarRol
            // 
            this.gbAsignarRol.AccessibleName = "Formulario Roles Funcion";
            this.gbAsignarRol.Controls.Add(this.lblFuncionActual);
            this.gbAsignarRol.Controls.Add(this.cbRoles);
            this.gbAsignarRol.Controls.Add(this.txtBuscarFuncionRol);
            this.gbAsignarRol.Controls.Add(this.btnAsignarPermisoAc);
            this.gbAsignarRol.Controls.Add(this.GridRolFuncion);
            this.gbAsignarRol.Controls.Add(this.btnAsignarRol);
            this.gbAsignarRol.Enabled = false;
            this.gbAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAsignarRol.Location = new System.Drawing.Point(0, 6);
            this.gbAsignarRol.Name = "gbAsignarRol";
            this.gbAsignarRol.Size = new System.Drawing.Size(657, 357);
            this.gbAsignarRol.TabIndex = 26;
            this.gbAsignarRol.TabStop = false;
            this.gbAsignarRol.Text = "2 Asignar Rol";
            // 
            // lblFuncionActual
            // 
            this.lblFuncionActual.AutoSize = true;
            this.lblFuncionActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFuncionActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFuncionActual.Location = new System.Drawing.Point(6, 39);
            this.lblFuncionActual.Name = "lblFuncionActual";
            this.lblFuncionActual.Size = new System.Drawing.Size(168, 24);
            this.lblFuncionActual.TabIndex = 25;
            this.lblFuncionActual.Text = "Nombre Funcion";
            this.lblFuncionActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRoles
            // 
            this.cbRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.cbRoles.DropDownHeight = 100;
            this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRoles.ForeColor = System.Drawing.SystemColors.Window;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.IntegralHeight = false;
            this.cbRoles.ItemHeight = 24;
            this.cbRoles.Location = new System.Drawing.Point(6, 66);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(281, 32);
            this.cbRoles.TabIndex = 24;
            // 
            // txtBuscarFuncionRol
            // 
            this.txtBuscarFuncionRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarFuncionRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFuncionRol.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscarFuncionRol.Location = new System.Drawing.Point(6, 120);
            this.txtBuscarFuncionRol.Multiline = true;
            this.txtBuscarFuncionRol.Name = "txtBuscarFuncionRol";
            this.txtBuscarFuncionRol.Size = new System.Drawing.Size(411, 38);
            this.txtBuscarFuncionRol.TabIndex = 23;
            this.txtBuscarFuncionRol.Text = "Buscar rol asignado a funcion";
            this.txtBuscarFuncionRol.Enter += new System.EventHandler(this.txtBuscarFuncionRol_Enter);
            this.txtBuscarFuncionRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarFuncionRol_KeyPress);
            this.txtBuscarFuncionRol.Leave += new System.EventHandler(this.txtBuscarFuncionRol_Leave);
            // 
            // btnAsignarPermisoAc
            // 
            this.btnAsignarPermisoAc.AccessibleName = "Visualizar";
            this.btnAsignarPermisoAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnAsignarPermisoAc.FlatAppearance.BorderSize = 0;
            this.btnAsignarPermisoAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPermisoAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarPermisoAc.ForeColor = System.Drawing.Color.White;
            this.btnAsignarPermisoAc.Location = new System.Drawing.Point(549, 164);
            this.btnAsignarPermisoAc.Name = "btnAsignarPermisoAc";
            this.btnAsignarPermisoAc.Size = new System.Drawing.Size(111, 35);
            this.btnAsignarPermisoAc.TabIndex = 22;
            this.btnAsignarPermisoAc.Text = "Asignar Permisos";
            this.btnAsignarPermisoAc.UseVisualStyleBackColor = false;
            this.btnAsignarPermisoAc.Click += new System.EventHandler(this.btnAsignarPermisoAc_Click);
            // 
            // GridRolFuncion
            // 
            this.GridRolFuncion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRolFuncion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridRolFuncion.BackgroundColor = System.Drawing.Color.White;
            this.GridRolFuncion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridRolFuncion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridRolFuncion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRolFuncion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridRolFuncion.ColumnHeadersHeight = 30;
            this.GridRolFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar_Funcion_Rol});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRolFuncion.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridRolFuncion.EnableHeadersVisualStyles = false;
            this.GridRolFuncion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridRolFuncion.Location = new System.Drawing.Point(6, 164);
            this.GridRolFuncion.Name = "GridRolFuncion";
            this.GridRolFuncion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRolFuncion.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GridRolFuncion.RowHeadersWidth = 51;
            this.GridRolFuncion.Size = new System.Drawing.Size(537, 180);
            this.GridRolFuncion.TabIndex = 21;
            this.GridRolFuncion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRolFuncion_CellClick);
            // 
            // Editar_Funcion_Rol
            // 
            this.Editar_Funcion_Rol.FillWeight = 20F;
            this.Editar_Funcion_Rol.HeaderText = "";
            this.Editar_Funcion_Rol.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.Editar_Funcion_Rol.MinimumWidth = 15;
            this.Editar_Funcion_Rol.Name = "Editar_Funcion_Rol";
            this.Editar_Funcion_Rol.ReadOnly = true;
            // 
            // btnAsignarRol
            // 
            this.btnAsignarRol.AccessibleDescription = "Asignar rol a una funcion";
            this.btnAsignarRol.AccessibleName = "Insertar";
            this.btnAsignarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnAsignarRol.FlatAppearance.BorderSize = 0;
            this.btnAsignarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRol.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRol.Location = new System.Drawing.Point(293, 66);
            this.btnAsignarRol.Name = "btnAsignarRol";
            this.btnAsignarRol.Size = new System.Drawing.Size(100, 32);
            this.btnAsignarRol.TabIndex = 11;
            this.btnAsignarRol.Text = "Asignar";
            this.btnAsignarRol.UseVisualStyleBackColor = false;
            this.btnAsignarRol.Click += new System.EventHandler(this.btnAsignarRol_Click);
            // 
            // gbFunciones
            // 
            this.gbFunciones.AccessibleName = "Formulario Funciones";
            this.gbFunciones.Controls.Add(this.btnCancelarAccionFuncion);
            this.gbFunciones.Controls.Add(this.txtBuscarFuncion);
            this.gbFunciones.Controls.Add(this.btnAsignarRolAc);
            this.gbFunciones.Controls.Add(this.GridFunciones);
            this.gbFunciones.Controls.Add(this.txtFuncion);
            this.gbFunciones.Controls.Add(this.label8);
            this.gbFunciones.Controls.Add(this.btnConfirmar);
            this.gbFunciones.Controls.Add(this.txtId);
            this.gbFunciones.Controls.Add(this.label5);
            this.gbFunciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFunciones.Location = new System.Drawing.Point(12, 6);
            this.gbFunciones.Name = "gbFunciones";
            this.gbFunciones.Size = new System.Drawing.Size(656, 720);
            this.gbFunciones.TabIndex = 25;
            this.gbFunciones.TabStop = false;
            this.gbFunciones.Text = "1 Funciones";
            // 
            // btnCancelarAccionFuncion
            // 
            this.btnCancelarAccionFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnCancelarAccionFuncion.FlatAppearance.BorderSize = 0;
            this.btnCancelarAccionFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAccionFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAccionFuncion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAccionFuncion.Location = new System.Drawing.Point(317, 85);
            this.btnCancelarAccionFuncion.Name = "btnCancelarAccionFuncion";
            this.btnCancelarAccionFuncion.Size = new System.Drawing.Size(100, 35);
            this.btnCancelarAccionFuncion.TabIndex = 24;
            this.btnCancelarAccionFuncion.Text = "Cancelar";
            this.btnCancelarAccionFuncion.UseVisualStyleBackColor = false;
            this.btnCancelarAccionFuncion.Click += new System.EventHandler(this.btnCancelarAccionFuncion_Click);
            // 
            // txtBuscarFuncion
            // 
            this.txtBuscarFuncion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarFuncion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscarFuncion.Location = new System.Drawing.Point(6, 126);
            this.txtBuscarFuncion.Multiline = true;
            this.txtBuscarFuncion.Name = "txtBuscarFuncion";
            this.txtBuscarFuncion.Size = new System.Drawing.Size(411, 38);
            this.txtBuscarFuncion.TabIndex = 23;
            this.txtBuscarFuncion.Text = "Buscar Funcion";
            this.txtBuscarFuncion.Enter += new System.EventHandler(this.txtBuscarFuncion_Enter);
            this.txtBuscarFuncion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarFuncion_KeyPress);
            this.txtBuscarFuncion.Leave += new System.EventHandler(this.txtBuscarFuncion_Leave);
            // 
            // btnAsignarRolAc
            // 
            this.btnAsignarRolAc.AccessibleName = "Visualizar";
            this.btnAsignarRolAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnAsignarRolAc.FlatAppearance.BorderSize = 0;
            this.btnAsignarRolAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarRolAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRolAc.ForeColor = System.Drawing.Color.White;
            this.btnAsignarRolAc.Location = new System.Drawing.Point(546, 170);
            this.btnAsignarRolAc.Name = "btnAsignarRolAc";
            this.btnAsignarRolAc.Size = new System.Drawing.Size(100, 35);
            this.btnAsignarRolAc.TabIndex = 22;
            this.btnAsignarRolAc.Text = "Asignar Rol";
            this.btnAsignarRolAc.UseVisualStyleBackColor = false;
            this.btnAsignarRolAc.Click += new System.EventHandler(this.btnAsignarRolAc_Click);
            // 
            // GridFunciones
            // 
            this.GridFunciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridFunciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridFunciones.BackgroundColor = System.Drawing.Color.White;
            this.GridFunciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridFunciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridFunciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.GridFunciones.ColumnHeadersHeight = 30;
            this.GridFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar_Funcion,
            this.Eliminar_Funcion});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFunciones.DefaultCellStyle = dataGridViewCellStyle17;
            this.GridFunciones.EnableHeadersVisualStyles = false;
            this.GridFunciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridFunciones.Location = new System.Drawing.Point(3, 170);
            this.GridFunciones.Name = "GridFunciones";
            this.GridFunciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFunciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.GridFunciones.RowHeadersWidth = 51;
            this.GridFunciones.Size = new System.Drawing.Size(537, 547);
            this.GridFunciones.TabIndex = 21;
            this.GridFunciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridFunciones_CellClick);
            // 
            // Editar_Funcion
            // 
            this.Editar_Funcion.FillWeight = 15F;
            this.Editar_Funcion.HeaderText = "";
            this.Editar_Funcion.Image = global::SistemaPrestamos.Properties.Resources.editar;
            this.Editar_Funcion.MinimumWidth = 10;
            this.Editar_Funcion.Name = "Editar_Funcion";
            this.Editar_Funcion.ReadOnly = true;
            // 
            // Eliminar_Funcion
            // 
            this.Eliminar_Funcion.FillWeight = 15F;
            this.Eliminar_Funcion.HeaderText = "";
            this.Eliminar_Funcion.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.Eliminar_Funcion.MinimumWidth = 10;
            this.Eliminar_Funcion.Name = "Eliminar_Funcion";
            this.Eliminar_Funcion.ReadOnly = true;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncion.Location = new System.Drawing.Point(173, 56);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(244, 23);
            this.txtFuncion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AccessibleName = "Insertar";
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(211, 85);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(173, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(244, 23);
            this.txtId.TabIndex = 19;
            this.txtId.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(17, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Funcion:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMantFuncionesRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 767);
            this.Controls.Add(this.gbAsignarPermisos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMantFuncionesRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantCliente";
            this.Load += new System.EventHandler(this.FormMantFuncionesRoles_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbAsignarPermisos.ResumeLayout(false);
            this.gbAsignarPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermiso)).EndInit();
            this.gbAsignarRol.ResumeLayout(false);
            this.gbAsignarRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRolFuncion)).EndInit();
            this.gbFunciones.ResumeLayout(false);
            this.gbFunciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFunciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAsignarPermisos;
        private System.Windows.Forms.CheckBox chkbAccion;
        private System.Windows.Forms.Label lblFunRol;
        private System.Windows.Forms.ComboBox cbPermisos;
        private System.Windows.Forms.Button btnAsignarPermiso;
        private System.Windows.Forms.TextBox txtBuscarPermisoRol;
        private System.Windows.Forms.DataGridView GridPermiso;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar_Permiso_Asignado;
        private System.Windows.Forms.GroupBox gbFunciones;
        private System.Windows.Forms.Button btnCancelarAccionFuncion;
        private System.Windows.Forms.TextBox txtBuscarFuncion;
        private System.Windows.Forms.Button btnAsignarRolAc;
        private System.Windows.Forms.DataGridView GridFunciones;
        private System.Windows.Forms.DataGridViewImageColumn Editar_Funcion;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar_Funcion;
        public System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbAsignarRol;
        private System.Windows.Forms.Label lblFuncionActual;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox txtBuscarFuncionRol;
        private System.Windows.Forms.Button btnAsignarPermisoAc;
        private System.Windows.Forms.DataGridView GridRolFuncion;
        private System.Windows.Forms.DataGridViewImageColumn Editar_Funcion_Rol;
        private System.Windows.Forms.Button btnAsignarRol;
    }
}