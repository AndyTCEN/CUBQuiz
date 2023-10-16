using q7;
AsyncAwait sample=new AsyncAwait();
for (int i = 0; i < 15; i++)
{
    await Task.Delay(1000);
    await sample.Flow();
    Console.WriteLine("#{0}執行結果：{1}",i+1, sample.Result);
}

