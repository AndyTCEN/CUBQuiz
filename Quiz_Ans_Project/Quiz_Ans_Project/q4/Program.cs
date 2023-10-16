using q4;

IConvertHelper helper= new ConvertHelper();
int inputint = 888;
var result = helper.ConvertToString(inputint);
Console.WriteLine("Sample1：Input={0} Output={1}",inputint, result);

DateTime inputdatetime = DateTime.Now;
 result = helper.ConvertToString(inputdatetime);
Console.WriteLine("Sample2：Input={0} Output={1}", inputdatetime, result);

Console.ReadLine();