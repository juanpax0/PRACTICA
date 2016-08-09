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
        InsertData insertData = new InsertData();

        public Graphs()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            object dateFrom = insertData.dateFrom;
            object dateUntil = insertData.dateUntil;
            object selectedType = insertData.selectedType;
            object selectedTop = insertData.selectedTop;

            if (dateFrom != null && dateUntil != null && selectedType != null &&
                selectedTop != null)
            {
                var from = ((DateTime)dateFrom).ToShortDateString();
                var until = ((DateTime)dateUntil).ToShortDateString();
                var type = selectedType.ToString();
                var top = int.Parse(selectedTop.ToString());

                mainGraph.Series.Clear();

                if (type == "Familias")
                    families(from, until, top);

                else if (type == "Articulos mas cotizados")
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

        private void families(string from, string until, int top)
        {
            List<Family> fls = query.getFamilies(from, until);
            mainGraph.Series.Add("Familias");
            mainGraph.Series[0].ChartType = SeriesChartType.Pie;
            mainGraph.Titles[0].Text = string.Format("Grafica de Familias. Desde {0} hasta {1}.", from, until);
            var i = 0;

            var total = 19;   //total de registros en las familias

            foreach (var f in fls)
            {
                // Este tipo de formateo hace redondeo de una vez.
                mainGraph.Series[0].Points.AddXY(((f.n * 100.00) / total).ToString("0.00"), f.n);
                mainGraph.Series[0].Points[i].LegendText = f.name;
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

        private void insertData_Click(object sender, EventArgs e)
        {
            insertData.ShowDialog();
        }

        // para detectar a que barra o parte del pie se le dio click
        private void mainGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = mainGraph.HitTest(e.X, e.Y);
            if (hit.PointIndex >= 0)
                Console.WriteLine("DASDASDASDASD:" + hit.PointIndex);
        }
        //..........................................................
    }
}
