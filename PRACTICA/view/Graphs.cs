using PRACTICA.dao;
using PRACTICA.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PRACTICA.view
{
    public partial class Graphs : Form
    {

        GraphsDAO query = new GraphsDAO();

        public Graphs()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "C:\\a.gif";
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            var tsl = new ToolStripLabel("Personalizado");
            top_menuStrip.Items.Insert(5, tsl);
        }

        private string findSelected(ToolStripItemCollection cm)
        {
            foreach (ToolStripMenuItem item in cm)
            {
                if (item.Checked)
                    return item.Text;
            }
            return null;
        }

        private void generate_Click(object sender, EventArgs e)
        {

            //...............................................
            /*var d = desde.Value.Date;
            var h = hasta.Value.Date;

            if (d <= h)
            {
                Console.WriteLine("correcto");
            }
            else
            {
                Console.WriteLine("error en fecha");
            } */
            //.................................................
            //....................................................................

            object selectedType = findSelected(type_menuStrip.Items);
            object selectedTop = "5";

            if (selectedType != null && selectedTop != null)
            {
                pictureBox1.Visible = false;
                if (mainGraph.Series != null)
                    mainGraph.Series.Clear();

                string type = selectedType.ToString();
                int top = int.Parse(selectedTop.ToString());

                if (type == "Familias")
                    families();

                if (type == "Articulos mas cotizados")
                    getTop("products", top);

                else if (type == "Servicios mas cotizados")
                    getTop("servicies", top);

                else if (type == "Articulos menos cotizados")
                    getBottom("products", top);

                else if (type == "Servicios menos cotizados")
                    getBottom("servicies", top);

                mainGraph.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void families()
        {
            List<Family> fls = query.getFamilies();
            mainGraph.Series.Add("Familias");
            mainGraph.Series[0].ChartType = SeriesChartType.Pie;
            var i = 0;
            var total = 1221;   //total de registros en las familias

            foreach (var f in fls)
            {
                mainGraph.Series[0].Points.AddY(f.n);
                mainGraph.Series[0].Points[i].LegendText = f.name;
                // Esto es para el texto que aparece dentro del pedazo del pie.
                //mainGraph.Series[0].Points[i].AxisLabel = perc.ToString(); 
                i++;
            }
        }

        private void getTop(string method, int top)
        {
            List<Product> prs = (method == "products") ? query.getTopProducts(top) :
                query.getTopServices(top);
            var i = 0;

            foreach (var p in prs)
            {
                mainGraph.Series.Add(p.name);
                mainGraph.ApplyPaletteColors();
                mainGraph.Series[0].Points.AddY(p.quotationNum);
                mainGraph.Series[0].Points[i].Color = mainGraph.Series[i].Color;
                i++;
            }
        }

        private void getBottom(string method, int top)
        {
            List<NoProduct> prs = (method == "products") ? query.getBottomProducts(top) :
                query.getBottomServices(top);
            var i = 0;

            foreach (var np in prs)
            {
                mainGraph.Series.Add(np.name);
                mainGraph.ApplyPaletteColors();
                mainGraph.Series[0].Points.AddY(np.quotationNum);
                mainGraph.Series[0].Points[i].Color = mainGraph.Series[i].Color;
                i++;
            }
        }

        // para detectar a que barra o parte del pie se le dio click
        private void mainGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = mainGraph.HitTest(e.X, e.Y);
            if (hit.PointIndex >= 0)
                Console.WriteLine("DASDASDASDASD:" + hit.PointIndex);
        }

        private void type_Click(object sender, EventArgs e)
        {
            if (type_menuStrip.Tag.ToString() == "false")
            {
                ((Button)sender).Image = Properties.Resources.up_arrow;

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                type_menuStrip.Show(ptLowerLeft);

                type_menuStrip.Tag = "true";
            }
            else
            {
                type.Image = Properties.Resources.down_arrow;
                type_menuStrip.Tag = "false";
                type_menuStrip.Close();
            }
        }

        // se puede cambiar este evento de click por uno de checked change o algo asi
        private void type_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sItem = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem item in type_menuStrip.Items)
            {
                if (item != sItem)
                    item.Checked = false;
            }
        }

        private void top_Click(object sender, EventArgs e)
        {
            if (top_menuStrip.Tag.ToString() == "false")
            {
                ((Button)sender).Image = Properties.Resources.up_arrow;

                Button btnSender = (Button)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                top_menuStrip.Show(ptLowerLeft);

                top_menuStrip.Tag = "true";
            }
            else
            {
                top.Image = Properties.Resources.down_arrow;
                top_menuStrip.Tag = "false";
                top_menuStrip.Close();
            }
        }

        private void type_SelectedItemChanged(object sender, EventArgs e)
        {
            type.Image = Properties.Resources.down_arrow;
            type_menuStrip.Tag = "false";

            var selectedType = findSelected(type_menuStrip.Items);
            if (selectedType == "Familias")
                top.Visible = false;

            else top.Visible = true;
        }
    }
}

