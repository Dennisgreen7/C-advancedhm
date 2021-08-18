using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Mounth_
    {
        public int Day_ { get; set; }
        public double Temp_ { get; set; }

        public Mounth_(int day_, double temp_)
        {
            Day_ = day_;
            Temp_ = temp_;
        }
    }
}
