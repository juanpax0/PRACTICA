﻿using PRACTICA.dao;
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
        GraphsDatePicker dateP = new GraphsDatePicker();

        public Graphs()
        {
            InitializeComponent();
        }

        private void Graphs_Load(object sender, EventArgs e)
        {
            var tsl = new ToolStripLabel("Personalizado");
            top_menuStrip.Items.Insert(5, tsl);
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

        private void generate_Click(object sender, EventArgs e)
        {
            object selectedType = findSelected(type_menuStrip.Items);
            object dateFrom = dateP.dateFrom;
            object dateUntil = dateP.dateUntil;

            if (selectedType != null && dateFrom != null && dateUntil != null)
            {
                var from = ((DateTime)dateFrom).ToShortDateString();
                var until = ((DateTime)dateUntil).ToShortDateString();
                var type = selectedType.ToString();

                if (type == "Familias")
                {
                    mainGraph.Series.Clear();
                    animation.Dispose();
                    families(from, until);
                    mainGraph.ChartAreas[0].RecalculateAxesScale();
                }
                else
                {
                    object selectedTop = findSelected(top_menuStrip.Items);
                    var top = (selectedTop == null) ? 0 : int.Parse(selectedTop.ToString());

                    if (top != 0)
                    {
                        mainGraph.Series.Clear();
                        animation.Dispose();

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
            }
        }

        private void families(string from, string until)
        {
            List<Family> fls = query.getFamilies(from, until);
            mainGraph.Series.Add("Familias");
            mainGraph.Series[0].ChartType = SeriesChartType.Pie;
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

        // para detectar a que barra o parte del pie se le dio click
        private void mainGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HitTestResult hit = mainGraph.HitTest(e.X, e.Y);
            if (hit.PointIndex >= 0)
                Console.WriteLine("DASDASDASDASD:" + hit.PointIndex);
        }
        //..........................................................

        private void type_Click(object sender, EventArgs e)
        {
            if (type.Tag.ToString() == "close")
            {
                type.Image = Properties.Resources.up_arrow;
                Point ptLowerLeft = new Point(0, type.Height);
                ptLowerLeft = type.PointToScreen(ptLowerLeft);

                type_menuStrip.Show(ptLowerLeft);
            }
            else
                type.Tag = "close";
        }

        private void type_menuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            var point = this.PointToClient(Control.MousePosition);

            if (point.X > 3 && point.X < 262 && point.Y > 117 && point.Y < 159)
                type.Tag = "open";

            type.Image = Properties.Resources.down_arrow;
        }

        private void type_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedType = findSelected(type_menuStrip.Items);
            var sItem = (ToolStripMenuItem)sender;

            if (selectedType == "Familias")
                top.Visible = false;

            else
                top.Visible = true;

            foreach (ToolStripMenuItem item in type_menuStrip.Items)
            {
                if (item != sItem)
                    item.Checked = false;
            }
        }

        private void top_Click(object sender, EventArgs e)
        {
            if (top.Tag.ToString() == "close")
            {
                top.Image = Properties.Resources.up_arrow;
                Point ptLowerLeft = new Point(0, top.Height);
                ptLowerLeft = top.PointToScreen(ptLowerLeft);

                top_menuStrip.Show(ptLowerLeft);
            }
            else
                top.Tag = "close";
        }

        private void top_menuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            var point = this.PointToClient(Control.MousePosition);

            if (point.X > 3 && point.X < 262 && point.Y > 159 && point.Y < 201)
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

        private void datePicker_Click(object sender, EventArgs e)
        {
            dateP.ShowDialog();
        }
    }
}
