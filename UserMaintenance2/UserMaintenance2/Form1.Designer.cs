﻿
namespace UserMaintenance2
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
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 20;
            this.listBox_users.Location = new System.Drawing.Point(32, 47);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.Size = new System.Drawing.Size(205, 324);
            this.listBox_users.TabIndex = 0;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(307, 50);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(51, 20);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "label1";
            this.label_LastName.Click += new System.EventHandler(this.label_LastName_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(458, 50);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(200, 26);
            this.textBox_LastName.TabIndex = 2;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(458, 103);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(200, 26);
            this.textBox_FirstName.TabIndex = 4;
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(307, 103);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(51, 20);
            this.label_FirstName.TabIndex = 3;
            this.label_FirstName.Text = "label2";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(311, 168);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(347, 30);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "button1";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.listBox_users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_users;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Button button_add;
    }
}

