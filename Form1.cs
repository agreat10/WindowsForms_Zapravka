using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms1806
{
    public partial class Form1 : Form
    {
        private double price = 0;//Сумма
        private double sale = 0.05;//Скидка
        private double total = 0;//Стоимость
        private double value = 0.0;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            price += 0;//string result = number.ToString("F2");
            total = price-price*sale;
            lblPay1.Text = price.ToString("0.00");
            lblPay2.Text = (price*sale).ToString("0.00");
            lblPay3.Text = total.ToString("0.00");
        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                tbxCena.Enabled = false;
                tbxLiter.Enabled = true;
        }

        private void rbtnCena_CheckedChanged(object sender, EventArgs e)
        {            
                tbxCena.Enabled = true;
                tbxLiter.Enabled = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, double> comboSource = new Dictionary<string, double>();
            comboSource.Add("АИ-76", 45.20);
            comboSource.Add("АИ-92", 47.70);
            comboSource.Add("АИ-95", 50.40);
            comboSource.Add("АИ-100", 55.80);
            cbxMarka.DataSource = new BindingSource(comboSource, null);
            cbxMarka.DisplayMember = "Key";
            cbxMarka.ValueMember = "Value";
        }

        private void cbxMarka_TextChanged(object sender, EventArgs e)
        {
            //string key = ((KeyValuePair<string, double>)cbxMarka.SelectedItem).Key;
            value = ((KeyValuePair<string, double>)cbxMarka.SelectedItem).Value;
            lblZaprCena.Text = value.ToString("0.00"); //выводим должность в поле
            price = value;
            Jobs();
        }
        private void Jobs()
        {
            double tempPrice = value;
            if (tbxLiter.Text == "")
            { 
                tbxCena.Text = "0.00";
                tempPrice = 0;
            }
                       
            else if (rbtnLiter.Enabled)
            { 
                double Liter = Convert.ToDouble(tbxLiter.Text);
                tempPrice *=  Liter;
                tbxCena.Text = tempPrice.ToString("0.00");
            }
            else
            {
                double Cena = Convert.ToDouble(tbxCena.Text);
                tempPrice = Cena;
                tbxLiter.Text = (Cena/value).ToString("0.00");
            }

            price = tempPrice;
            total = price - price * sale;
            lblPay1.Text = price.ToString("0.00");
            lblPay2.Text = (price * sale).ToString("0.00");
            lblPay3.Text = total.ToString("0.00");
        }

        private void tbxLiter_TextChanged(object sender, EventArgs e)
        {
            Jobs();
        }
    }
}
