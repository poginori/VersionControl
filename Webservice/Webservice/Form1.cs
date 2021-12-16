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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using webservice.Entities;
using webservice.MNBServiceReference1;

namespace webservice
{
    public partial class Form1 : Form
    {
        BindingList<RateData> rates = new BindingList<RateData>();
        BindingList<String> currencies = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            cbvaluta.DataSource = currencies;
            GetCurrency();
            LoadCurrenciesXML(GetCurrency());
            Refreshdata();
        }

       

        private void LoadCurrenciesXML(string xmlstring)
        {
            currencies.Clear();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                string s = item.InnerText;
                currencies.Add(s);
            }
        }

        private string GetCurrency()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            GetCurrenciesRequestBody req = new GetCurrenciesRequestBody();
            var resp = mnbService.GetCurrencies(req);
            string result = resp.GetCurrenciesResult;
            File.WriteAllText("currency.xml",result);
            return resp.GetCurrenciesResult;
        }

        private void Refreshdata()
        {
            if (cbvaluta.SelectedItem == null) return;

            rates.Clear();
            LoadXml(getRates());
            dataGridView1.DataSource = rates;
            makeChart();
        }

        private void makeChart()
        {
            chartratedate.DataSource = rates;
            Series sorozatok = chartratedate.Series[0];
            sorozatok.ChartType = SeriesChartType.Line;
            sorozatok.XValueMember = "date";
            sorozatok.YValueMembers = "value";

            var jelmagyarazat = chartratedate.Legends[0];
            jelmagyarazat.Enabled = false;

            var diagramterulet = chartratedate.ChartAreas[0];
            diagramterulet.AxisY.IsStartedFromZero = false;
            diagramterulet.AxisY.MajorGrid.Enabled = false;
            diagramterulet.AxisX.MajorGrid.Enabled = false;

        }

        private void LoadXml(string xmlstring)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstring);
            foreach (XmlElement item in xml.DocumentElement)
            {
                RateData rd = new RateData();
                rd.Date = DateTime.Parse(item.GetAttribute("date"));
                var childElement = (XmlElement)item.ChildNodes[0];
                if (childElement != null) 
                { 
                rd.Currency = childElement.GetAttribute("curr");
                decimal unit = decimal.Parse(childElement.GetAttribute("unit"));
                rd.Value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rd.Value = rd.Value / unit;
                rates.Add(rd);
                }

            }
        }
      
        

        private string getRates()
        {
            
            var mnbservice = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody req = new GetExchangeRatesRequestBody();
            req.currencyNames = cbvaluta.SelectedItem.ToString();//"EUR";
            req.startDate = tolPicker.Value.ToString("");// "2020-01-01";
            req.endDate = igPicker.Value.ToString("");// "2020-06-30";
            var response = mnbservice.GetExchangeRates(req);
            return response.GetExchangeRatesResult;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paramchanged(object sender, EventArgs e)
        {
            Refreshdata();
        }
    }
}
