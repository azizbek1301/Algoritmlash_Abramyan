/*
int son = 23;

Console.WriteLine(son);
*/

/*
int a, b, c;
a = b = c = 34;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
*/

/*
int a, b, c;
a = b = c = 34 * 2 / 4;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
*/


/*
int a = 10;
  a=a+10;  
Console.WriteLine(a);// a=20

 a=a-4;
Console.WriteLine(a);//a=16

a = a * 2;
Console.WriteLine(a);   // 32


a = a / 8;
Console.WriteLine(a);       //a=4         
*/



/*
int a = 8;
int b = 6;
int c = a += b -= 5;


// b=1
// a=9
// c=9

Console.WriteLine(c);
*/


//Begin 11
/*
int son1, son2;

Console.WriteLine("Birinchi sonni kiriting ");
son1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ikkinchi sonni kiriting ");
son2 = Convert.ToInt32(Console.ReadLine());

// Math.Abs - sonning modulini topish

Console.WriteLine(Math.Abs(son1+son2));
Console.WriteLine(Math.Abs(son1-son2));
Console.WriteLine(Math.Abs(son1*son2));

*/


// Begin 14
/*
double L,R,S; // 2*pi*R
Console.WriteLine("Aylana usuznligini kiriting");
L=Convert.ToDouble(Console.ReadLine()); 

// L=2*pi*R
R=L/(2*Math.PI);

// S=pi*R*R


// Math.Pow() - sonni darajaga ko'tarib beruvchi funksiya
S = Math.PI * Math.Pow(R,2);

Console.WriteLine("Aylana Radiusi: " + R);
Console.WriteLine("Doira yuzasi " + S);
*/


//Begin19
/*
double x1, x2, y1, y2,boyi,eni, P, S;

Console.WriteLine("Birinchi nuqta absissani kiriting");
x1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Birinchi nuqta ordinata kiriting");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ikkinchi nuqta absissani kiriting");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ikkinchi nuqta ordinatasini kiriting");
y2 = Convert.ToDouble(Console.ReadLine());

boyi=Math.Abs(y2 - y1);
eni= Math.Abs(x2 - x1);

P=2*(boyi+eni);
S = boyi * eni;

Console.WriteLine("To'g'ri to'rtburchak perimetri: " + P);
Console.WriteLine("To'g'ri to'rtburchak yuzi: " + S);
*/


//Begin 22


/*
 
A=35
B=46

A=46
B=35

 */

/*

double son1, son2, katak;
Console.WriteLine("Birinchi sonni kiriting ");
son1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ikkinchi sonni kiriting ");
son2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("______________________________________________");

katak = son1;
son1= son2;
son2=katak;

Console.WriteLine("Son1: "+son1);
Console.WriteLine("Son2: "+son2);

*/


// Begin 25;

/*
double x, y;

Console.WriteLine("X ning qiymatini kiriting: ");
x=Convert.ToDouble(Console.ReadLine());

y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;

Console.WriteLine("y ning qiymati: " + y);

*/

// Begin 21
/*
double x1, x2, x3, y1, y2, y3,a,b,c,p, P, S;

Console.WriteLine("Birinchi nuqta absissasini kiriting: ");
x1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Birinchi nuqta ordinatasini kiriting: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ikkinchi nuqta absissasini kiriting: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ikkinchi nuqta ordinatasi kiriting: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Uchinchi nuqta absissasini kiriting: ");
x3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Uchinchi nuqta ordinatasini kiriting: ");
y3 = Convert.ToDouble(Console.ReadLine());

a=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
b=Math.Sqrt(Math.Pow(x3-x1,2)+Math.Pow(y3-y1,2));
c=Math.Sqrt(Math.Pow(x3-x2,2)+Math.Pow(y3-y2,2));

P=a+b+c;
p = P / 2;
S=Math.Sqrt(p*(p-a)*(p-b)*(p-c));

Console.WriteLine("Uchburchak perimetri: " + P);
Console.WriteLine("Uchburchak yuzasi: "+S);

*/


// Begin 24
/*
int A, B, C, K,L;

Console.WriteLine("A ning qiymatini kiriting: ");
A=int.Parse(Console.ReadLine());

Console.WriteLine("B ning qiymatini kiriting: ");
B = int.Parse(Console.ReadLine());

Console.WriteLine("C ning qiymatini kiriting: ");
C = int.Parse(Console.ReadLine());

Console.WriteLine("-------------------------");
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);

K = C;
L = B;
C = A;
B = K;
A = L;
Console.WriteLine("---------------------------");
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
*/

//Begin 25
/*
double x, y;
Console.Write("x o'zgaruvchini kiriting => ");
x=Convert.ToInt32(Console.ReadLine());  
y=3*Math.Pow(x,6)-6*Math.Pow(x,2)-7;
Console.WriteLine(y);
*/

// Begin 27
/*
int A;
double B;
Console.WriteLine("A sonini kiriting");
A = Convert.ToInt32(Console.ReadLine());
//B = Math.Pow(A, 8);
A = A * A;
Console.WriteLine(A);
B = A * A;
Console.WriteLine(B);
Console.WriteLine(B*B);
*/

// Begin 29
/*
double a, b;
a=Convert.ToDouble(Console.ReadLine());
b = a * Math.PI / 180;
Console.WriteLine(b);

*/

//Begin 33

// x kg konfet A so'm turadi.
// 1 kg va Y kg konfet qancha turishini
// hisoblash dasturini tuzinh
// 

/*
double A, x, b, Y;
Console.WriteLine("umumiy narxni kiriting: ");
A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Umumiy massani kiriting ( kg larda )");
x=Convert.ToDouble (Console.ReadLine());
b = A / x;
Console.WriteLine("1 kg konfet narxi : "+b);
Console.WriteLine("Qancha konfet olasiz yana ( kg larda )");
Y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Y+" kg si narxi: "+Y*b);

*/

// Begin 35

/*
double V, U, t1, t2, S1, S2, S;
Console.WriteLine("Qayiqning tezligini kiriting: ");
V=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Oqimning tezligini kiriting: ");
U = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ko'lda qancha vaqt harakatlangan: ");
t1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("oqimga qarshi qancha vaqt harakatlangan : ");
t2 = Convert.ToDouble(Console.ReadLine());

S1 = t1 * V;
S2=(V-U)*t2;
S = S1 + S2;
Console.WriteLine("umumiy masofa "+S);

*/







