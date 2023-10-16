using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    public class ConvertHelper: IConvertHelper
    {
        public string ConvertToString<T>(T Input)
        {
            string result=string.Empty;
            if(typeof(T) ==typeof(string)||typeof(T)==typeof(int))
            {
                result = Input.ToString();
            }
            if (typeof(T) == typeof(DateTime))
            {
                result = Convert.ToDateTime(Input.ToString()).ToString("yyyy/MM/dd");
            }
            return result;
        }
    }
}
