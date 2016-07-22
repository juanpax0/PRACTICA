namespace PRACTICA.view
{
    partial class MainMenu
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.reports = new System.Windows.Forms.PictureBox();
            this.graphs = new System.Windows.Forms.PictureBox();
            this.graph_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.quotation_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.quotation = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphs)).BeginInit();
            this.graph_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.quotation_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotation)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImage = global::PRACTICA.Properties.Resources.logout1;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(727, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(44, 43);
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.Transparent;
            this.reports.BackgroundImage = global::PRACTICA.Properties.Resources.report;
            this.reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports.Location = new System.Drawing.Point(18, 18);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(105, 107);
            this.reports.TabIndex = 3;
            this.reports.TabStop = false;
            this.reports.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.reports.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // graphs
            // 
            this.graphs.BackColor = System.Drawing.Color.Transparent;
            this.graphs.BackgroundImage = global::PRACTICA.Properties.Resources.grafico;
            this.graphs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graphs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphs.Location = new System.Drawing.Point(15, 18);
            this.graphs.Name = "graphs";
            this.graphs.Size = new System.Drawing.Size(116, 107);
            this.graphs.TabIndex = 2;
            this.graphs.TabStop = false;
            this.graphs.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.graphs.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // graph_panel
            // 
            this.graph_panel.BackColor = System.Drawing.Color.SandyBrown;
            this.graph_panel.Controls.Add(this.label1);
            this.graph_panel.Controls.Add(this.graphs);
            this.graph_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graph_panel.Location = new System.Drawing.Point(398, 137);
            this.graph_panel.Name = "graph_panel";
            this.graph_panel.Size = new System.Drawing.Size(292, 131);
            this.graph_panel.TabIndex = 6;
            this.graph_panel.Click += new System.EventHandler(this.graph_panel_Click);
            this.graph_panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.graph_panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Graficas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.reports);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(75, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 131);
            this.panel2.TabIndex = 7;
            this.panel2.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reportes";
            // 
            // quotation_panel
            // 
            this.quotation_panel.BackColor = System.Drawing.Color.Brown;
            this.quotation_panel.Controls.Add(this.label3);
            this.quotation_panel.Controls.Add(this.quotation);
            this.quotation_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quotation_panel.Location = new System.Drawing.Point(75, 301);
            this.quotation_panel.Name = "quotation_panel";
            this.quotation_panel.Size = new System.Drawing.Size(292, 133);
            this.quotation_panel.TabIndex = 7;
            this.quotation_panel.Click += new System.EventHandler(this.quotation_panel_Click);
            this.quotation_panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.quotation_panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cotizaciones";
            // 
            // quotation
            // 
            this.quotation.BackColor = System.Drawing.Color.Transparent;
            this.quotation.BackgroundImage = global::PRACTICA.Properties.Resources.cotizar1;
            this.quotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quotation.Location = new System.Drawing.Point(17, 14);
            this.quotation.Name = "quotation";
            this.quotation.Size = new System.Drawing.Size(114, 110);
            this.quotation.TabIndex = 3;
            this.quotation.TabStop = false;
            this.quotation.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.quotation.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.query);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(398, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 133);
            this.panel4.TabIndex = 7;
            this.panel4.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Productos";
            // 
            // query
            // 
            this.query.BackColor = System.Drawing.Color.Transparent;
            this.query.BackgroundImage = global::PRACTICA.Properties.Resources.consulta;
            this.query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.query.Location = new System.Drawing.Point(18, 14);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(105, 110);
            this.query.TabIndex = 0;
            this.query.TabStop = false;
            this.query.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.query.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 506);
            this.Controls.Add(this.quotation_panel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.graph_panel);
            this.Controls.Add(this.exit);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.GraphsRepoMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphs)).EndInit();
            this.graph_panel.ResumeLayout(false);
            this.graph_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.quotation_panel.ResumeLayout(false);
            this.quotation_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quotation)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox graphs;
        private System.Windows.Forms.PictureBox reports;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel graph_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel quotation_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox quotation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox query;
    }
}