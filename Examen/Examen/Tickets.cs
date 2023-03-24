using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        TicketDatos ticketsD = new TicketDatos();
        Ticket user ; 


        private async void Llenar()
        {
            dataGridView1.DataSource = await ticketsD.DevolverAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            user = new Ticket();

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ingrese Usuario");
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese Cliente");
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Ingrese Tipo de Soporte");
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Ingrese una Descripcion");
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Ingrese una Descripcion");
                textBox5.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "Ingrese Precio");
                textBox6.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                errorProvider1.SetError(textBox7, "Ingrese Impuesto");
                textBox7.Focus();
                return;
            }

            user.Usuario = textBox1.Text;
            user.Fecha = Convert.ToDateTime(dateTimePicker1.Text);
            user.Cliente= textBox2.Text;
            user.TipoSoporte = textBox3.Text;
            user.DescripcionS = textBox4.Text;
            user.DescripcionR = textBox5.Text;
            user.Precio = Convert.ToDouble(textBox6.Text);
            user.Impuesto = Convert.ToDouble(textBox7.Text);
            user.Descuento = Convert.ToDouble(textBox8.Text);
            double sub = user.Precio * user.Impuesto;
            double sub2 = user.Precio + sub;
            double sub3 = sub2 * user.Descuento;
            textBox9.Text = Convert.ToString(sub2-sub3);
            user.Total = Convert.ToDouble(textBox9.Text);

            bool inserto = await ticketsD.InsertarAsync(user);
          
            if (inserto)
            {
                Llenar();
                MessageBox.Show("Ticket registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ticket no registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
