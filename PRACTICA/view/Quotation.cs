using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



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
            listView2.Columns.Add("CANTIDAD", 90);
            listView2.Columns.Add("PRECIO", 70);
            listView2.Columns.Add("% DESCUENTO", 150);

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
            string response = Microsoft.VisualBasic.Interaction.InputBox("Cantidad", 
                "Cantidad de Producto", "0", 4, 4);
            listView2.BeginUpdate();
            if (response != "" && regex.IsMatch(response) && response != "0")
            {

                string[] array = new string[5];
                ListViewItem itm;
                
                array[0] = listView1.SelectedItems[0].SubItems[0].Text;
                array[1] = listView1.SelectedItems[0].SubItems[1].Text;
                array[2] = response;
                array[3] = listView1.SelectedItems[0].SubItems[2].Text;
                array[4] = "";
                itm = new ListViewItem(array);
                listView2.Items.Add(itm);

                total += (Int32.Parse(response) * Int32.Parse(array[3]));
                Total.Text = total.ToString();
            }
            listView2.EndUpdate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView newList = listView2;
            int result = 0;
            listView2.BeginUpdate();            
            foreach (ListViewItem item in newList.SelectedItems)
            {
                if (item.SubItems[4].Text == "")
                {
                    result += (Int32.Parse(item.SubItems[3].Text) * Int32.Parse(item.SubItems[2].Text));
                    item.Remove();
                }
                else {
                    double percent = Int32.Parse(item.SubItems[4].Text) / 100.00;

                    result += (Int32) ((Int32.Parse(item.SubItems[3].Text) 
                        * Int32.Parse(item.SubItems[2].Text)) 
                        - ((Int32.Parse(item.SubItems[3].Text) 
                        * Int32.Parse(item.SubItems[2].Text) * percent)));
                    item.Remove();
                }

            }
            total = ((Int32.Parse(Total.Text) - result) > 0) ? Int32.Parse(Total.Text) - result : 0;
            Total.Text = total.ToString();
            listView2.EndUpdate();
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

        private void TextBox1Discount_KeyDown(object sender, KeyEventArgs e)
        {
            var list = listView2;
            var input = TextBox1Discount.Text;
            var price = Double.Parse(list.SelectedItems[0].SubItems[3].Text);
            var amount = Double.Parse(list.SelectedItems[0].SubItems[2].Text);
            if (e.KeyCode == Keys.Enter)
            {
                if (input != "" && regex.IsMatch(input))
                {
                    if (Int32.Parse(input) > 0 && Int32.Parse(input) < 101)
                    {
                        double percent = Int32.Parse(input) / 100.00;
                        total -= (Int32)((price * amount) * percent);
                        Total.Text = total.ToString();
                        list.SelectedItems[0].SubItems[4].Text = input;
                        TextBox1Discount.Clear();
                        contextMenuStrip2.Close();
                    }
                }
            }
        }
    }
}
