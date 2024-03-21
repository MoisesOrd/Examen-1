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
        Persona p = new Persona();
        PersonaBss bss = new PersonaBss();
        public EmpleadoEditar()
        {
            InitializeComponent();
        }
        public EmpleadoEditar(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerPersonaIdBss(idx);
            textBox1.Text = p.Nombre;
            textBox2.Text = p.Apellido;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            bss.EditarPersonaBss(p);
            MessageBox.Show("Datos Actualizados");
        }
    }
}