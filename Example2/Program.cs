Console.Write("введите координаты х1 точки  А ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты у1 точки  А ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты z1 точки  А ");
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты х2 точки  Б ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты у2 точки  Б ");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("введите координаты z2 точки  Б ");
double z2=Convert.ToDouble(Console.ReadLine());

double result;

result=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine(result);