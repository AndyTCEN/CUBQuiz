using q1;

string[] amountList = { "1.2", "1.4","0.2", "-", "-0.005" };
INumCount numCount=new NumCount();
var ans = numCount.NumSort(amountList);
foreach (var item in ans)
{
    Console.WriteLine(item);
}
Console.ReadLine();

