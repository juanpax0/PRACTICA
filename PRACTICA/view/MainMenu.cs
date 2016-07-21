using System;
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
    public partial class MainMenu : Form
    {
        private static ToolTip tt = new ToolTip();
        private static List<Form> openWindows = new List<Form>();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void GraphsRepoMenu_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dr =
                MessageBox.Show("Se cerraran todas las ventanas abiertas y será redirigido al login principal.",
                "¿Seguro?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                closeWindows();

                Hide();
                var login = new Login();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
        }

        private void closeWindows()
        {
            foreach (Form f in openWindows)
            {
                f.Close();
            }
            openWindows.Clear();
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.None;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)(((PictureBox)sender).Parent)).BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)(((PictureBox)sender).Parent)).BorderStyle = BorderStyle.None;
        }


        private void quotation_panel_Click(object sender, EventArgs e)
        {
            var quo = new Quotation();
            openWindows.Add(quo);
            quo.Show();
            quo.exit.Click += new EventHandler(exit_Click);
        }

        private void graph_panel_Click(object sender, EventArgs e)
        {
            var g = new Graphs();
            openWindows.Add(g);
            g.Show();
            g.exit.Click += new EventHandler(exit_Click);
        }
    }
}
