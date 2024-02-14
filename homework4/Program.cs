

int a = Convert.ToInt32(Console.ReadLine());
int[] A = new int[a];
for (int i = 0; i < a; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (i != j && A[i] == A[j]) 
        {
            cnt++;
        }
    }
    if (cnt == 0)
    {
        System.Console.WriteLine(A[i] + " "); 
    }
    cnt = 0;
}