﻿
namespace Gepitanulas2
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
            this.generationlabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generationlabel
            // 
            this.generationlabel.AutoSize = true;
            this.generationlabel.Location = new System.Drawing.Point(306, 370);
            this.generationlabel.Name = "generationlabel";
            this.generationlabel.Size = new System.Drawing.Size(92, 20);
            this.generationlabel.TabIndex = 0;
            this.generationlabel.Text = "1.generáció";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(310, 402);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 36);
            this.Startbutton.TabIndex = 1;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.generationlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label generationlabel;
        private System.Windows.Forms.Button Startbutton;
    }
}

