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

double x, y;

Console.WriteLine("X ning qiymatini kiriting: ");
x=Convert.ToDouble(Console.ReadLine());

y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;

Console.WriteLine("y ning qiymati: " + y);