﻿using LOGICA.LUsuarios;
using SistemaPrestamos.Clientes;
using SistemaPrestamos.Prestamos;
using SistemaPrestamos.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrestamos
{
    public partial class FormMenuPrincipal : Form
    {
        //Constructor
        public bool cerrar;
        public bool isLogin;
        public List<funciones> funciones = new List<funciones>();
        public List<permisos> permisos = new List<permisos>();
        public string nombreCompleto;
        public string correo;
        public string cargos;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedorPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
       
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (isLogin==false)
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                btnMaximizar.Visible = false;
                btnNormal.Visible = true;
            }

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            if (isLogin==false)
            {
                this.Size = new Size(sw, sh);
                this.Location = new Point(lx, ly);
                btnNormal.Visible = false;
                btnMaximizar.Visible = true;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //METODOS PARA ANIMACION DE MENU SLIDING--
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelMenu.Width == 230)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }

            //-------SIN EFECTO 
            //if (panelMenu.Width == 55)
            //{
            //    panelMenu.Width = 230;
            //}
            //else

            //    panelMenu.Width = 55;
        }

        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width >= 230)
                this.tmExpandirMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width + 5;
            
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelMenu.Width = panelMenu.Width - 5;
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.Dock = DockStyle.Fill;

            fh.ControlBox = false;
            fh.Top = (panelContenedorForm.Height / 2) - (fh.Height / 2); ;
            fh.Left = (panelContenedorForm.Width / 2) - (fh.Width / 2);
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.TopLevel = false;

            this.panelContenedorForm.Controls.Add(fh);
            this.panelContenedorForm.Tag = fh;
            fh.Show();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormLogo());
        }
        public bool sesion=false;

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            //seguridad
            validaciones.seguridad_deshabilitarMenu(panelOpciones.Controls);
            if (sesion){
            panelOpciones.Enabled = true;
            MostrarFormLogo();
            }
            else
            {
                panelOpciones.Enabled = false;
                Login();
            }
        }
        
        private void Login()
        {
            if (this.panelContenedorForm.Controls.Count > 0)
                this.panelContenedorForm.Controls.RemoveAt(0);

            FormLogin fm = new FormLogin();
            AddOwnedForm(fm);
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.TopLevel = false;
            //fm.Dock = DockStyle.Fill;
            fm.ControlBox = false;
            fm.Top = (panelContenedorForm.Height / 2) - (fm.Height/2);
            fm.Left = (panelContenedorForm.Width / 2) - (fm.Width/2);
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.TopLevel = false;
            this.panelContenedorForm.Controls.Add(fm);
            this.Tag = fm;
            fm.BringToFront();

            fm.Show();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
        }


        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        public void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            //verificar estado del inicio de sesion;

            if (sesion)
            {

                panelOpciones.Enabled = true;
                lblNombreCompeto.Text = nombreCompleto;
                lblCorreo.Text = correo;
                lblCargo.Text = cargos;
                MostrarFormLogo();

                //FILTROS DE SESION
                //seguridad habilitar menu segun las funciones
                //cargar las listas en la clase de validaciones para poder acceder a las funciones y permisos del usuario logeado
                validaciones.FuncionesG = funciones;
                validaciones.PermisosG = permisos;
                validaciones.seguridad_habilitarMenu(panelOpciones.Controls);
                
                
               //FIN FILTROS DE SESION

            }
            else
            {
                if (cerrar == false)
                {
                    panelOpciones.Enabled = false;
                    lblNombreCompeto.Text = "Nombre Completo";
                    lblCorreo.Text = "Correo";
                    lblCargo.Text = "Cargos";
                    Login();
                }
            }
            
        }
        //METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------
        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes fm = new FormListaClientes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            panelOpciones.Enabled = false;
            foreach (Control control in panelOpciones.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                    control.Visible = false;
                }
            }
            Login();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormListaPrestamos fm = new FormListaPrestamos();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormListaUsuarios fm = new FormListaUsuarios();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ssss");
        }
        
    }

}
