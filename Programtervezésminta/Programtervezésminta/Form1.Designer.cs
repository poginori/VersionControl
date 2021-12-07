
namespace Programtervezésminta
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
            this.components = new System.ComponentModel.Container();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncar = new System.Windows.Forms.Button();
            this.btnball = new System.Windows.Forms.Button();
            this.Createtimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btncolor = new System.Windows.Forms.Button();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.btncolor);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.btncar);
            this.mainpanel.Controls.Add(this.btnball);
            this.mainpanel.Location = new System.Drawing.Point(79, 62);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(622, 334);
            this.mainpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // btncar
            // 
            this.btncar.Location = new System.Drawing.Point(169, 15);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(116, 34);
            this.btncar.TabIndex = 1;
            this.btncar.Text = "Car";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btnball
            // 
            this.btnball.Location = new System.Drawing.Point(3, 15);
            this.btnball.Name = "btnball";
            this.btnball.Size = new System.Drawing.Size(116, 34);
            this.btnball.TabIndex = 0;
            this.btnball.Text = "Ball";
            this.btnball.UseVisualStyleBackColor = true;
            this.btnball.Click += new System.EventHandler(this.button1_Click);
            // 
            // Createtimer
            // 
            this.Createtimer.Enabled = true;
            this.Createtimer.Interval = 3000;
            this.Createtimer.Tick += new System.EventHandler(this.Createtimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btncolor
            // 
            this.btncolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncolor.Location = new System.Drawing.Point(3, 55);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(116, 34);
            this.btncolor.TabIndex = 3;
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer Createtimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btncolor;
    }
}

