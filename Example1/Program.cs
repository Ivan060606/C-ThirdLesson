Console.Write("Введите целое пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a/10000;
if (b>0 && a/100000<1)
    {
    int c = a%10000/1000;
    int d = a%100/10;
    int e = a%10;
    if (c==d && b==e) Console.WriteLine("Палиндром");
    /*Console.WriteLine(" программистов"+b);
    Console.WriteLine(" программистов"+c);
    Console.WriteLine(" программистов"+d);
    Console.WriteLine(" программистов"+e);*/
    else Console.WriteLine("Не палиндром");
    }
else Console.WriteLine("Введите корректное число.");
/*int b = a;
Console.Write("В комнате "+b);
if (100<a) a=a%100;
if (4<a && a<21) Console.WriteLine(" программистов");
else
    {
    a=a%10;
    if (a==1) Console.WriteLine(" программист");
    else if (1<a && a<5) Console.WriteLine(" программистa");
    else Console.WriteLine(" программистов");
    }*/