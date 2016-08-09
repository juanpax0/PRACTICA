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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insertDat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generate = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.mainGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainGraph.Legends.Add(legend1);
            this.mainGraph.Location = new System.Drawing.Point(279, 20);
            this.mainGraph.Name = "mainGraph";
            this.mainGraph.Size = new System.Drawing.Size(846, 610);
            this.mainGraph.TabIndex = 0;
            this.mainGraph.Text = "chart1";
            title1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            this.mainGraph.Titles.Add(title1);
            this.mainGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainGraph_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 96);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PRACTICA.Properties.Resources.renteco_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 96);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(116, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Graficas";
            // 
            // insertDat
            // 
            this.insertDat.BackColor = System.Drawing.Color.Transparent;
            this.insertDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.insertDat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertDat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.insertDat.Location = new System.Drawing.Point(0, 96);
            this.insertDat.Name = "insertDat";
            this.insertDat.Size = new System.Drawing.Size(265, 83);
            this.insertDat.TabIndex = 2;
            this.insertDat.Text = "Ingresar datos";
            this.insertDat.UseVisualStyleBackColor = false;
            this.insertDat.Click += new System.EventHandler(this.insertData_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.generate);
            this.panel3.Controls.Add(this.insertDat);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 642);
            this.panel3.TabIndex = 13;
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.Brown;
            this.generate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.generate.Location = new System.Drawing.Point(0, 555);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(265, 85);
            this.generate.TabIndex = 14;
            this.generate.Text = "Generar";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(272, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(873, 2);
            this.panel5.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(271, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 630);
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
            // Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 642);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Graphs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            ((System.ComponentModel.ISupportInitialize)(this.mainGraph)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button insertDat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}