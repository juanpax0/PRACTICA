﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA.view
{
    public partial class GraphsDatePicker : Form
    {
        public DateTime dateFrom;
        public DateTime dateUntil;

        public GraphsDatePicker()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            var f = from.Value.Date;
            var u = until.Value.Date;

            if (f <= u)
            {
                dateFrom = f;
                dateUntil = u;

                Close();
            }
            else
            {
                DialogResult dr = 
                    MessageBox.Show("Asegúrese de que el rango de fecha sea correcto.", 
                    "Ocurrio un error", MessageBoxButtons.OK);
            }
        }
    }
}