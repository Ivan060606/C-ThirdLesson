Console.Write("Введите целое пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a/10000;
if (b>0 && a/100000<1)
    {
    int c = a%10000/1000;
    int d = a%100/10;
    int e = a%10;
    if (c==d && b==e) Console.WriteLine("Палиндром");
    else Console.WriteLine("Не палиндром");
    }
else Console.WriteLine("Введите корректное число.");