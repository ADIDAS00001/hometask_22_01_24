

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
int n=0,p=0,z=0,e=0,o=0,mn=999999,mnn=0,mx=-999999,mxx=0,sum=0;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
     sum+=A[i];
   if(A[i]<=0)
   {
        n++;
   }

     if(A[i]>0)
     {
         p++;
     }
     if(A[i]==0)
     {
         z++;
     }
      if(A[i]%2==0)
    {
         e++;
    }
     if(A[i]%2!=0)
    {
         o++;
    }
      if(A[i]>mx)
    {
          mx=A[i];
          mxx=i;
    }
     if(A[i]<mn)
    {
          mn=A[i];
          mnn=i;
    }  
}

 System.Console.WriteLine($"Negative = {n}");
 System.Console.WriteLine($"Positive = {p}");
 System.Console.WriteLine($"Zeros = {z}");
 System.Console.WriteLine($"Even = {e}");
 System.Console.WriteLine($"Odd = {o}");
 System.Console.WriteLine($"Max = {mx}");
 System.Console.WriteLine($"Min = {mn}");
 System.Console.WriteLine($"Sum of Digits = {sum}");

