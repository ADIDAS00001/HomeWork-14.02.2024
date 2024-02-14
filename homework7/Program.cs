

int a=Convert.ToInt32(Console.ReadLine());
int[] A=new int[a];
for(int i=0;i<a;i++)
{
   A[i]=Convert.ToInt32(Console.ReadLine());
}
A.Reverse();
for(int i=1;i<a-1;i++)
{
   if(A[i]>0 && A[i+1]>0)
   {
      System.Console.WriteLine(A[i]+" "+A[i+1]);
      break;
   }
   else if(A[i]<0 && A[i+1]<0)
   {
        System.Console.WriteLine(A[i]+" "+A[i+1]);
        break;
   }
}
