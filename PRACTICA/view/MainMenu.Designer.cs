﻿namespace PRACTICA.view
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.queries = new System.Windows.Forms.Button();
            this.graphs = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.Button();
            this.quotation = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(13, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 2);
            this.panel5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 72);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PRACTICA.Properties.Resources.logo_renteco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 72);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // queries
            // 
            this.queries.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // graphs
            // 
            this.graphs.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // quotation
            // 
            this.quotation.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PRACTICA.Properties.Resources.renteco_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(727, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 72);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 506);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button quotation;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button graphs;
        private System.Windows.Forms.Button queries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}