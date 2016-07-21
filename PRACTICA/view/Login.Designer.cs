﻿using System.Drawing;

namespace PRACTICA
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.conn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_textBox
            // 
            this.user_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.user_textBox.Location = new System.Drawing.Point(62, 86);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(229, 20);
            this.user_textBox.TabIndex = 0;
            this.user_textBox.Tag = "";
            this.user_textBox.Text = "Usuario";
            this.user_textBox.Click += new System.EventHandler(this.user_textBox_Click);
            this.user_textBox.TextChanged += new System.EventHandler(this.user_textBox_TextChanged);
            this.user_textBox.ForeColor = Color.Gray;
            this.user_textBox.Text = "Type here";            
            // 
            // pass_textBox
            // 
            this.pass_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass_textBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pass_textBox.Location = new System.Drawing.Point(62, 145);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(229, 20);
            this.pass_textBox.TabIndex = 1;
            this.pass_textBox.Text = "Contraseña";
            this.pass_textBox.TextChanged += new System.EventHandler(this.pass_textBox_TextChanged);
            // 
            // conn
            // 
            this.conn.BackgroundImage = global::PRACTICA.Properties.Resources.conectar;
            this.conn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.conn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conn.Location = new System.Drawing.Point(96, 191);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(138, 41);
            this.conn.TabIndex = 4;
            this.conn.TabStop = false;
            this.conn.Click += new System.EventHandler(this.conn_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.conn);
            this.panel1.Controls.Add(this.user_textBox);
            this.panel1.Controls.Add(this.pass_textBox);
            this.panel1.Location = new System.Drawing.Point(167, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 252);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PRACTICA.Properties.Resources.password;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(28, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 30);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PRACTICA.Properties.Resources.username;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(167, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.BackgroundImage = global::PRACTICA.Properties.Resources.blacktexture;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(167, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 49);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese sus datos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PRACTICA.Properties.Resources.renteco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 395);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.conn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.PictureBox conn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

