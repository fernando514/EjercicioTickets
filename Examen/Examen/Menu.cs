﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void celulareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets formulario = new Tickets();
            Hide();
            formulario.Show();
        }

        private void equipoDeComputoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets formulario = new Tickets();
            Hide();
            formulario.Show();
        }
    }
}
