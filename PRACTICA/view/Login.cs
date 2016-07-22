using PRACTICA.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void conn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gpm = new view.MainMenu();
            gpm.Closed += (s, args) => this.Close();
            gpm.Show();
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).ForeColor == Color.Gray)
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void textBox_LostFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                var name = ((TextBox)sender).Name;
                var text = (name == "user_textBox") ? "Usuario" : "Contraseña";
                ((TextBox)sender).Text = text;
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }

        private void conn_MouseEnter(object sender, EventArgs e)
        {
            conn.FlatStyle = FlatStyle.Popup;
        }

        private void conn_MouseLeave(object sender, EventArgs e)
        {
            conn.FlatStyle = FlatStyle.Flat;
        }
    }
}
