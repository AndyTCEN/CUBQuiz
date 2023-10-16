// See https://aka.ms/new-console-template for more information
using q3;

string credit16 = "5104315119201362";
string credit12 = "012345678901";
string creditError = "123";

CreditCardModel model = new CreditCardModel()
{
    CreditCardNum = credit16
};

ICreditCardTool tool = new CreditCardTool(model);
var result = tool.HiddenCreditNum();
Console.WriteLine(result.HiddenCreditCardNum);

 model = new CreditCardModel()
{
    CreditCardNum = credit12
 };
 tool = new CreditCardTool(model);
 result = tool.HiddenCreditNum();
Console.WriteLine(result.HiddenCreditCardNum);

model = new CreditCardModel()
{
    CreditCardNum = creditError
};
tool = new CreditCardTool(model);
result = tool.HiddenCreditNum();
Console.WriteLine(result.HiddenCreditCardNum);
Console.ReadLine();
