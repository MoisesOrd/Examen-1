﻿using GestionBss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionVistas
{
    public partial class PersonaListar : Form
    {
        public PersonaListar()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void PersonaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarPersonaBss();
        }
    }
}
