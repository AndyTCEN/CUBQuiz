using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public  class NumCount: INumCount
    {
        public string[] NumSort(string[] amountList)
        {
            string[] result = new string[amountList.Length];
            if (amountList.Length <= 0)
                return result;
            double[] doubles = new double[amountList.Length];
            int count = 0;
            foreach (var item in amountList)
            {
                doubles[count] = CheckStringToDouble(item);
                count++;
            }
            result = doubles.Select(n => Multiply(n)).OrderByDescending(n => n).Select(n => n.ToString()).ToArray();
            return result;
        }

        private static double CheckStringToDouble(string stringDouble)
        {
            if (stringDouble == "-")
            {
                return 0;
            }
            else if (!double.TryParse(stringDouble, out double doublecheck))
            {
                throw new AggregateException("輸入格式錯誤");
            }
            else
            {
                return doublecheck;
            }
        }
        private static double Multiply(double inputDouble)
        {
            const double multiplier = 0.33;
            return inputDouble * multiplier;
        }
    }
}
