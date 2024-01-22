

// int n=Convert.ToInt32(Console.ReadLine());
int even=0,odd=0,zero=0,digits=0;
int mn=0,mx=0,sum=0; 
void EvenCount(int n)
{
    for(int i=n;i>0;i/=10)
    { 
        if((i%10)%2==0)
        {
            even++;
            if((i%10)==0)
            {
                even--;
            }
        }
    }
            Console.WriteLine($"Even : {even}"); 
}
EvenCount(12043);
void OddCount(int n)
{
    for(int i=n;i>0;i/=10)
    { 
        if((i%10)%2!=0)
        {
            odd++;
        }
    }
            Console.WriteLine($"Odd : {odd}"); 
}
OddCount(12043);
void ZeroCount(int n)
{
    for(int i=n;i>0;i/=10)
    { 
        if((i%10)==0)
        {
            zero++;
        }
    }
            Console.WriteLine($"Zeros : {zero}"); 
}
ZeroCount(12043);
void DigitCount(int n)
{
    for(int i=n;i>0;i/=10)
    { 
            digits++;
    }
            Console.WriteLine($"Digits : {digits}"); 
}
DigitCount(12043);
void MinDigit(int n)
{
    for(int i=n;i>0;i/=10)
    { 
        if((i%10)<0)
        {
            mn++;
        }
    }
            Console.WriteLine($"Min : {mn}"); 
}
MinDigit(12043);
void MaxDigit(int n)
{
    for(int i=n;i>0;i/=10)
    { 
        if((i%10)>0)
        {
            mx++;
        }
    }
            Console.WriteLine($"Max : {mx}"); 
}
MaxDigit(12043);
void SumDigit(int n)
{
    for(int i=n;i>0;i/=10)
    { 
            sum+=i%10;
    }
            Console.WriteLine($"Sum of Digits : {sum}"); 
}
SumDigit(12043);