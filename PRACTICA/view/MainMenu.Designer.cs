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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel5 = new System.Windows.Forms.Panel();
            this.queries = new System.Windows.Forms.Button();
            this.graphs = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.quotation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(13, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 2);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.Khaki;
            this.reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Image = global::PRACTICA.Properties.Resources.reports;
            this.reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports.Location = new System.Drawing.Point(75, 152);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(292, 130);
            this.reports.TabIndex = 0;
            this.reports.Text = "Reportes  ";
            this.reports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reports.UseVisualStyleBackColor = false;
            // 
            // graphs
            // 
            this.graphs.BackColor = System.Drawing.Color.SandyBrown;
            this.graphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphs.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphs.Image = global::PRACTICA.Properties.Resources.graphs;
            this.graphs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.graphs.Location = new System.Drawing.Point(431, 152);
            this.graphs.Name = "graphs";
            this.graphs.Size = new System.Drawing.Size(292, 130);
            this.graphs.TabIndex = 1;
            this.graphs.Text = "Graficas    ";
            this.graphs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.graphs.UseVisualStyleBackColor = false;
            this.graphs.Click += new System.EventHandler(this.graphs_Click);
            // 
            // quotation
            // 
            this.quotation.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.quotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quotation.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotation.Image = global::PRACTICA.Properties.Resources.quotation;
            this.quotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quotation.Location = new System.Drawing.Point(75, 304);
            this.quotation.Name = "quotation";
            this.quotation.Size = new System.Drawing.Size(292, 130);
            this.quotation.TabIndex = 2;
            this.quotation.Text = "Cotizar    ";
            this.quotation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quotation.UseVisualStyleBackColor = false;
            this.quotation.Click += new System.EventHandler(this.quotation_Click);
            // 
            // queries
            // 
            this.queries.BackColor = System.Drawing.Color.LightSteelBlue;
            this.queries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queries.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queries.Image = global::PRACTICA.Properties.Resources.queries;
            this.queries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.queries.Location = new System.Drawing.Point(431, 304);
            this.queries.Name = "queries";
            this.queries.Size = new System.Drawing.Size(292, 130);
            this.queries.TabIndex = 3;
            this.queries.Text = "Productos y Servicios   ";
            this.queries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.queries.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 506);
            this.Controls.Add(this.queries);
            this.Controls.Add(this.graphs);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.quotation);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button quotation;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button graphs;
        private System.Windows.Forms.Button queries;
    }
}