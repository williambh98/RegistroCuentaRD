﻿namespace RegistroCuentaRD
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.herramientaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem1});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cuentasToolStripMenuItem.Text = "Registros";
            // 
            // cuentasToolStripMenuItem1
            // 
            this.cuentasToolStripMenuItem1.Name = "cuentasToolStripMenuItem1";
            this.cuentasToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.cuentasToolStripMenuItem1.Text = "Cuentas";
            this.cuentasToolStripMenuItem1.Click += new System.EventHandler(this.cuentasToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // herramientaToolStripMenuItem
            // 
            this.herramientaToolStripMenuItem.Name = "herramientaToolStripMenuItem";
            this.herramientaToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.herramientaToolStripMenuItem.Text = "Herramienta";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientaToolStripMenuItem;
    }
}

