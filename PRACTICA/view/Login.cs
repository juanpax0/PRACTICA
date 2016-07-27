using PRACTICA.dao;
using PRACTICA.model;
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
    public partial class login : Form
    {
        LoginDAO query = new LoginDAO();

        public login()
        {
            InitializeComponent();
        }

        private void conn_Click(object sender, EventArgs e)
        {
            var id = user_textBox.Text.Replace(" ", "");
            var pass = pass_textBox.Text.Replace(" ", "");

            // ..................................................
            // ..................................................
            // ..................................................
            // Al parece hay algun error con estas condiciones.
            // REVISAR ESTO.
            // ..................................................
            // ..................................................
            // ..................................................

            if (!id.Equals("") && !pass.Equals(""))
            {
                Person p = new Person(id, pass);
                var resp = query.login(p);

                if (resp)
                {
                    Hide();
                    var gpm = new view.MainMenu();
                    gpm.Closed += (s, args) => this.Close();
                    gpm.Show();
                }
                else {
                    DialogResult dr = 
                        MessageBox.Show("Asegúrese de que los datos introducidos son correctos.",
                       "Ocurrio un error", MessageBoxButtons.OK);

                }
            }
        }

        private void textBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = ((TextBox)sender);

            if (txtBox.ForeColor == Color.Gray)
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.Black;
                if (txtBox.Name == "pass_textBox")
                    txtBox.PasswordChar = '*';
            }
        }

        private void textBox_LostFocus(object sender, EventArgs e)
        {
            TextBox txtBox = ((TextBox)sender);

            if (txtBox.Text == "")
            {
                if (txtBox.Name == "pass_textBox") {
                    txtBox.PasswordChar = '\0';
                    txtBox.Text = "Contraseña";
                } else
                    txtBox.Text = "Usuario";

                txtBox.ForeColor = Color.Gray;
            }
        }
    }
}
