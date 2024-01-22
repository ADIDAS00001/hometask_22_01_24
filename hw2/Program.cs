

void CheckGrade(int grade)
{
    if(grade>=90 || grade==100)
    {
        System.Console.WriteLine("A");
    }
    else if(grade>=80 || grade==89)
    {
        System.Console.WriteLine("B");
    }
    else if(grade>=70 || grade==79)
    {
        System.Console.WriteLine("C");
    }
    else if(grade>=60 || grade==69)
    {
        System.Console.WriteLine("D");
    }
    else if(grade>=0 || grade==59)
    {
        System.Console.WriteLine("F");
    }
}
CheckGrade(80);