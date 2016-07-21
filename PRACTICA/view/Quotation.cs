using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace PRACTICA.view
{
    public partial class Quotation : Form
    {
        private int total;
        private static Regex regex = new Regex("^[0-9]+$");
        private bool flag = false;

        public Quotation()
        {
            InitializeComponent();
        }

        private void CotizacionView_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;


            listView1.Columns.Add("CODIGO", 70);
            listView1.Columns.Add("PRODUCTO", 180);
            listView1.Columns.Add("PRECIO", 70);

            listView2.Columns.Add("CODIGO", 70);
            listView2.Columns.Add("PRODUCTO", 180);
            listView2.Columns.Add("CANTIDAD", 70);
            listView2.Columns.Add("PRECIO", 70);

            ListViewItem itm;

            string[] productsArray = new string[3];

            productsArray[0] = "45646";
            productsArray[1] = "Encofrado DOKA";
            productsArray[2] = "7000";
            itm = new ListViewItem(productsArray);
            listView1.Items.Add(itm);

            productsArray[0] = "54655";
            productsArray[1] = "Puntales";
            productsArray[2] = "5000";
            itm = new ListViewItem(productsArray);
            listView1.Items.Add(itm);

            productsArray[0] = "56466";
            productsArray[1] = "Mezcladora Cemento";
            productsArray[2] = "35000";
            itm = new ListViewItem(productsArray);
            listView1.Items.Add(itm);

            productsArray[0] = "66541";
            productsArray[1] = "Drenajes ACO";
            productsArray[2] = "25000";
            itm = new ListViewItem(productsArray);
            listView1.Items.Add(itm);

            productsArray[0] = "81212";
            productsArray[1] = "Impermeabilizante VANDEX";
            productsArray[2] = "40000";
            itm = new ListViewItem(productsArray);
            listView1.Items.Add(itm);


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string response = Microsoft.VisualBasic.Interaction.InputBox("Cantidad", "Cantidad de Producto", "0", 4, 4);
            if (response != "" && regex.IsMatch(response) && response != "0")
            {

                string[] array = new string[4];
                ListViewItem itm;

                array[0] = listView1.SelectedItems[0].SubItems[0].Text;
                array[1] = listView1.SelectedItems[0].SubItems[1].Text;
                array[2] = response;
                array[3] = listView1.SelectedItems[0].SubItems[2].Text;
                itm = new ListViewItem(array);
                listView2.Items.Add(itm);

                total += (Int32.Parse(response) * Int32.Parse(array[3]));
                Total.Text = total.ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count != 0)
            {
                total -= (Int32.Parse(listView2.SelectedItems[0].SubItems[2].Text) *
                    Int32.Parse(listView2.SelectedItems[0].SubItems[3].Text));
                Total.Text = total.ToString();
                listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
            }
        }

        private void editAmoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count != 0)
            {
                string response = Microsoft.VisualBasic.Interaction.InputBox("Cantidad", "Cantidad de Producto", "0", 30, 30);

                if (response != "" && regex.IsMatch(response) && response != "0")
                {
                    listView2.SelectedItems[0].SubItems[2].Text = response;

                    int aux_total = 0;


                    for (int i = 0; i < listView2.Items.Count; i++)
                    {
                        aux_total += (Int32.Parse(listView2.Items[i].SubItems[2].Text) *
                            Int32.Parse(listView2.Items[i].SubItems[3].Text));
                    }

                    total = aux_total;
                    Total.Text = total.ToString();
                }
            }
        }

        private void ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView list = (ListView)sender;
            int total = list.Items.Count;
            list.BeginUpdate();
            ListViewItem[] items = new ListViewItem[total];
            if (flag)
            {
                for (int i = 0; i < total; i++)
                {
                    int count = list.Items.Count;
                    var minIdx = 0;
                    for (int j = 1; j < count; j++)
                    {
                        if (list.Items[j].SubItems[e.Column].Text.CompareTo(list.Items[minIdx].SubItems[e.Column].Text) > 0)
                            minIdx = j;
                    }
                    items[i] = list.Items[minIdx];
                    list.Items.RemoveAt(minIdx);
                }
                flag = false;
            }
            else
            {
                for (int i = 0; i < total; i++)
                {
                    int count = list.Items.Count;
                    int minIdx = 0;
                    for (int j = 1; j < count; j++)
                    {
                        if (list.Items[j].SubItems[e.Column].Text.CompareTo(list.Items[minIdx].SubItems[e.Column].Text) < 0)
                            minIdx = j;
                    }
                    items[i] = list.Items[minIdx];
                    list.Items.RemoveAt(minIdx);
                }
                flag = true;
            }
            list.Items.AddRange(items);
            list.EndUpdate();
        }
    }
}
