
System.Console.Write("From = ");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("To = ");
int y=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("---------------------");
for(int i=1;i<=10;i++)
{
    System.Console.Write($"{x}*{i}= {x*i}");
    System.Console.WriteLine();
}
System.Console.WriteLine("---------------------");
for(int i=1;i<=10;i++)
{
    System.Console.Write($"{y}*{i}= {y*i}");
    System.Console.WriteLine();
}
System.Console.WriteLine("---------------------");
