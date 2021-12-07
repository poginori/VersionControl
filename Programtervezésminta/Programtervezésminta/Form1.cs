using Programtervezésminta.Abstractions;
using Programtervezésminta.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programtervezésminta
{
    public partial class Form1 : Form
    {
        List<Toy> toys = new List<Toy>();
        Toy nexttoy;

        private IToyFactory toyFactory;

        public IToyFactory Factory
        {
            get { return toyFactory; }
            set { 
                toyFactory = value;
                DisplayNext();
                }
        }

        public Color BallColor { get; private set; }

        private void DisplayNext()
        {
            if (nexttoy != null) Controls.Remove(nexttoy);
            nexttoy=Factory.Createnew();
            nexttoy.Top = label1.Top + label1.Height + 20;
            nexttoy.Left = label1.Left;
            Controls.Add(nexttoy);
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            if (toys.Count == 0) return;
            Toy Lasttoy = toys[0];

            foreach (Toy item in toys)
            {
                item.MoveToy();
                if (item.Left > Lasttoy.Left) Lasttoy = item;
            }
            if(Lasttoy.Left>1000)
            {
                toys.Remove(Lasttoy);
                mainpanel.Controls.Remove(Lasttoy);
            }

        }

        private void Createtimer_Tick(object sender, EventArgs e)
        {
            Toy b = Factory.Createnew();
            toys.Add(b);
            b.Left = -b.Width;
            mainpanel.Controls.Add(b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory() { BallColor = btncolor.BackColor };
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;
            
        }
    }
}
