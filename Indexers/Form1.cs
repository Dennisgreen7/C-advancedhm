using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexers
{
    public partial class Form1 : Form
    {
        Mounth_Managment February_ = new Mounth_Managment();
        Medida_Managment Feb_ = new Medida_Managment();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 28; i++)
            {
                February_.Add_Mounth_Temp(new Mounth_(i + 1, rand.Next(24, 40) + rand.NextDouble()));
                Feb_.Add_toArry(new Medida("Tel-Aviv", rand.Next(24, 40) + rand.NextDouble(), i + 1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Daytxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Temptxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void Get__Click(object sender, EventArgs e)
        {
            var index_day = int.Parse(Daytxt.Text);
            var temp_ = February_.Get_Temp_By_Day(index_day);
            Temptxt.Text = temp_.ToString();
        }

        private void medida_Click(object sender, EventArgs e)
        {
            int res;
            var index_day = Daytxt.Text;
            if (int.TryParse(Daytxt.Text, out res))
            {
                var temp_ = Feb_.Get_Medida_By_Day(index_day).Temp_;
                var date_ = Feb_.Get_Medida_By_Day(index_day).Date_.ToString("dd/MM/yyyy");
                var city_ = Feb_.Get_Medida_By_Day(index_day).City_;
                Temptxt.Text = temp_.ToString();
                textdate.Text = date_;
                textcity.Text = city_;
            }
            else
            {
                var temp_ = Feb_.Get_Temp_By_City(index_day);
                Temptxt.Text = temp_.ToString();
                textdate.Text = "";
                textcity.Text = "";
            }


        }

        private void txtTry_Click(object sender, EventArgs e)
        {
            var date_ = textdate.Text;
            var city_ = textcity.Text;
            var torf=Feb_.True_or_False(city_, date_);
            textBox1.Text = torf;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
