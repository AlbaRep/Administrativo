﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrativo
{
    public partial class Barra : Form
    {
        public Barra()
        {
            InitializeComponent();
            label5.Text = DateTime.Now.ToString("r");
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.CerrarPrograma(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funciones n = new funciones();
            n.CerrarSesion(this);
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }
    }
}
