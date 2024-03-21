using GestionBss;
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
    public partial class EmpleadoEditar : Form
    {
        int idx = 0;
        EmpleadoBss p = new EmpleadoBss();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditar()
        {
            InitializeComponent();
        }
        public EmpleadoEditar(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerEmpleadoIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            bss.EditarEmpleadoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}