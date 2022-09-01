string b = "o";
int e = 0;
int a = 0;
int sum = 0;
int c = 0;
Console.WriteLine("Bведите числа ");
do
    {
    b = Convert.ToString(Console.ReadLine());
    if (b != "")
    {
    a = Convert.ToInt32(b);
    c = c + a;
    sum = sum + a*a;
    if (c == 0) e=sum;
    }
    }
while (b != "");
Console.WriteLine(" "+e);