


int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int [a];
int cnt=0;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a-1;i++)
{
    if(A[i]<A[i+1])
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);