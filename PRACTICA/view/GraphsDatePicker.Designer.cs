namespace PRACTICA.view
{
    partial class GraphsDatePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphsDatePicker));
            this.from = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.until = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(26, 95);
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
            this.save.Location = new System.Drawing.Point(163, 157);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(166, 46);
            this.save.TabIndex = 15;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // until
            // 
            this.until.Location = new System.Drawing.Point(265, 95);
            this.until.Name = "until";
            this.until.Size = new System.Drawing.Size(200, 20);
            this.until.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(85, 59);
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
            this.to.Location = new System.Drawing.Point(334, 59);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(67, 24);
            this.to.TabIndex = 18;
            this.to.Text = "Hasta";
            // 
            // GraphsDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(495, 249);
            this.Controls.Add(this.to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.until);
            this.Controls.Add(this.from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphsDatePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Seleccion de fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker until;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label to;
    }
}