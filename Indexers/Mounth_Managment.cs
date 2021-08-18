using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Mounth_Managment
    {
        private Mounth_[] Mounth_Temp = new Mounth_[28];
        private int Count_ = 0;
        public void Add_Mounth_Temp(Mounth_ m)
        {
            Mounth_Temp[Count_++] = m;
        }
        //public double Get_Temp_By_Day(int day_)
        //{
        //    foreach (var Mounth_ in Mounth_Temp)
        //    {
        //        if (Mounth_.Day_ == day_)
        //        {
        //            return Mounth_.Temp_;
        //        }
        //    }
        //    return 0;
        //}
        public double this[int day_]
        {
            get
            {
                foreach (var Mounth_ in Mounth_Temp)
                {
                    if (Mounth_.Day_ == day_)
                    {
                        return Mounth_.Temp_;
                    }
                }
                return 1000;//נתתי ערך של 1000 כי זו טמפ' לא היגיונית וכך אדע שקיבלתי ערך שגוי ואוכל להודיע למשתמש שהוא הקליד לא נכון
            }
        }
    }
}
