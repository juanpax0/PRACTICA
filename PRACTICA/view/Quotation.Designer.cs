namespace PRACTICA.view
{
    partial class Quotation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quotation));
            this.FromID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.ClientTag = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAmoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromID
            // 
            this.FromID.AutoSize = true;
            this.FromID.Location = new System.Drawing.Point(870, 79);
            this.FromID.Name = "FromID";
            this.FromID.Size = new System.Drawing.Size(50, 13);
            this.FromID.TabIndex = 0;
            this.FromID.Text = "Serial No";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(550, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 291);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem1.Text = "Add to Cart";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(550, 131);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(370, 20);
            this.TxtBoxSearch.TabIndex = 3;
            // 
            // ClientTag
            // 
            this.ClientTag.AutoSize = true;
            this.ClientTag.Location = new System.Drawing.Point(12, 83);
            this.ClientTag.Name = "ClientTag";
            this.ClientTag.Size = new System.Drawing.Size(106, 13);
            this.ClientTag.TabIndex = 4;
            this.ClientTag.Text = "ClientNo/ClientName";
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.Location = new System.Drawing.Point(467, 83);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(57, 13);
            this.Staff.TabIndex = 5;
            this.Staff.Text = "StaffName";
            // 
            // listView2
            // 
            this.listView2.ContextMenuStrip = this.contextMenuStrip2;
            this.listView2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(11, 166);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(457, 254);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAmoutToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(135, 48);
            // 
            // editAmoutToolStripMenuItem
            // 
            this.editAmoutToolStripMenuItem.Name = "editAmoutToolStripMenuItem";
            this.editAmoutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.editAmoutToolStripMenuItem.Text = "Edit Amout";
            this.editAmoutToolStripMenuItem.Click += new System.EventHandler(this.editAmoutToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(441, 444);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 13);
            this.Total.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista a Cotizar";
            // 
            // Quotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Staff);
            this.Controls.Add(this.ClientTag);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FromID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quotation";
            this.Text = "CotizacionView";
            this.Load += new System.EventHandler(this.CotizacionView_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.Label ClientTag;
        private System.Windows.Forms.Label Staff;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editAmoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}