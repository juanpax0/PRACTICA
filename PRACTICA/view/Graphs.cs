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

            //object selectedType = type_combo.SelectedItem;
            //object selectedTop = top_combo.SelectedItem;

            object selectedType = "Articulos mas cotizados";
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

                else if (type == "Articulos mas solicitados no ofrecidos")
                {

                }
                else if (type == "Servicios mas solicitados no ofrecidos")
                {

                }

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

        private void mainGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = mainGraph.HitTest(e.X, e.Y);
            if (hit.PointIndex >= 0)
                Console.WriteLine("DASDASDASDASD:" + hit.PointIndex);
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* var selectedType = type_combo.SelectedIndex;
            if (selectedType == 0)
            {
                top_label.Visible = false;
                top_combo.Visible = false;
            }
            else
            {
                top_label.Visible = true;
                top_combo.Visible = true;
            }*/
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

