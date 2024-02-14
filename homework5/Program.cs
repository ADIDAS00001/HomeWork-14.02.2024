

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
int mn=9999999;
int mn1=0;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
    if(A[i]<mn)
    {
        mn=A[i];
        mn1=i;
    }
}
System.Console.WriteLine(mn1);
