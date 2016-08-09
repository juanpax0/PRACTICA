namespace PRACTICA.view
{
    partial class InsertData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertData));
            this.from = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.until = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.Button();
            this.type = new System.Windows.Forms.Button();
            this.top_menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.three = new System.Windows.Forms.ToolStripMenuItem();
            this.five = new System.Windows.Forms.ToolStripMenuItem();
            this.seven = new System.Windows.Forms.ToolStripMenuItem();
            this.ten = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.customize = new System.Windows.Forms.ToolStripTextBox();
            this.type_menuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosMasCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosMasCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosMenosCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosMenosCotizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top_menuStrip.SuspendLayout();
            this.type_menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.from.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.from.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.from.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.from.Location = new System.Drawing.Point(136, 114);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(200, 20);
            this.from.TabIndex = 0;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Brown;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.save.Location = new System.Drawing.Point(242, 402);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(214, 65);
            this.save.TabIndex = 15;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // until
            // 
            this.until.Location = new System.Drawing.Point(375, 114);
            this.until.Name = "until";
            this.until.Size = new System.Drawing.Size(200, 20);
            this.until.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(195, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Desde";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.SystemColors.WindowText;
            this.to.Location = new System.Drawing.Point(444, 78);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(67, 24);
            this.to.TabIndex = 18;
            this.to.Text = "Hasta";
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.top.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.top.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.top.Image = global::PRACTICA.Properties.Resources.down_arrow;
            this.top.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.top.Location = new System.Drawing.Point(215, 283);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(265, 40);
            this.top.TabIndex = 20;
            this.top.Tag = "close";
            this.top.Text = "Top";
            this.top.UseVisualStyleBackColor = false;
            this.top.Click += new System.EventHandler(this.typeOrTop_Click);
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.type.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.type.Image = global::PRACTICA.Properties.Resources.down_arrow;
            this.type.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.type.Location = new System.Drawing.Point(215, 190);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(265, 40);
            this.type.TabIndex = 19;
            this.type.Tag = "close";
            this.type.Text = "Tipo de grafica";
            this.type.UseVisualStyleBackColor = false;
            this.type.Click += new System.EventHandler(this.typeOrTop_Click);
            // 
            // top_menuStrip
            // 
            this.top_menuStrip.AutoSize = false;
            this.top_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.three,
            this.five,
            this.seven,
            this.ten,
            this.toolStripSeparator1,
            this.customize});
            this.top_menuStrip.Name = "top_menuStrip";
            this.top_menuStrip.ShowCheckMargin = true;
            this.top_menuStrip.ShowImageMargin = false;
            this.top_menuStrip.Size = new System.Drawing.Size(265, 165);
            this.top_menuStrip.Tag = "false";
            this.top_menuStrip.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.top_menuStrip_Closed);
            // 
            // three
            // 
            this.three.AutoSize = false;
            this.three.CheckOnClick = true;
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(265, 22);
            this.three.Text = "3";
            this.three.Click += new System.EventHandler(this.top_ToolStripMenuItem_Click);
            // 
            // five
            // 
            this.five.AutoSize = false;
            this.five.CheckOnClick = true;
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(265, 22);
            this.five.Text = "5";
            this.five.Click += new System.EventHandler(this.top_ToolStripMenuItem_Click);
            // 
            // seven
            // 
            this.seven.AutoSize = false;
            this.seven.CheckOnClick = true;
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(265, 22);
            this.seven.Text = "7";
            this.seven.Click += new System.EventHandler(this.top_ToolStripMenuItem_Click);
            // 
            // ten
            // 
            this.ten.AutoSize = false;
            this.ten.CheckOnClick = true;
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(265, 22);
            this.ten.Text = "10";
            this.ten.Click += new System.EventHandler(this.top_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // customize
            // 
            this.customize.AutoSize = false;
            this.customize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(220, 23);
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
            this.type_menuStrip.Tag = "";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::PRACTICA.Properties.Resources.renteco_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(653, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 72);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 72);
            this.panel1.TabIndex = 22;
            // 
            // GraphsDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.top);
            this.Controls.Add(this.type);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.until);
            this.Controls.Add(this.from);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphsDatePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingreso de datos";
            this.Load += new System.EventHandler(this.GraphsDatePicker_Load);
            this.top_menuStrip.ResumeLayout(false);
            this.top_menuStrip.PerformLayout();
            this.type_menuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker until;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.Button type;
        private System.Windows.Forms.ContextMenuStrip top_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem three;
        private System.Windows.Forms.ToolStripMenuItem five;
        private System.Windows.Forms.ToolStripMenuItem seven;
        private System.Windows.Forms.ToolStripMenuItem ten;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox customize;
        private System.Windows.Forms.ContextMenuStrip type_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosMasCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosMasCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosMenosCotizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosMenosCotizadosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}