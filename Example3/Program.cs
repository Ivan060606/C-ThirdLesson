Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (index<N)
    {
    index=index+1;
    int sqr = index*index*index;
    Console.Write(" | "+sqr);
    }