using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    public class CreditCardTool : ICreditCardTool
    {
        private CreditCardModel CreditCardModel { get; set; }

        public CreditCardTool(CreditCardModel creditCardModel)
        {
            this.CreditCardModel = creditCardModel;
        }

        public CreditCardModel HiddenCreditNum()
        {
            string hiddenNum = string.Empty;
            if(!CheckCreditCardNum())
            {
                throw new Exception("信用卡格式輸入異常");
            }
            switch (CreditCardModel.CreditCardNum.Length)
            {
                case 16:
                    hiddenNum = CreditNum16();
                    break;
                case 12:
                    hiddenNum = CreditNum12();
                    break;
                default:
                    throw new Exception("信用卡其他異常");
            }
            CreditCardModel.HiddenCreditCardNum = hiddenNum;
            return CreditCardModel;

        }

        private string CreditNum16()
        {
            string[] creditNums = {
            CreditCardModel.CreditCardNum.Substring(0,4),
            CreditCardModel.CreditCardNum.Substring(4,4),
            CreditCardModel.CreditCardNum.Substring(8,4),
            CreditCardModel.CreditCardNum.Substring(12,4)
            };
            return ConvertCreditNumToStar(creditNums);
        }

        private string CreditNum12()
        {
            string[] creditNums = {
            CreditCardModel.CreditCardNum.Substring(0,4),
            CreditCardModel.CreditCardNum.Substring(4,4),
            CreditCardModel.CreditCardNum.Substring(8,4),
            };
            return ConvertCreditNumToStar(creditNums);
        }

        private string ConvertCreditNumToStar(string[] creditNums)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < creditNums.Length; i++)
            {
                if (i != creditNums.Length - 1)
                    sb.Append("****").Append('-');
                else
                    sb.Append(creditNums[i]);
            }
            return sb.ToString();
        }

        private bool CheckCreditCardNum()
        {
            //找不到12碼驗證規則
            if(CreditCardModel.CreditCardNum.Length == 12)
                return true;
            if (CreditCardModel.CreditCardNum.Length != 16)
                return false;
            int sum = 0;
            bool doubleDigit = false;
            for (int i = CreditCardModel.CreditCardNum.Length - 1; i >= 0; i--)
            {
                int digit = CreditCardModel.CreditCardNum[i] - '0';
                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }
                sum += digit;
                doubleDigit = !doubleDigit;
            }
            return (sum % 10) == 0;
        }
    }
}
