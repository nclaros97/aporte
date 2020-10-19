namespace SistemaVentaFacturacion.Usuarios
{
    partial class FormMantRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnConfirmarRol = new System.Windows.Forms.Button();
            this.txtnombreRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridRoles = new System.Windows.Forms.DataGridView();
            this.Editar_Roles = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar_Roles = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarRol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarPermiso = new System.Windows.Forms.Button();
            this.GridPermisos = new System.Windows.Forms.DataGridView();
            this.Editar_Permiso = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar_Permiso = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdPermiso = new System.Windows.Forms.TextBox();
            this.btnConfirmarPermiso = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BarraTitulo.Controls.Add(this.BtnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1209, 47);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SistemaPrestamos.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(1159, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(51, 47);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnConfirmarRol
            // 
            this.btnConfirmarRol.AccessibleName = "Insertar";
            this.btnConfirmarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnConfirmarRol.FlatAppearance.BorderSize = 0;
            this.btnConfirmarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRol.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarRol.Location = new System.Drawing.Point(181, 121);
            this.btnConfirmarRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarRol.Name = "btnConfirmarRol";
            this.btnConfirmarRol.Size = new System.Drawing.Size(133, 43);
            this.btnConfirmarRol.TabIndex = 11;
            this.btnConfirmarRol.Text = "Confirmar";
            this.btnConfirmarRol.UseVisualStyleBackColor = false;
            this.btnConfirmarRol.Click += new System.EventHandler(this.btnConfirmarRol_Click);
            // 
            // txtnombreRol
            // 
            this.txtnombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreRol.Location = new System.Drawing.Point(131, 85);
            this.txtnombreRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombreRol.Name = "txtnombreRol";
            this.txtnombreRol.Size = new System.Drawing.Size(324, 26);
            this.txtnombreRol.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rol:";
            // 
            // txtidRol
            // 
            this.txtidRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidRol.Location = new System.Drawing.Point(131, 52);
            this.txtidRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidRol.Name = "txtidRol";
            this.txtidRol.ReadOnly = true;
            this.txtidRol.Size = new System.Drawing.Size(324, 26);
            this.txtidRol.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // GridRoles
            // 
            this.GridRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridRoles.BackgroundColor = System.Drawing.Color.White;
            this.GridRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GridRoles.ColumnHeadersHeight = 30;
            this.GridRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar_Roles,
            this.Eliminar_Roles});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridRoles.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridRoles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridRoles.EnableHeadersVisualStyles = false;
            this.GridRoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridRoles.Location = new System.Drawing.Point(4, 201);
            this.GridRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridRoles.Name = "GridRoles";
            this.GridRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GridRoles.RowHeadersWidth = 51;
            this.GridRoles.Size = new System.Drawing.Size(561, 361);
            this.GridRoles.TabIndex = 15;
            this.GridRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridRoles_CellClick);
            // 
            // Editar_Roles
            // 
            this.Editar_Roles.HeaderText = "";
            this.Editar_Roles.Image = global::SistemaPrestamos.Properties.Resources.editar;
            this.Editar_Roles.MinimumWidth = 6;
            this.Editar_Roles.Name = "Editar_Roles";
            this.Editar_Roles.ReadOnly = true;
            this.Editar_Roles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar_Roles
            // 
            this.Eliminar_Roles.HeaderText = "";
            this.Eliminar_Roles.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.Eliminar_Roles.MinimumWidth = 6;
            this.Eliminar_Roles.Name = "Eliminar_Roles";
            this.Eliminar_Roles.ReadOnly = true;
            this.Eliminar_Roles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar_Roles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "Formulario Roles";
            this.groupBox1.Controls.Add(this.btnCancelarRol);
            this.groupBox1.Controls.Add(this.GridRoles);
            this.groupBox1.Controls.Add(this.txtnombreRol);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtidRol);
            this.groupBox1.Controls.Add(this.btnConfirmarRol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(569, 566);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // btnCancelarRol
            // 
            this.btnCancelarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnCancelarRol.FlatAppearance.BorderSize = 0;
            this.btnCancelarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRol.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRol.Location = new System.Drawing.Point(323, 121);
            this.btnCancelarRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarRol.Name = "btnCancelarRol";
            this.btnCancelarRol.Size = new System.Drawing.Size(133, 43);
            this.btnCancelarRol.TabIndex = 12;
            this.btnCancelarRol.Text = "Cancelar";
            this.btnCancelarRol.UseVisualStyleBackColor = false;
            this.btnCancelarRol.Click += new System.EventHandler(this.btnCancelarRol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleName = "Formulario Permisos";
            this.groupBox2.Controls.Add(this.btnCancelarPermiso);
            this.groupBox2.Controls.Add(this.GridPermisos);
            this.groupBox2.Controls.Add(this.txtNombrePermiso);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdPermiso);
            this.groupBox2.Controls.Add(this.btnConfirmarPermiso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(617, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(569, 562);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos";
            // 
            // btnCancelarPermiso
            // 
            this.btnCancelarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnCancelarPermiso.FlatAppearance.BorderSize = 0;
            this.btnCancelarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPermiso.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPermiso.Location = new System.Drawing.Point(323, 121);
            this.btnCancelarPermiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarPermiso.Name = "btnCancelarPermiso";
            this.btnCancelarPermiso.Size = new System.Drawing.Size(133, 43);
            this.btnCancelarPermiso.TabIndex = 12;
            this.btnCancelarPermiso.Text = "Cancelar";
            this.btnCancelarPermiso.UseVisualStyleBackColor = false;
            this.btnCancelarPermiso.Click += new System.EventHandler(this.btnCancelarPermiso_Click);
            // 
            // GridPermisos
            // 
            this.GridPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPermisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridPermisos.BackgroundColor = System.Drawing.Color.White;
            this.GridPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPermisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridPermisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridPermisos.ColumnHeadersHeight = 30;
            this.GridPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar_Permiso,
            this.Eliminar_Permiso});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridPermisos.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridPermisos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridPermisos.EnableHeadersVisualStyles = false;
            this.GridPermisos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridPermisos.Location = new System.Drawing.Point(4, 201);
            this.GridPermisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridPermisos.Name = "GridPermisos";
            this.GridPermisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridPermisos.RowHeadersWidth = 51;
            this.GridPermisos.Size = new System.Drawing.Size(561, 357);
            this.GridPermisos.TabIndex = 15;
            this.GridPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPermisos_CellClick);
            // 
            // Editar_Permiso
            // 
            this.Editar_Permiso.HeaderText = "";
            this.Editar_Permiso.Image = global::SistemaPrestamos.Properties.Resources.editar;
            this.Editar_Permiso.MinimumWidth = 6;
            this.Editar_Permiso.Name = "Editar_Permiso";
            this.Editar_Permiso.ReadOnly = true;
            this.Editar_Permiso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Eliminar_Permiso
            // 
            this.Eliminar_Permiso.HeaderText = "";
            this.Eliminar_Permiso.Image = global::SistemaPrestamos.Properties.Resources.basura;
            this.Eliminar_Permiso.MinimumWidth = 6;
            this.Eliminar_Permiso.Name = "Eliminar_Permiso";
            this.Eliminar_Permiso.ReadOnly = true;
            this.Eliminar_Permiso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar_Permiso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePermiso.Location = new System.Drawing.Point(131, 85);
            this.txtNombrePermiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.Size = new System.Drawing.Size(324, 26);
            this.txtNombrePermiso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Permiso:";
            // 
            // txtIdPermiso
            // 
            this.txtIdPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPermiso.Location = new System.Drawing.Point(131, 52);
            this.txtIdPermiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPermiso.Name = "txtIdPermiso";
            this.txtIdPermiso.ReadOnly = true;
            this.txtIdPermiso.Size = new System.Drawing.Size(324, 26);
            this.txtIdPermiso.TabIndex = 13;
            // 
            // btnConfirmarPermiso
            // 
            this.btnConfirmarPermiso.AccessibleName = "Insertar";
            this.btnConfirmarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnConfirmarPermiso.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarPermiso.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPermiso.Location = new System.Drawing.Point(181, 121);
            this.btnConfirmarPermiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarPermiso.Name = "btnConfirmarPermiso";
            this.btnConfirmarPermiso.Size = new System.Drawing.Size(133, 43);
            this.btnConfirmarPermiso.TabIndex = 11;
            this.btnConfirmarPermiso.Text = "Confirmar";
            this.btnConfirmarPermiso.UseVisualStyleBackColor = false;
            this.btnConfirmarPermiso.Click += new System.EventHandler(this.btnConfirmarPermiso_Click);
            // 
            // FormMantRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMantRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantCliente";
            this.Load += new System.EventHandler(this.FormMantRoles_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnConfirmarRol;
        public System.Windows.Forms.TextBox txtnombreRol;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtidRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridPermisos;
        public System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIdPermiso;
        private System.Windows.Forms.Button btnConfirmarPermiso;
        private System.Windows.Forms.Button btnCancelarRol;
        private System.Windows.Forms.Button btnCancelarPermiso;
        private System.Windows.Forms.DataGridViewImageColumn Editar_Roles;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar_Roles;
        private System.Windows.Forms.DataGridViewImageColumn Editar_Permiso;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar_Permiso;
    }
}