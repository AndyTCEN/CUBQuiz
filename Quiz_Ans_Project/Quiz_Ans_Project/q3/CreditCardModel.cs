using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    public class CreditCardModel
    {
        private string creditCardNum;
        public string  CreditCardNum { get=> creditCardNum; set=> creditCardNum = value.Trim(); }
        public string  HiddenCreditCardNum { get; set; }

    }
}
