using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gradebook
{
    public class GetStatistics
    {
        public double Average
        {
            get{
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public double  Sum { get; set; }
        public int  Count { get; set; }

        public Char Letter { 
            get{

                switch(Average)
                {
                case var d when d >=90.0:
                    return 'A';
                case var d when d >=80.0:
                    return  'B';
                case var d when d >=70.0:
                    return  'C';
                case var d when d >=40.0 && d <= 69.9:
                    return  'D';
                default:
                    return  'F';
                }
            }
        }

        public void Add(double number){
            Sum += number;
            Count++;
            High = Math.Max(number, High);
            Low = Math.Min(number,Low);
        }
        public GetStatistics()
        {
            Count = 0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }

}