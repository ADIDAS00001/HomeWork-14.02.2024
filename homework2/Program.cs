

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
int sum=1;
for(int i=0;i<a;i++)
{
    A[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a-1;i++)
{
    sum*=A[i];
    System.Console.Write(A[i]);
    System.Console.Write("*");
}
System.Console.Write(A[a-1]);
System.Console.Write("=");
sum*=A[a-1];
Console.WriteLine(sum);