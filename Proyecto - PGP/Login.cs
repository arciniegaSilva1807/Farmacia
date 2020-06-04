using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto___PGP
{
    public partial class Login : Form
    {
        //Importar librerias nativas del SO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Desactivar visibilidad de elementos para mostrar animacion
            IconoFarmacia.Visible = false;
            label1.Visible = false;
            //using bunifu UI
            AnimacionIcono.Show(IconoFarmacia);
            AnimacionIcono.Show(label1);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            //Permitira arrastrar la ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_minizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Aquí se comprobaran los datos en SQL
            this.Close();
            Contenedor myContainer = new Contenedor();
            myContainer.Show();
            myContainer.label1.Text = txt_usuario.Text;

            //comentario para prueba
            1112
        }
    }
}
