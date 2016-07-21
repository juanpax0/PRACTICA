namespace PRACTICA.view
{
    partial class Graphs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graphs));
            this.mainGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.top_label = new System.Windows.Forms.Label();
            this.top_combo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.create = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.mainGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainGraph.Legends.Add(legend1);
            this.mainGraph.Location = new System.Drawing.Point(350, 81);
            this.mainGraph.Name = "mainGraph";
            this.mainGraph.Size = new System.Drawing.Size(788, 560);
            this.mainGraph.TabIndex = 0;
            this.mainGraph.Text = "chart1";
            title1.Name = "Title";
            this.mainGraph.Titles.Add(title1);
            this.mainGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainGraph_MouseDoubleClick);
            // 
            // desde
            // 
            this.desde.Location = new System.Drawing.Point(41, 128);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(226, 20);
            this.desde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // hasta
            // 
            this.hasta.Location = new System.Drawing.Point(41, 232);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(226, 20);
            this.hasta.TabIndex = 4;
            // 
            // type_combo
            // 
            this.type_combo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "Familias",
            "Articulos mas cotizados",
            "Servicios mas cotizados",
            "Articulos menos cotizados",
            "Servicios menos cotizados",
            "Articulos mas solicitados no ofrecidos",
            "Servicios mas solicitados no ofrecidos"});
            this.type_combo.Location = new System.Drawing.Point(41, 334);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(226, 21);
            this.type_combo.TabIndex = 5;
            this.type_combo.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de grafica:";
            // 
            // top_label
            // 
            this.top_label.AutoSize = true;
            this.top_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_label.Location = new System.Drawing.Point(36, 405);
            this.top_label.Name = "top_label";
            this.top_label.Size = new System.Drawing.Size(59, 25);
            this.top_label.TabIndex = 9;
            this.top_label.Text = "Top:";
            // 
            // top_combo
            // 
            this.top_combo.FormattingEnabled = true;
            this.top_combo.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "10"});
            this.top_combo.Location = new System.Drawing.Point(41, 433);
            this.top_combo.Name = "top_combo";
            this.top_combo.Size = new System.Drawing.Size(226, 21);
            this.top_combo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(350, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 560);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::PRACTICA.Properties.Resources.logout1;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(1065, 24);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(45, 42);
            this.exit.TabIndex = 8;
            this.exit.TabStop = false;
            // 
            // create
            // 
            this.create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("create.BackgroundImage")));
            this.create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.Location = new System.Drawing.Point(67, 539);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(146, 46);
            this.create.TabIndex = 7;
            this.create.TabStop = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.top_combo);
            this.Controls.Add(this.top_label);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.hasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desde);
            this.Controls.Add(this.mainGraph);
            this.Name = "Graphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainGraph;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox create;
        public System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label top_label;
        private System.Windows.Forms.ComboBox top_combo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}