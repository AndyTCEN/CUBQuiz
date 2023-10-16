using q6;

RectangleBase rectangle = new RectangleBase(20, 6);
Console.WriteLine("Rectangle面積：{0}",rectangle.GetArea());

rectangle = new SquareModel(10);
Console.WriteLine("Square面積：{0}", rectangle.GetArea());
Console.ReadLine();