
namespace Mikroszimulacio2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.zaroevnum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnepessegfajl = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.zaroevnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Záróév";
            // 
            // zaroevnum
            // 
            this.zaroevnum.Location = new System.Drawing.Point(91, 16);
            this.zaroevnum.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.zaroevnum.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.zaroevnum.Name = "zaroevnum";
            this.zaroevnum.Size = new System.Drawing.Size(99, 26);
            this.zaroevnum.TabIndex = 1;
            this.zaroevnum.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Népesség fájl";
            // 
            // txtnepessegfajl
            // 
            this.txtnepessegfajl.Location = new System.Drawing.Point(349, 11);
            this.txtnepessegfajl.Name = "txtnepessegfajl";
            this.txtnepessegfajl.Size = new System.Drawing.Size(100, 26);
            this.txtnepessegfajl.TabIndex = 3;
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(497, 3);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(83, 35);
            this.browsebutton.TabIndex = 4;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(615, 3);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(83, 35);
            this.startbutton.TabIndex = 5;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(686, 390);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.txtnepessegfajl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zaroevnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.zaroevnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown zaroevnum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnepessegfajl;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

