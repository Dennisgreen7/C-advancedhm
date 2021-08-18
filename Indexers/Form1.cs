using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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

            try
            {
                if (February_[int.Parse(Indextxt.Text)] == 1000)
                {
                    MessageBox.Show("There is no such day in this mounth");
                    Indextxt.Text = "";
                    Temptxt.Text = "";
                }
                else
                {
                    Temptxt.Text = February_[int.Parse(Indextxt.Text)].ToString();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show("Eror,Wrirte a number not a string");
            }           
        }

        private void medida_Click(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(Indextxt.Text, out res))
            {
                try
                {
                    if (int.Parse(Indextxt.Text) < 1 || int.Parse(Indextxt.Text) > 28)
                    {
                        throw new DaysoutofrangeException("There is no such day in this mounth");
                    }
 
                    Temptxt.Text = Feb_[int.Parse(Indextxt.Text)].Temp_.ToString();
                    textdate.Text = Feb_[int.Parse(Indextxt.Text)].Date_.ToString("dd/MM/yyyy");
                    textcity.Text = Feb_[int.Parse(Indextxt.Text)].City_;
                }

                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                    Indextxt.Text = "";
                    Temptxt.Text = "";
                    textdate.Text = "";
                    textcity.Text = "";
                }
            }
            else
            {
                if (Feb_[Indextxt.Text] == 1000)
                {
                    MessageBox.Show("There is no such city");
                    Temptxt.Text = "";
                }
                else
                {
                    Temptxt.Text = Feb_[Indextxt.Text].ToString();
                }
                textdate.Text = "";
                textcity.Text = "";
            }


        }

        private void txtTry_Click(object sender, EventArgs e)
        {
            textBox1.Text = Feb_[textcity.Text, textdate.Text];
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

        private void Day_Click(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    internal class DaysoutofrangeException : Exception
    {
        public DaysoutofrangeException()
        {
        }

        public DaysoutofrangeException(string message) : base(message)
        {
        }

        public DaysoutofrangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DaysoutofrangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
