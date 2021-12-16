
namespace webservice
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartratedate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tolPicker = new System.Windows.Forms.DateTimePicker();
            this.igPicker = new System.Windows.Forms.DateTimePicker();
            this.cbvaluta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartratedate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(496, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartratedate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartratedate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartratedate.Legends.Add(legend1);
            this.chartratedate.Location = new System.Drawing.Point(510, 77);
            this.chartratedate.Name = "chartratedate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartratedate.Series.Add(series1);
            this.chartratedate.Size = new System.Drawing.Size(590, 269);
            this.chartratedate.TabIndex = 1;
            this.chartratedate.Text = "chart1";
            // 
            // tolPicker
            // 
            this.tolPicker.Location = new System.Drawing.Point(12, 12);
            this.tolPicker.Name = "tolPicker";
            this.tolPicker.Size = new System.Drawing.Size(191, 26);
            this.tolPicker.TabIndex = 2;
            this.tolPicker.ValueChanged += new System.EventHandler(this.paramchanged);
            // 
            // igPicker
            // 
            this.igPicker.Location = new System.Drawing.Point(222, 12);
            this.igPicker.Name = "igPicker";
            this.igPicker.Size = new System.Drawing.Size(191, 26);
            this.igPicker.TabIndex = 3;
            this.igPicker.ValueChanged += new System.EventHandler(this.paramchanged);
            // 
            // cbvaluta
            // 
            this.cbvaluta.FormattingEnabled = true;
            this.cbvaluta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cbvaluta.Location = new System.Drawing.Point(445, 12);
            this.cbvaluta.Name = "cbvaluta";
            this.cbvaluta.Size = new System.Drawing.Size(150, 28);
            this.cbvaluta.TabIndex = 4;
            this.cbvaluta.SelectedIndexChanged += new System.EventHandler(this.paramchanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.cbvaluta);
            this.Controls.Add(this.igPicker);
            this.Controls.Add(this.tolPicker);
            this.Controls.Add(this.chartratedate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartratedate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartratedate;
        private System.Windows.Forms.DateTimePicker tolPicker;
        private System.Windows.Forms.DateTimePicker igPicker;
        private System.Windows.Forms.ComboBox cbvaluta;
    }
}

