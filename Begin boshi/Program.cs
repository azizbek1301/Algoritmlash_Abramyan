// \n,\t

/*
Console.WriteLine("Salom ");
Console.Write("Qande \n");
*/
/*
Console.WriteLine("Qande \nyaxshiman");
*/



// Begin 1
/*
int a, P;
a=Convert.ToInt32(Console.ReadLine());
P = 4 * a;
Console.WriteLine(P);
*/

//  Bir qatorli komment 


// Begin 2

/*
int a, S;
Console.WriteLine("Kvadratning tomonini kiriting");
a=Convert.ToInt32(Console.ReadLine());
S = a * a;
Console.WriteLine(S);

*/


// bool tip    True  , False

// Boolean 1
/*
int A;
bool tekshir;
Console.WriteLine("Ixtiyoriy butun son kiriting");
A=Convert.ToInt32(Console.ReadLine());
tekshir = A > 0;
Console.WriteLine(tekshir);

*/

// Boolean 2
/*
int A;
bool tekshir;
Console.WriteLine("Ixtiyoriy son kiriting");
A=Convert.ToInt32(Console.ReadLine());
tekshir = A % 2 == 1;
Console.WriteLine(tekshir);

*/
// Bool 3
/*
int A;
bool tekshir;
Console.WriteLine("Ixtiyoriy son kiriting");
A = Convert.ToInt32(Console.ReadLine());
tekshir = A % 2 == 0;
Console.WriteLine(tekshir);
*/

// Bool 9
/*
int A, B;
bool Tekshir;
Console.WriteLine("Ixtiyoriy son kiriting");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ixtiyoriy son kiriting");
B = Convert.ToInt32(Console.ReadLine());
Tekshir = A % 2 == 1 | B % 2 == 1;
Console.WriteLine(Tekshir);
*/

//Boolean 36
/*
int x1, y1, x2, y2;
bool tekshir;
Console.WriteLine("x1");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2");
y2 = Convert.ToInt32(Console.ReadLine());
tekshir = x1 == x2 | y1 == y2;
Console.WriteLine(tekshir);
*/

int x1, y1, x2, y2;
bool t;
Console.WriteLine("x1");
x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1");
y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2");
x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2");
y2 = Convert.ToInt32(Console.ReadLine());
t=Math.Abs(x1-x2)==1 & Math.Abs(y1-y2)==2 
    | Math.Abs(x1 - x2) == 2 & Math.Abs(y1 - y2) == 1;
Console.WriteLine(t);





