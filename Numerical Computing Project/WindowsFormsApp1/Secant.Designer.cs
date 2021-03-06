﻿namespace WindowsFormsApp1
{
    partial class Secant
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
            this.fixedPointMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.secantMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtonRaphsonMEthodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularFalsiMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bisectionMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.questions = new System.Windows.Forms.ComboBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regularFalsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularFalsiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fixedPointMethodToolStripMenuItem
            // 
            this.fixedPointMethodToolStripMenuItem.Name = "fixedPointMethodToolStripMenuItem";
            this.fixedPointMethodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fixedPointMethodToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.fixedPointMethodToolStripMenuItem.Text = "Fixed Point Method";
            this.fixedPointMethodToolStripMenuItem.Click += new System.EventHandler(this.fixedPointMethodToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // secantMethodToolStripMenuItem
            // 
            this.secantMethodToolStripMenuItem.Name = "secantMethodToolStripMenuItem";
            this.secantMethodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.secantMethodToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.secantMethodToolStripMenuItem.Text = "Secant Method";
            this.secantMethodToolStripMenuItem.Click += new System.EventHandler(this.secantMethodToolStripMenuItem_Click);
            // 
            // newtonRaphsonMEthodToolStripMenuItem
            // 
            this.newtonRaphsonMEthodToolStripMenuItem.Name = "newtonRaphsonMEthodToolStripMenuItem";
            this.newtonRaphsonMEthodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.newtonRaphsonMEthodToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.newtonRaphsonMEthodToolStripMenuItem.Text = "Newton Raphson MEthod";
            this.newtonRaphsonMEthodToolStripMenuItem.Click += new System.EventHandler(this.newtonRaphsonMEthodToolStripMenuItem_Click);
            // 
            // regularFalsiMethodToolStripMenuItem
            // 
            this.regularFalsiMethodToolStripMenuItem.Name = "regularFalsiMethodToolStripMenuItem";
            this.regularFalsiMethodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.regularFalsiMethodToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.regularFalsiMethodToolStripMenuItem.Text = "Regular Falsi Method";
            this.regularFalsiMethodToolStripMenuItem.Click += new System.EventHandler(this.regularFalsiMethodToolStripMenuItem_Click);
            // 
            // bisectionMethodToolStripMenuItem
            // 
            this.bisectionMethodToolStripMenuItem.Name = "bisectionMethodToolStripMenuItem";
            this.bisectionMethodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.bisectionMethodToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.bisectionMethodToolStripMenuItem.Text = "Bisection Method";
            this.bisectionMethodToolStripMenuItem.Click += new System.EventHandler(this.bisectionMethodToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bisectionMethodToolStripMenuItem,
            this.regularFalsiMethodToolStripMenuItem,
            this.newtonRaphsonMEthodToolStripMenuItem,
            this.secantMethodToolStripMenuItem,
            this.fixedPointMethodToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 326);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(363, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 49);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "X1";
            // 
            // questions
            // 
            this.questions.FormattingEnabled = true;
            this.questions.Items.AddRange(new object[] {
            "xe^x-1",
            "xlog x-1.2",
            "3x-Cosx-1"});
            this.questions.Location = new System.Drawing.Point(108, 78);
            this.questions.Name = "questions";
            this.questions.Size = new System.Drawing.Size(154, 21);
            this.questions.TabIndex = 24;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(192, 134);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 23;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(49, 135);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Xn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Secant Method";
            // 
            // regularFalsiBindingSource
            // 
            this.regularFalsiBindingSource.DataSource = typeof(WindowsFormsApp1.RegularFalsi);
            // 
            // Secant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 517);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questions);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Secant";
            this.Text = "Secant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regularFalsiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fixedPointMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem secantMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtonRaphsonMEthodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularFalsiMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bisectionMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource regularFalsiBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox questions;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}