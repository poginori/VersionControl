using Mikroszimulacio2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroszimulacio2
{
    public partial class Form1 : Form
    {
        List<Person> Population;
        List<BirthProbabilities> BirthProbabilities;
        List<DeathProbabilities> DeathProbabilities;
        List<int> ferfiak = new List<int>();
        List<int> nok = new List<int>();

        Random rng = new Random(1234);
        

        public Form1()
        {
            InitializeComponent();
           

           // Simulation();

        }

        private void Simulation(int zaroev,string fájlnév)
        {
            ferfiak.Clear();
            nok.Clear();
            richTextBox1.Clear();

            Population = GetPopulation(fájlnév);
            BirthProbabilities = GetBirthProbabilities(@"C:\teszt\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\teszt\halál.csv");
            //MessageBox.Show((DeathProbabilities.Count).ToString());

            for (int year = 2005; year <= zaroev; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SzimulaciosLepes(Population[i], year);
                }
                int ferfiakszama = (from x in Population where x.Gender == Gender.Male select x).Count();
                int nokszama = (from x in Population where x.Gender == Gender.Female select x).Count();

                ferfiak.Add(ferfiakszama);
                nok.Add(nokszama);

                Console.WriteLine(string.Format("Év: {0} Férfiak:{1} Nők:{2}", year, ferfiakszama, nokszama));
            }
            DisplayResults(zaroev);
        }
        void DisplayResults(int zaroev)
        {
            int counter = 0;
            for (int year = 2005; year <= zaroev; year++)
            {
                richTextBox1.Text += string.Format("Szimulációs év: {0} \n\tFérfiak:{1} \n\tNők:{2}\n\n",year,ferfiak[counter],nok[counter]);
                counter++;
            }
        }

        private void SzimulaciosLepes(Person person, int year)
        {
            if (!person.IsAlive) return;
            int kor = year - person.BirthYear;
            double halalvaloszinuseg = (from x in DeathProbabilities where x.Gender == person.Gender && x.Age == kor select x.P).FirstOrDefault();
            double veletlen = rng.NextDouble();
            if (veletlen <= halalvaloszinuseg)
                person.IsAlive = false;
            if(person.IsAlive && person.Gender==Gender.Female)
            {
                double szuletesvaloszinuseg = (from x in BirthProbabilities where x.Age == kor select x.P).FirstOrDefault();
           
            veletlen = rng.NextDouble();
            if (veletlen <= szuletesvaloszinuseg)
                { 
                Person baba = new Person();
                baba.BirthYear = year;
                baba.NrbOfChildren = 0;
                baba.Gender = (Gender)rng.Next(1,3);
                Population.Add(baba);
                }
            }
            
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> result = new List<Person>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    Person p = new Person();
                    p.BirthYear = int.Parse(items[0]);
                    p.Gender = (Gender)Enum.Parse(typeof(Gender), items[1]);
                    p.NrbOfChildren = int.Parse(items[2]);
                    result.Add(p);
                }

            return result;
          
        }
        public List<BirthProbabilities> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbabilities> result = new List<BirthProbabilities>();
            using (StreamReader sr = new StreamReader(csvpath,Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    BirthProbabilities bp = new BirthProbabilities();
                    bp.Age = int.Parse(items[0]);
                    bp.NrbOfChildren = int.Parse(items[1]);
                    bp.P = double.Parse(items[2]);
                    result.Add(bp);
                }
            }
            return result;

        }
        public List<DeathProbabilities> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbabilities> result = new List<DeathProbabilities>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] items = line.Split(';');
                    DeathProbabilities dp = new DeathProbabilities();
                    dp.Age = int.Parse(items[1]);
                    dp.Gender = (Gender)Enum.Parse(typeof (Gender),items[0]);
                    dp.P = double.Parse(items[2]);
                    result.Add(dp);

                }
            }
            return result;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Simulation((int)zaroevnum.Value,txtnepessegfajl.Text);
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) txtnepessegfajl.Text = ofd.FileName;
        }
    }
          
        
    
}
