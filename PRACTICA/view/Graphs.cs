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
                    getFamilies(from, until, top);

                else if (type == "Articulos mas cotizados")
                    getTop("products", from, until, top);

                else if (type == "Servicios mas cotizados")
                    getTop("servicies", from, until, top);

                else if (type == "Articulos menos cotizados")
                    getBottom("products", from, until, top);

                else if (type == "Servicios menos cotizados")
                    getBottom("servicies", from, until, top);

                mainGraph.ChartAreas[0].RecalculateAxesScale();
            }
            else {
                DialogResult dr =
                    MessageBox.Show("Asegúrese de que los datos introducidos sean correctos.",
                    "¡Alerta!", MessageBoxButtons.OK);
            }
        }

        private void getFamilies(string from, string until, int top)
        {
            List<Family> fls = query.getFamilies(from, until, top);
            mainGraph.Series.Add("Familias");
            mainGraph.Series[0].ChartType = SeriesChartType.Pie;
            mainGraph.Titles[0].Text = string.Format("Grafica de Familias. Desde {0} hasta {1}.", from, until);

            var total = 19;   //total de registros en las familias

            for (int i = 0; i < fls.Count; i++) {
                mainGraph.Series[0].Points.AddXY(((fls[i].n * 100.00) / total).ToString("0.00"), fls[i].n);
                mainGraph.Series[0].Points[i].LegendText = fls[i].name;
            }
        }

        /* Estas no tienen el titulo de la grafica que les corresponde. */
        private void getTop(string method, string from, string until, int top)
        {
            List<Product> prs = (method == "products") ? query.getTopProducts(from, until, top) :
                query.getTopServices(from, until, top);

            for (int i = 0; i < prs.Count; i++)
            {
                mainGraph.Series.Add(prs[i].name);
                mainGraph.ApplyPaletteColors();
                mainGraph.Series[0].Points.AddY(prs[i].quotationNum);
                mainGraph.Series[0].Points[i].Color = mainGraph.Series[i].Color;
            }
        }

        private void getBottom(string method, string from, string until, int top)
        {
            List<NoProduct> prs = (method == "products") ? query.getBottomProducts(from, until, top) :
                query.getBottomServices(from, until, top);

            for (int i = 0; i < prs.Count; i++)
            {
                mainGraph.Series.Add(prs[i].name);
                mainGraph.ApplyPaletteColors();
                mainGraph.Series[0].Points.AddY(prs[i].quotationNum);
                mainGraph.Series[0].Points[i].Color = mainGraph.Series[i].Color;
            }
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            insertData.ShowDialog();
        }

        // Para detectar a que barra o parte del pie se le dio click
        private void mainGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = mainGraph.HitTest(e.X, e.Y);
            if (hit.PointIndex >= 0)
                Console.WriteLine("DASDASDASDASD:" + hit.PointIndex);
        }
        //..........................................................
    }
}
