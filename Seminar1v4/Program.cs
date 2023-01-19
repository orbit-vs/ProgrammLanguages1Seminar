
Console.Write("Введите целое число ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
for(int i = -N; i <= N; i++)
{
    System.Console.Write(i + ", ");
}

