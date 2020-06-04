using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validar_6b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            edades();
        }
        public void edades()
        {
            for(int i= 1; i<=110; i++)
            {
                Age_cbx.Items.Add(i);
            }
        }
        //private void enter_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(!(char.IsNumber(e.KeyChar))&& (e.KeyChar != (char)Keys.Back))
        //    {
        //        MessageBox.Show("En este apartado solo se aceptan numeros");
        //        e.Handled = true;
        //    }
        //}
        //private void solonumeros_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(Char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    if (Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }

        //}
  

        private void Add_b_Click(object sender, EventArgs e)
        {
            //int numero, edad = Convert.ToInt16(Age_t.Text);
            //bool resultado = int.TryParse(Age_t.Text, out numero);
            //if(resultado)
            //{
            //    if (edad > 0 && edad < 111)
            //    {
            //        MessageBox.Show("La edad es: " + edad);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Edad no valida","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Dato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (!string.IsNullOrWhiteSpace(Age_t.Text) && Age_t.Text.Length > 0)
            //{
            //    if (Convert.ToInt16(Age_t.Text) > 0 && Convert.ToInt16(Age_t.Text) < 111)
            //    {
            //        MessageBox.Show("La edad es: " + Age_t.Text);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Edad no valida");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Dato erroneo");
            //}

            //try
            //{
            // int edad = Convert.ToInt16(Age_t.Text);
            //    if (edad >0 && edad <111 )
            //    {
            //        MessageBox.Show("La edad es " + edad);
            //    }
            //    else
            //    {
            //        MessageBox.Show("edad erronea " + edad);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}

        }
    }
}
