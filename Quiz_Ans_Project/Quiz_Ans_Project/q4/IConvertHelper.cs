using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    public interface IConvertHelper
    {
        string ConvertToString<T>(T Input);
    }
}
