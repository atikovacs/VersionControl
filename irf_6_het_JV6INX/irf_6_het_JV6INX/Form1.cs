using irf_6_het_JV6INX.Entities;
using irf_6_het_JV6INX.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace irf_6_het_JV6INX
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates;
        public Form1()
        {
            InitializeComponent();
            GetExchangeRates();

            dataGridView1.DataSource = Rates;
        }

        private void GetExchangeRates() 
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody() {currencyNames= "EUR", startDate= "2020-01-01", endDate="2020-06-30" };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }
    }
}
