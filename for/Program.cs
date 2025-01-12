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



// for 10
/*
int n;
double S = 0;
Console.WriteLine("n ni kiriting");
n=Convert.ToInt32(Console.ReadLine());
for(double i=1; i<=n; i++)
{
    S += 1 / i;
}
Console.WriteLine(S);
*/

//for 11
/*
int n;
double S = 0;
Console.WriteLine("n ni kiriting");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    S += Math.Pow(n+i,2);
}
Console.WriteLine(S);
*/

// for 12
/*
int n;
double S = 1,a=1.1;
Console.WriteLine("n ni kiriting");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    S *=  a;
    a += 0.1;
}
Console.WriteLine(S);
*/

// for 13
/*
int n;
double S = 0, a = 1.1;
Console.WriteLine("n ni kiriting");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    S += Math.Pow(-1,i)*a;
    a += 0.1;
}
Console.WriteLine(S);
*/

// for 14

/*

int n,S=0,a=1;
Console.Write("n ni kiriting: n= ");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    S += a;
    a += 2;
    
}
Console.WriteLine(n+" ning kvadrati "+S);
*/

//for 15
/*
int n;
double a,s=1;
Console.Write("n ni kiriting: n= ");
n=int.Parse(Console.ReadLine());
Console.Write("a ni kiriting: a= ");
a = double.Parse(Console.ReadLine());

for (int i=0;i<n;i++)
{
    s *= a;
}
Console.WriteLine(a+" ning "+n+" darajasi "+s);
*/

// for 16


/*
int n;
double a, s = 1;
Console.Write("n ni kiriting: n= ");
n = int.Parse(Console.ReadLine());
Console.Write("a ni kiriting: a= ");
a = double.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    s *= a;
    Console.WriteLine(a + " ning " + i + " darajasi " + s);
}

*/

// for 17
/*
int n;
double a, s = 0;
Console.Write("n ni kiriting: n= ");
n = int.Parse(Console.ReadLine());
Console.Write("a ni kiriting: a= ");
a = double.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    s += Math.Pow(a,i);   

}
Console.WriteLine(s);
*/

// for 18
/*
int n;
double a, s = 0;
Console.Write("n ni kiriting: n= ");
n = int.Parse(Console.ReadLine());
Console.Write("a ni kiriting: a= ");
a = double.Parse(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    s += Math.Pow(-1, i)*Math.Pow(a,i);

}
Console.WriteLine(s);
*/


// for 19
/*
int n, s = 1;
Console.Write("n ni kiriting: n= ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    s *=i;

}
Console.WriteLine(s);
*/

// for 20
/*
int n, S = 0,s=1;
Console.WriteLine("n ni kiriting");
n=int.Parse(Console.ReadLine());
for(int i=1;i<=n;i++)
{
    s *= i;
    S+= s;
    
}
Console.WriteLine(S);
*/

// for 21
/*
int n; double S = 1, s = 1;
Console.WriteLine("n ni kiriting");
n = int.Parse(Console.ReadLine());
for (double i = 1; i <= n; i++)
{
    s *= (1/i);
    S += s;

}
Console.WriteLine(S);
*/

// for 22
/*
int n; double S = 1, s = 1,x;
Console.WriteLine("n ni kiriting");
n = int.Parse(Console.ReadLine());
Console.WriteLine("x ni kiriting");
x = int.Parse(Console.ReadLine());

for (double i = 1; i <= n; i++)
{
    s *= (Math.Pow(x,2) / i);
    S += s;

}
Console.WriteLine(S);
*/

// for 23
/*
int n; double S = 0, a = 1,m, x;
Console.WriteLine("n ni kiriting");
n = int.Parse(Console.ReadLine());
Console.WriteLine("x ni kiriting");
x = int.Parse(Console.ReadLine());
m = x;
for (double i = 0; i <= n; i++)
{
    
        a *= (2*i+1);
        S += m/a;
    m = -x * x;
    a = (2 * i + 1);

}
Console.WriteLine(S);
*/

//for 24
/*
int n, k; double a = 1, s = 1, x, m = 1;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());
Console.Write("x ni kiriting: x=");
x = double.Parse(Console.ReadLine());
for (k = 1; k <= n; k++)
{
    a *= 2 * k;
    m *= -x * x;
    s += m / a;
    a *= (2 * k + 1);
}
Console.Write("Natija: " + s);

*/
// for 25
/*
int n; double s = 0 ,x;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());
Console.Write("x ni kiriting: x=");
x = double.Parse(Console.ReadLine());
for (int k = 1; k <= n; k++)
{
    s += Math.Pow(-1, k - 1) * (Math.Pow(x, k) / k);
}
Console.Write("Natija: " + s);
*/

//for 26
/*
int n; double s = 0, x;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());
Console.Write("x ni kiriting: x=");
x = double.Parse(Console.ReadLine());
for (int k = 0; k <= n; k++)
{
    s += Math.Pow(-1, k ) * (Math.Pow(x, 2*k+1) / (2*k+1));
}
Console.Write("Natija: " + s);
*/

// for 33
/*
int n, i, F = 1, A = 1, B = 0;
Console.WriteLine("N ni kiriting");
n=int.Parse(Console.ReadLine());    
for(i=1; i<=n; i++)
{
    Console.Write("F["+i+"]="+F+" ");
    F = A + B;
    B = A;
    A = F;
}
*/

// for 34
/*
int n, i, A1 = 1,A2 =2, B ;
Console.WriteLine("N ni kiriting");
n = int.Parse(Console.ReadLine());
Console.Write("A1[1]="+A1+" A[2]="+A2+" ");
for (i = 3; i <= n; i++)
{
    B = A1 +2*A2;
    Console.Write("F[" + i + "]=" + B + " ");
    A1 = A2;
    A2 = B;
}
*/

//for 35
/*
int n, i, A1 = 1, A2 = 2, A3=1,B;
Console.WriteLine("N ni kiriting");
n = int.Parse(Console.ReadLine());
Console.Write("A1[1]=" + A1 + " A[2]=" + A2 + " A[3]="+A3+" ");
for (i = 4; i <= n; i++)
{
    B = A3 + A2-2*A1;
    Console.Write("F[" + i + "]=" + B + " ");
    A1 = A2;
    A2 = A3;
    A3= B;
}
*/

// for 36
/*
int n; double s = 0, k;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());
Console.Write("x ni kiriting: x=");
k = double.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    s += Math.Pow(i, k);
}
Console.Write("Natija: " + s);
*/

// for 37
/*
int n; double s = 0;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    s += Math.Pow(i, i);
}
Console.Write("Natija: " + s);
*/

//for 38
/*
int n,x; double s = 0;
Console.Write("Natural son kiriting: n=");
n = int.Parse(Console.ReadLine());
x = n;
for (int i = 1; i <= n; i++)
{
    s += Math.Pow(i, x);
    x--;
}
Console.Write("Natija: " + s);
*/

// for 39
/*
int a, b;
Console.WriteLine("A sonini kiriting:");
a=int.Parse(Console.ReadLine());
Console.WriteLine("B sonini kiriting");
b=int.Parse(Console.ReadLine());
Console.WriteLine("-----------------");
for (int i=a; i<=b; i++)
{
    for(int j=1; j<=i; j++)
    {
        Console.Write(i+" ");
    }
    Console.WriteLine();
}
*/

// for 40

/*
int a, b,k=1;
Console.WriteLine("A sonini kiriting:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("B sonini kiriting");
b = int.Parse(Console.ReadLine());
Console.WriteLine("-----------------");
for (int i = a; i <= b; i++)
{
    for (int j = 1; j <= k; j++)
    {
        Console.Write(i + " ");
    }
    k++;
    Console.WriteLine();
}
*/
































