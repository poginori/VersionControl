
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
            this.button_add = new System.Windows.Forms.Button();
            this.label_FullName = new System.Windows.Forms.Label();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
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
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(305, 102);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(347, 30);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "button1";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(301, 47);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(51, 20);
            this.label_FullName.TabIndex = 6;
            this.label_FullName.Text = "label1";
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(452, 47);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(200, 26);
            this.textBox_FullName.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_users);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_users;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox textBox_FullName;
    }
}

