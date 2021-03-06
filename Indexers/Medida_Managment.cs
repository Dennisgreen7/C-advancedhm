using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Medida_Managment
    {
        private Medida[] Medidot_ = new Medida[28];
        private int Count_ = 0;
        public void Add_toArry(Medida m)
        {
            Medidot_[Count_++] = m;
        }
        //public double Get_Temp_By_Day(string day_)
        //{
        //    foreach (var Medida in Medidot_)
        //    {
        //        if (Medida.Date_.Day.ToString() == day_)
        //        {
        //            return Medida.Temp_;
        //        }
        //    }
        //    return 0;
        //}
        public Medida this[int day_]
        {
            get
            {
                foreach (var Medida in Medidot_)
                {
                    if (Medida.Date_.Day.ToString() == day_.ToString())
                    {
                        return Medida;
                    }
                }
                return null;
            }
        }
      
        //public double Get_Temp_By_City(string city_)
        //{
        //    Double temp_ = 0;
        //    for (int i = 0; i < Medidot_.Length; i++)
        //    {
        //        if (Medidot_[i].City_ == city_)
        //        {
        //            temp_ = Medidot_[i]. Temp_;
        //            i = Medidot_.Length;
        //        }
        //    }
        //    return temp_;
        //}
        public double this[string city_]
        {
            get
            {
                Double temp_ = 1000;// בגלל שהתוכנית לא קורסת בחרתי לתת לו ערך של 1000 בגלל שזה ערך שטמפ' בחיים לא תהיה וכך אוכל לתפוס את הטעות ולהודיע למשתמש 
                for (int i = 0; i < Medidot_.Length; i++)
                {
                    if (Medidot_[i].City_ == city_)
                    {
                        temp_ = Medidot_[i].Temp_;
                        i = Medidot_.Length;
                    }
                }
                return temp_;
            }
        }
        //public string True_or_False(string city_, string date_)
        //{
        //    string Bool_ = "False";
        //    for (int i = 0; i < Medidot_.Length; i++)
        //    {
        //        if (Medidot_[i] != null)
        //        {
        //            if (Medidot_[i].Date_.ToString("dd/MM/yyyy") == date_ && Medidot_[i].City_ == city_)
        //            {
        //                Bool_ = "True";
        //                i = Medidot_.Length;
        //            }

        //        }

        //    }
        //    return Bool_;
        //}
        public string this[string city_, string date_]
        {
            get
            {
                string Bool_ = "False";
                for (int i = 0; i < Medidot_.Length; i++)
                {
                    if (Medidot_[i] != null)
                    {
                        if (Medidot_[i].Date_.ToString("dd/MM/yyyy") == date_ && Medidot_[i].City_ == city_)
                        {
                            Bool_ = "True";
                            i = Medidot_.Length;
                        }

                    }

                }
                return Bool_;
            }
        }
    }
}
