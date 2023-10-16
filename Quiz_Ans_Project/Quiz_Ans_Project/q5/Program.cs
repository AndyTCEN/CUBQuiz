using System.Diagnostics;

for (int i = 0; i < 100; i++)
{
    Console.WriteLine("#{0}",i);
    DeferredExec();
}
Console.ReadLine();

static void DeferredExec()
{
    List<int> ints = new List<int>();
    Random rnd = new Random();
    for (int i = 0; i < 100000; i++)
    {
        ints.Add(rnd.Next(0, 20));
    }

    Stopwatch stopwatch = Stopwatch.StartNew();

    Console.WriteLine("延遲查詢計時開始");
    var resultint = ints.Where(n => n < 10);
    stopwatch.Stop();
    Console.WriteLine("延遲查詢計時結束，總耗時{0}毫秒", stopwatch.Elapsed.TotalMilliseconds);

     stopwatch = Stopwatch.StartNew();

    Console.WriteLine("立即查詢計時開始");
    var resullist = ints.Where(n => n < 10).ToList();
    stopwatch.Stop();
    Console.WriteLine("立即查詢計時結束，總耗時{0}毫秒", stopwatch.Elapsed.TotalMilliseconds);
}