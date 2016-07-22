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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mainGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.type_menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosMasCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosMasCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosMenosCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosMenosCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.Button();
            this.top_menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.personalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.type = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).BeginInit();
            this.type_menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.top_menuStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGraph
            // 
            chartArea3.Name = "ChartArea1";
            this.mainGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.mainGraph.Legends.Add(legend3);
            this.mainGraph.Location = new System.Drawing.Point(280, 83);
            this.mainGraph.Name = "mainGraph";
            this.mainGraph.Size = new System.Drawing.Size(846, 547);
            this.mainGraph.TabIndex = 0;
            this.mainGraph.Text = "chart1";
            title3.Name = "Title";
            this.mainGraph.Titles.Add(title3);
            this.mainGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainGraph_MouseDoubleClick);
            // 
            // type_menuStrip
            // 
            this.type_menuStrip.AutoSize = false;
            this.type_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familiasToolStripMenuItem,
            this.articulosMasCotizadosToolStripMenuItem,
            this.serviciosMasCotizadosToolStripMenuItem,
            this.articulosMenosCotizadosToolStripMenuItem,
            this.serviciosMenosCotizadosToolStripMenuItem});
            this.type_menuStrip.Name = "contextMenuStrip1";
            this.type_menuStrip.ShowCheckMargin = true;
            this.type_menuStrip.ShowImageMargin = false;
            this.type_menuStrip.Size = new System.Drawing.Size(265, 136);
            this.type_menuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.type_menuStrip_Closed);
            // 
            // familiasToolStripMenuItem
            // 
            this.familiasToolStripMenuItem.AutoSize = false;
            this.familiasToolStripMenuItem.CheckOnClick = true;
            this.familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            this.familiasToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.familiasToolStripMenuItem.Text = "Familias";
            this.familiasToolStripMenuItem.Click += new System.EventHandler(this.type_ToolStripMenuItem_Click);
            // 
            // articulosMasCotizadosToolStripMenuItem
            // 
            this.articulosMasCotizadosToolStripMenuItem.AutoSize = false;
            this.articulosMasCotizadosToolStripMenuItem.CheckOnClick = true;
            this.articulosMasCotizadosToolStripMenuItem.Name = "articulosMasCotizadosToolStripMenuItem";
            this.articulosMasCotizadosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.articulosMasCotizadosToolStripMenuItem.Text = "Articulos mas cotizados";
            this.articulosMasCotizadosToolStripMenuItem.Click += new System.EventHandler(this.type_ToolStripMenuItem_Click);
            // 
            // serviciosMasCotizadosToolStripMenuItem
            // 
            this.serviciosMasCotizadosToolStripMenuItem.AutoSize = false;
            this.serviciosMasCotizadosToolStripMenuItem.CheckOnClick = true;
            this.serviciosMasCotizadosToolStripMenuItem.Name = "serviciosMasCotizadosToolStripMenuItem";
            this.serviciosMasCotizadosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.serviciosMasCotizadosToolStripMenuItem.Text = "Servicios mas cotizados";
            this.serviciosMasCotizadosToolStripMenuItem.Click += new System.EventHandler(this.type_ToolStripMenuItem_Click);
            // 
            // articulosMenosCotizadosToolStripMenuItem
            // 
            this.articulosMenosCotizadosToolStripMenuItem.AutoSize = false;
            this.articulosMenosCotizadosToolStripMenuItem.CheckOnClick = true;
            this.articulosMenosCotizadosToolStripMenuItem.Name = "articulosMenosCotizadosToolStripMenuItem";
            this.articulosMenosCotizadosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.articulosMenosCotizadosToolStripMenuItem.Text = "Articulos menos cotizados";
            this.articulosMenosCotizadosToolStripMenuItem.Click += new System.EventHandler(this.type_ToolStripMenuItem_Click);
            // 
            // serviciosMenosCotizadosToolStripMenuItem
            // 
            this.serviciosMenosCotizadosToolStripMenuItem.AutoSize = false;
            this.serviciosMenosCotizadosToolStripMenuItem.CheckOnClick = true;
            this.serviciosMenosCotizadosToolStripMenuItem.Name = "serviciosMenosCotizadosToolStripMenuItem";
            this.serviciosMenosCotizadosToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.serviciosMenosCotizadosToolStripMenuItem.Text = "Servicios menos cotizados";
            this.serviciosMenosCotizadosToolStripMenuItem.Click += new System.EventHandler(this.type_ToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 69);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(114, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Graficas";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Transparent;
            this.top.ContextMenuStrip = this.top_menuStrip;
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.top.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.top.Location = new System.Drawing.Point(0, 161);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(265, 46);
            this.top.TabIndex = 4;
            this.top.Text = "Top";
            this.top.UseVisualStyleBackColor = false;
            // 
            // top_menuStrip
            // 
            this.top_menuStrip.AutoSize = false;
            this.top_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripSeparator1,
            this.personalizadoToolStripMenuItem,
            this.toolStripTextBox1});
            this.top_menuStrip.Name = "top_menuStrip";
            this.top_menuStrip.ShowCheckMargin = true;
            this.top_menuStrip.ShowImageMargin = false;
            this.top_menuStrip.Size = new System.Drawing.Size(265, 167);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.CheckOnClick = true;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 22);
            this.toolStripMenuItem2.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AutoSize = false;
            this.toolStripMenuItem3.CheckOnClick = true;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(265, 22);
            this.toolStripMenuItem3.Text = "5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AutoSize = false;
            this.toolStripMenuItem4.CheckOnClick = true;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(265, 22);
            this.toolStripMenuItem4.Text = "7";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.AutoSize = false;
            this.toolStripMenuItem5.CheckOnClick = true;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(265, 22);
            this.toolStripMenuItem5.Text = "10";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // personalizadoToolStripMenuItem
            // 
            this.personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            this.personalizadoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.personalizadoToolStripMenuItem.Text = "Personalizado";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rango de fecha";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.generate);
            this.panel3.Controls.Add(this.top);
            this.panel3.Controls.Add(this.type);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 642);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 47);
            this.panel1.TabIndex = 15;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Brown;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.generate.Location = new System.Drawing.Point(0, 350);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(264, 67);
            this.generate.TabIndex = 14;
            this.generate.Text = "Generar";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(265, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(873, 69);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(273, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 2);
            this.panel5.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(272, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 570);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(672, 2);
            this.panel8.TabIndex = 2;
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Dock = System.Windows.Forms.DockStyle.Top;
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.type.Image = global::PRACTICA.Properties.Resources.down_arrow;
            this.type.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.type.Location = new System.Drawing.Point(0, 115);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(265, 46);
            this.type.TabIndex = 3;
            this.type.Text = "Tipo de grafica";
            this.type.UseVisualStyleBackColor = false;
            this.type.Click += new System.EventHandler(this.type_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PRACTICA.Properties.Resources.barChart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(11, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 67);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(280, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 642);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Graphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).EndInit();
            this.type_menuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.top_menuStrip.ResumeLayout(false);
            this.top_menuStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainGraph;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip type_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosMasCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosMasCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosMenosCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosMenosCotizadosToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.Button type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ContextMenuStrip top_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}