// 321 
// 213
// int 13
/*
int a,b,c;
a=int.Parse(Console.ReadLine());
b = a % 10;// b=1
a = a / 10;//a=32
c = a % 10;//c=2
a = a / 10;//a=3
Console.WriteLine(c*100+b*10+a);
*/

// int 14 

// 321
// 132


// int 15

// 321

// 231
/*
int a, b, c;
a = int.Parse(Console.ReadLine());
b = a % 10;// b=1
a = a / 10;//a=32
c = a % 10;//c=2
a = a / 10;//a=3
Console.WriteLine(c*100+a*10+b);
*/

//int 17

// 6465
/*
int a, b;
a=int.Parse(Console.ReadLine());
a = a / 100;// a=64
b = a % 10;
Console.WriteLine(b);
*/

// int 19
/*
int sekund, minut;
Console.WriteLine("Kun boshidan boshlab necha sekund o'tdi");
sekund = int.Parse(Console.ReadLine());
minut = sekund / 60;
Console.WriteLine(minut);
*/

//int 21
/*
int sekund, minut;
Console.WriteLine("Kun boshidan boshlab necha sekund o'tdi");
sekund = int.Parse(Console.ReadLine());
minut = sekund / 60;
Console.WriteLine(minut);
Console.WriteLine(sekund-minut*60);
*/

/*
//int 24
int kun, qoldiq;
kun=int.Parse(Console.ReadLine());
qoldiq = kun % 7;
switch(qoldiq)
{
    case 0:Console.WriteLine("Yakshanba");break;
    case 1:Console.WriteLine("Dushanba");break;
    case 2: Console.WriteLine("Seshanba"); break;
    case 3: Console.WriteLine("Chorshanba"); break;
    case 4: Console.WriteLine("Payshanba"); break;
    case 5: Console.WriteLine("Juma"); break;
    case 6: Console.WriteLine("Shanba"); break;
       
}

*/


// int 29
/*
int A, B, C, n,S;
Console.WriteLine("To'g'ri to'rtburchak bo'yini kiriting: ");
A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("To'g'ri to'rtburchak enini kiriting: ");
B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kvadratning tomonini kiriting: ");
C = Convert.ToInt32(Console.ReadLine());
n = (A / C) * (B / C);
S = A * B - n * C;
Console.WriteLine(n+" ta kvadrat joylashtirsa bo'ladi");
Console.WriteLine("Qoldiq yuza "+ S);

*/



// int 29
/*
int k, n;
Console.WriteLine("1-yanvar qaysi hafta kuniga to'g'ri keladi:");
Console.WriteLine("Yakshanba uchun 1 ni bosin");
Console.WriteLine("Dushanba uchun 2 ni bosin");
Console.WriteLine("Seshanba uchun 3 ni bosin");
Console.WriteLine("Chorshanba uchun 4 ni bosin");
Console.WriteLine("Payshanba uchun 5 ni bosin");
Console.WriteLine("Juma uchun 6 ni bosin");
Console.WriteLine("Shanba uchun 7 ni bosin");
n = int.Parse(Console.ReadLine());
Console.Write("Tanlagan kuningizni kiriting:");
k = int.Parse(Console.ReadLine());
k = k % 7; k = (k + n - 1); k = k % 7;
switch (k)
{
    case 1: Console.WriteLine("Bu kun yakshanba to'g'ri keladi"); break;
    case 2: Console.WriteLine("Bu kun dushanba to'g'ri keladi"); break;
    case 3: Console.WriteLine("Bu kun seshanba to'g'ri keladi"); break;
    case 4: Console.WriteLine("Bu kun chorshanba to'g'ri keladi"); break;
    case 5: Console.WriteLine("Bu kun payshanba to'g'ri keladi"); break;
    case 6: Console.WriteLine("Bu kun juma to'g'ri keladi"); break;
    case 0: Console.WriteLine("Bu kun shanba to'g'ri keladi:"); break;
}
*/
/*
int a, b, c, musbat, manfiy;
Console.WriteLine("Birinchi sonni kiriting");
a =int.Parse(Console.ReadLine());

Console.WriteLine("Ikkinchi sonni kiriting");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Uchinchi sonni kiriting");
c = int.Parse(Console.ReadLine());

musbat = 0;
manfiy = 0;

if (a > 0)
    musbat++;
else if(a<0)
    manfiy++;
if (b > 0)
    musbat++;
else if(b<0)
    manfiy++;
if (c > 0)
    musbat++;
else if (c < 0)
    manfiy++;
Console.WriteLine("----------------------");
Console.WriteLine(musbat + " ta musbat");
Console.WriteLine(manfiy + " ta manfiy");

*/