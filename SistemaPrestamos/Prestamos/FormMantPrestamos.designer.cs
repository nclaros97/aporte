namespace SistemaPrestamos.Prestamos
{
    partial class FormMantPrestamos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridDetallePresmosCliente = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorcentajeTasaInteres = new System.Windows.Forms.TextBox();
            this.txtPlazoMeses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoOtorgado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDiaFechaPagoMensual = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cbFondos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRegional = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtNoTransaccion = new System.Windows.Forms.TextBox();
            this.lblNoTransaccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDetallePresmosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDetallePresmosCliente
            // 
            this.GridDetallePresmosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridDetallePresmosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDetallePresmosCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridDetallePresmosCliente.BackgroundColor = System.Drawing.Color.White;
            this.GridDetallePresmosCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridDetallePresmosCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridDetallePresmosCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetallePresmosCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.GridDetallePresmosCliente.ColumnHeadersHeight = 30;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDetallePresmosCliente.DefaultCellStyle = dataGridViewCellStyle14;
            this.GridDetallePresmosCliente.EnableHeadersVisualStyles = false;
            this.GridDetallePresmosCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.GridDetallePresmosCliente.Location = new System.Drawing.Point(13, 385);
            this.GridDetallePresmosCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GridDetallePresmosCliente.Name = "GridDetallePresmosCliente";
            this.GridDetallePresmosCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDetallePresmosCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.GridDetallePresmosCliente.RowHeadersWidth = 51;
            this.GridDetallePresmosCliente.Size = new System.Drawing.Size(1134, 435);
            this.GridDetallePresmosCliente.TabIndex = 20;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::SistemaPrestamos.Properties.Resources.Close;
            this.BtnCerrar.Location = new System.Drawing.Point(13, 13);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(57, 53);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtClienteId
            // 
            this.txtClienteId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtClienteId.Location = new System.Drawing.Point(12, 123);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(100, 22);
            this.txtClienteId.TabIndex = 21;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            this.txtClienteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteId_KeyPress);
            this.txtClienteId.Leave += new System.EventHandler(this.txtClienteId_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cliente";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(118, 123);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(271, 22);
            this.txtClienteNombre.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Porcentaje Tasa Interes";
            // 
            // txtPorcentajeTasaInteres
            // 
            this.txtPorcentajeTasaInteres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPorcentajeTasaInteres.Location = new System.Drawing.Point(600, 120);
            this.txtPorcentajeTasaInteres.Name = "txtPorcentajeTasaInteres";
            this.txtPorcentajeTasaInteres.Size = new System.Drawing.Size(100, 22);
            this.txtPorcentajeTasaInteres.TabIndex = 25;
            // 
            // txtPlazoMeses
            // 
            this.txtPlazoMeses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlazoMeses.Location = new System.Drawing.Point(600, 165);
            this.txtPlazoMeses.Name = "txtPlazoMeses";
            this.txtPlazoMeses.Size = new System.Drawing.Size(100, 22);
            this.txtPlazoMeses.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Plazo En Meses";
            // 
            // txtMontoOtorgado
            // 
            this.txtMontoOtorgado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMontoOtorgado.Location = new System.Drawing.Point(795, 120);
            this.txtMontoOtorgado.Name = "txtMontoOtorgado";
            this.txtMontoOtorgado.Size = new System.Drawing.Size(100, 22);
            this.txtMontoOtorgado.TabIndex = 29;
            this.txtMontoOtorgado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Monto Otorgado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fecha Pago";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(796, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtDiaFechaPagoMensual
            // 
            this.txtDiaFechaPagoMensual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiaFechaPagoMensual.Location = new System.Drawing.Point(936, 164);
            this.txtDiaFechaPagoMensual.Name = "txtDiaFechaPagoMensual";
            this.txtDiaFechaPagoMensual.ReadOnly = true;
            this.txtDiaFechaPagoMensual.Size = new System.Drawing.Size(154, 22);
            this.txtDiaFechaPagoMensual.TabIndex = 33;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AccessibleName = "Insertar";
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnNuevo.Enabled = false;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(796, 193);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(133, 37);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "Generar";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cbFondos
            // 
            this.cbFondos.FormattingEnabled = true;
            this.cbFondos.Location = new System.Drawing.Point(80, 161);
            this.cbFondos.Name = "cbFondos";
            this.cbFondos.Size = new System.Drawing.Size(178, 24);
            this.cbFondos.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fondos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Regional";
            // 
            // cbRegional
            // 
            this.cbRegional.FormattingEnabled = true;
            this.cbRegional.Location = new System.Drawing.Point(80, 200);
            this.cbRegional.Name = "cbRegional";
            this.cbRegional.Size = new System.Drawing.Size(178, 24);
            this.cbRegional.TabIndex = 37;
            // 
            // btnPagar
            // 
            this.btnPagar.AccessibleName = "Insertar";
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(177)))), ((int)(((byte)(17)))));
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(274, 341);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(133, 37);
            this.btnPagar.TabIndex = 39;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtNoTransaccion
            // 
            this.txtNoTransaccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNoTransaccion.Location = new System.Drawing.Point(15, 341);
            this.txtNoTransaccion.Multiline = true;
            this.txtNoTransaccion.Name = "txtNoTransaccion";
            this.txtNoTransaccion.Size = new System.Drawing.Size(253, 37);
            this.txtNoTransaccion.TabIndex = 40;
            // 
            // lblNoTransaccion
            // 
            this.lblNoTransaccion.AutoSize = true;
            this.lblNoTransaccion.Location = new System.Drawing.Point(12, 321);
            this.lblNoTransaccion.Name = "lblNoTransaccion";
            this.lblNoTransaccion.Size = new System.Drawing.Size(112, 17);
            this.lblNoTransaccion.TabIndex = 41;
            this.lblNoTransaccion.Text = "No. Transaccion";
            // 
            // FormMantPrestamos
            // 
            this.AccessibleName = "Formulario Clientes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 833);
            this.Controls.Add(this.lblNoTransaccion);
            this.Controls.Add(this.txtNoTransaccion);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRegional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbFondos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtDiaFechaPagoMensual);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoOtorgado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlazoMeses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPorcentajeTasaInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.GridDetallePresmosCliente);
            this.Controls.Add(this.BtnCerrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMantPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMantPrestamos";
            this.Load += new System.EventHandler(this.FormListaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDetallePresmosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDetallePresmosCliente;
        private System.Windows.Forms.Button BtnCerrar;
        public System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPorcentajeTasaInteres;
        public System.Windows.Forms.TextBox txtPlazoMeses;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMontoOtorgado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtDiaFechaPagoMensual;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cbFondos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRegional;
        private System.Windows.Forms.Button btnPagar;
        public System.Windows.Forms.TextBox txtNoTransaccion;
        private System.Windows.Forms.Label lblNoTransaccion;
    }
}