

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
int mx=-9999999;
int mx1=0;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
    if(A[i]>mx)
    {
        mx=A[i];
        mx1=i;
    }
}
System.Console.WriteLine(mx1);
