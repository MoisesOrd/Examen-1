﻿using GestionBss;
using GestionModelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionVistas.Empleado
{
    public partial class EmpleadoInsertar : Form
    {
        public EmpleadoInsertar()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.

            bss.InsertarEmpledoBss(p);
            MessageBox.Show("Se guardo correctamente la persona");

        }
    }
}
