using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___PGP
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            label_bienvenido.Visible = false;
            Animar.Show(label_bienvenido);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Animar.Show(panel1);
            Animar.Show(panel2);
            Animar.Show(panel3);
        }
    }
}
