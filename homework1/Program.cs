

int a=Convert.ToInt32(Console.ReadLine());
if(a<100)
{
    System.Console.WriteLine(a+a*0.05);
}
else if(a>=100 && a<=200)
{
    System.Console.WriteLine(a+a*0.07);
}
else 
{
    System.Console.WriteLine(a+a*0.1);
}
