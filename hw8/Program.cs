
System.Console.Write("The first number is: ");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("The operation is: ");
char z=Convert.ToChar(Console.ReadLine());
System.Console.Write("The first number is: ");
int y=Convert.ToInt32(Console.ReadLine());
if(z=='+')
{
System.Console.WriteLine($"{x} {z} {y} = {x+y}");
}
else if(z=='-')
{
System.Console.WriteLine($"{x} {z} {y} = {x-y}");
}
else if(z=='*')
{
System.Console.WriteLine($"{x} {z} {y} = {x*y}");
}
else if(z=='/')
{
System.Console.WriteLine($"{x} {z} {y} = {x/y}");
}