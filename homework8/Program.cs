

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++)
{
    if(A[i]%2!=0)
    {
        System.Console.Write(i+" ");
    }
}
