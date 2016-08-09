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
    public partial class InsertData : Form
    {
        public DateTime dateFrom;
        public DateTime dateUntil;
        public object selectedType;
        public object selectedTop;

        public InsertData()
        {
            InitializeComponent();
        }

        private void GraphsDatePicker_Load(object sender, EventArgs e)
        {
            var tsl = new ToolStripLabel("Personalizado");
            top_menuStrip.Items.Insert(5, tsl);
        }

        // Esto que voy a hacer puede generar errores, porque no se estan volviendo a poner en nulo las cosas
        private void save_Click(object sender, EventArgs e)
        {
            var fro = from.Value.Date;
            var unt = until.Value.Date;
            object sType = findSelected(type_menuStrip.Items);
            object sTop = findSelected(top_menuStrip.Items);

            if (fro <= unt && sType != null && sTop != null)
            {
                dateFrom = fro;
                dateUntil = unt;
                selectedType = sType;
                selectedTop = sTop;

                Close();
            }
            else
            {
                errorDialog();
            }
        }

        // Seleccion del tipo de grafica
        private void typeOrTop_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag.ToString() == "close")
            {
                btn.Image = Properties.Resources.up_arrow;
                Point ptLowerLeft = new Point(0, btn.Height);
                ptLowerLeft = btn.PointToScreen(ptLowerLeft);

                ((btn == type) ? type_menuStrip : top_menuStrip).Show(ptLowerLeft);
            }
            else
                btn.Tag = "close";
        }

        private void type_menuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            var point = this.PointToClient(Control.MousePosition);

            if (point.X > 217 && point.X < 477 && point.Y > 192 && point.Y < 226)
                type.Tag = "open";

            type.Image = Properties.Resources.down_arrow;
        }

        private void type_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem item in type_menuStrip.Items)
            {
                if (item != sItem)
                    item.Checked = false;
            }
        }

        private void top_menuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            var point = this.PointToClient(Control.MousePosition);

            if (point.X > 217 && point.X < 477 && point.Y > 284 && point.Y < 320)
                top.Tag = "open";

            top.Image = Properties.Resources.down_arrow;
        }

        private void top_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem sItem = sender as ToolStripMenuItem;
            var count = top_menuStrip.Items.Count;

            for (int i = 0; i < count; i++)
            {
                ToolStripMenuItem item = top_menuStrip.Items[i] as ToolStripMenuItem;
                if (item != null && item != sItem)
                    item.Checked = false;
            }
        }

        private string findSelected(ToolStripItemCollection cm)
        {
            for (int i = 0; i < cm.Count; i++)
            {
                ToolStripMenuItem item = cm[i] as ToolStripMenuItem;
                if (item != null && item.Checked)
                    return item.Text;
            }
            return null;
        }

        private void errorDialog()
        {
            DialogResult dr =
                  MessageBox.Show("Asegúrese de que los datos introducidos sean correctos.",
                  "Ocurrio un error", MessageBoxButtons.OK);
        }

    }
}