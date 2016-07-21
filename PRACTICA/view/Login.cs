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

        bool waterMarkActive = true;

        private void conn_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gpm = new view.MainMenu();
            gpm.Closed += (s, args) => this.Close();
            gpm.Show();
        }

        private void user_textBox_TextChanged(object sender, EventArgs e)
        {
            if (user_textBox.Text == "")
                user_textBox.Text = "Usuario";
        }

        private void pass_textBox_TextChanged(object sender, EventArgs e)
        {
            if (user_textBox.Text == "")
                user_textBox.Text = "Contraseña";
        }

        private void user_textBox_Click(object sender, EventArgs e)
        {
            user_textBox.Text = "";
        }
    }
}
