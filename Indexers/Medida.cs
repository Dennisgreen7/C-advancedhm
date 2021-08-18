using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Medida
    {
        public string City_ { get; set; }
        public DateTime Date_ { get; }
        public double Temp_ { get; set; }

         
        public Medida(string city_, double temp_,int d_a_y)
        {
            Date_ = DateTime.Parse("2021-08-"+d_a_y.ToString());
            City_ = city_;
            Temp_ = temp_;
        }
    }
}

