using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___PGP
{
    public partial class Contenedor : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Contenedor()
        {
            InitializeComponent();
            PersonalizarSubMenu();
            AbrirForm(new Inicio());
        }

        private void PersonalizarSubMenu()
        {
            panel_submenu1.Visible = false;
            panel_submenu2.Visible = false;
            //Aqui se ocultaran los demas submenus
        }

        private void OcultarSubMenu()
        {
            if (panel_submenu1.Visible==true)
            {
                panel_submenu1.Visible = false;
            }
            if (panel_submenu2.Visible==true)
            {
                panel_submenu2.Visible = false;
            }
            //Aqui iran los demas submenus
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Indicador.Width = btn_inicio.Width;
            Indicador.Left = btn_inicio.Left;
            Indicador.Visible = false;
            AnimarIndicador.Show(Indicador);
            AbrirForm(new Inicio());
        }

        //EMPIEZAN ACCIONES DE CLIENTES
        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            Indicador.Width = btn_clientes.Width;
            Indicador.Left = btn_clientes.Left;
            Indicador.Visible = false;
            AnimarIndicador.Show(Indicador);
            //Mostrar el submenu de clientes
            MostrarSubMenu(panel_submenu1);
        }

        private void btn_receta_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            //Instancia de otros formularios
            AbrirForm(new Recetas());
        }

        private void btn_domicilio_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            //Instancia de otros formularios
        }

        private void btn_datos_generales_clientes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            //Instancia de otros formularios
        }

        //EMPIEZAN ACCIONES DE EMPLEADOS
        private void btn_empleados_Click(object sender, EventArgs e)
        {
            Indicador.Width = btn_empleados.Width;
            Indicador.Left = btn_empleados.Left;
            Indicador.Visible = false;
            AnimarIndicador.Show(Indicador);
            MostrarSubMenu(panel_submenu2);
        }

        private void btn_datos_personales_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            //Instancia de otros formularios
        }

        private void btn_datos_generales_empleados_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            //Instancia de otros formularios
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
            btn_maximizar.Visible = false;
        }

        private void btn_minizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void AbrirForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(childForm);
            panel_contenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
