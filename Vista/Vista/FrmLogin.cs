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
    public partial class LblUsuario : Form
    {
        public LblUsuario()
        {
            InitializeComponent();
        }

        private void BtnAccesar_Click(object sender, EventArgs e)
        {
            FrmContenedor contenedor = new FrmContenedor();
            contenedor.Show();
            this.Hide();
        }
    }
}
