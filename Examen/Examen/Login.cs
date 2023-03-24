using Datos;
using System.Windows.Forms;
using Vista;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                errorProvider1.SetError(textBox1, "Ingrese un correo");
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2, "Ingrese una clave");
                textBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userdatos = new UsuarioDatos();
            bool valido = await userdatos.LoginAsync(textBox1.Text, textBox2.Text);

            if (valido)
            {
                //Menu
                Menu formulario = new Menu();
                Hide();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
