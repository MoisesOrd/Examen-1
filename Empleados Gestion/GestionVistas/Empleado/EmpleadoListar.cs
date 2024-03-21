using GestionBss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVistas.Empleado
{
    public partial class EmpleadoListar : Form
    {
        public EmpleadoListar()
        {
            InitializeComponent();
        }
        EmpleadoBss bss = new EmpleadoBss();
        private void EmpleadoListar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ();
        }


        
    }
}
