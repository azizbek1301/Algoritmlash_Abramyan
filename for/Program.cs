// for - loop


/*
for (int i=1;i<100;i+=2)
{
    Console.WriteLine(i);
}
*/

// for 1

/*

double k, n;
Console.WriteLine( "k ni kiriting");
k = double.Parse(Console.ReadLine());

Console.WriteLine("n ni kiriting");
n = double.Parse(Console.ReadLine());

// k=5
// n=3
Console.WriteLine("----------");
if (n>0)
{
    for (double i = 0; i < n; i++)
    {
        Console.WriteLine(k);
    }

}
else
{
    Console.WriteLine("XATO");
}
*/

// for 2
/*
int a, b,n=0;
Console.WriteLine("a ni kiriting");
a = int.Parse(Console.ReadLine());

Console.WriteLine("b ni kiriting");
b = int.Parse(Console.ReadLine());

Console.WriteLine("----------");


for (double i = b; i >=a ; i--)
{
    Console.WriteLine(i);
    n++;    
}
Console.WriteLine("=-----");
Console.WriteLine(n+" ta butun son bor");

*/

//for 3
/*
int a, b, n = 0;
Console.WriteLine("a ni kiriting");
a = int.Parse(Console.ReadLine());

Console.WriteLine("b ni kiriting");
b = int.Parse(Console.ReadLine());

Console.WriteLine("----------");


for (double i = b-1; i > a; i--)
{
    Console.WriteLine(i);
    n++;
}
Console.WriteLine("=-----");
Console.WriteLine(n + " ta butun son bor");
*/


// for 4
/*
int x;
Console.WriteLine("Bir kilogram konfet narxini kiriting");
x = int.Parse(Console.ReadLine());


for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i +" kg konfet narxi "+ i*x);
}

*/

//for 5
/*
int x;
Console.WriteLine("Bir kilogram konfet narxini kiriting");
x = int.Parse(Console.ReadLine());


for (double i = 0.1; i < 1; i+=0.1)
{
    Console.WriteLine(i + " kg konfet narxi " + i * x);
}

*/


//for 7
// continue bitta sikl o'tkazish
// break sindirish






for (int i = 1; i <= 10; i++)
{
    Console.Write(2+"*"+i+"="+2*i +" \t");




}
Console.WriteLine("Salom");