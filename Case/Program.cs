// case 8
/*

short D;
byte M;
Console.WriteLine("Kunni kiriting");
D=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Oyni kiriting");
M=Convert.ToByte(Console.ReadLine());
Console.WriteLine("---------------");
if (D == 1)
{
    M--;
    switch (M)
    {
        case 0: D = 31; break;
        case 1: D = 31; break;
        case 2: D = 28; break;
        case 3: D = 31; break;
        case 4: D = 30; break;
        case 5: D = 31; break;
        case 6: D = 30; break;
        case 7: D = 31; break;
        case 8: D = 31; break;
        case 9: D = 30; break;
        case 10: D = 31; break;
        case 11: D = 30; break;
    }
   
    switch (M)
    {
        case 1:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - yanvar"); ; break;
        case 2:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - mart"); break;
        case 4:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - aprel"); break;
        case 5:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - may"); break;
        case 6:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyun"); break;
        case 7:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyul"); break;
        case 8:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - avgust"); break;
        case 9:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - sentabr"); break;
        case 10:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - oktabr"); break;
        case 11:  Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - noyabr"); break;
        case 0: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - dekabr"); break;
        default: Console.WriteLine("Xato son kiritdingiz"); break;
    }
 
}
else
{
    D--;



    switch (M)
    {
        case 1: if (D > 1 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - yanvar"); ; break;
        case 2: if (D > 0 & D < 28) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - fevral"); break;
        case 3: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - mart"); break;
        case 4: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - aprel"); break;
        case 5: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - may"); break;
        case 6: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyun"); break;
        case 7: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyul"); break;
        case 8: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - avgust"); break;
        case 9: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - sentabr"); break;
        case 10: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - oktabr"); break;
        case 11: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - noyabr"); break;
        case 12: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - dekabr"); break;
        default: Console.WriteLine("Xato son kiritdingiz"); break;
    }
}
*/



// case 9

/*
short D;
byte M;
Console.WriteLine("Kunni kiriting");
D = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Oyni kiriting");
M = Convert.ToByte(Console.ReadLine());
Console.WriteLine("---------------");
if (D == 1)
{
    M--;
    switch (M)
    {
        case 0: D = 31; break;
        case 1: D = 31; break;
        case 2: D = 28; break;
        case 3: D = 31; break;
        case 4: D = 30; break;
        case 5: D = 31; break;
        case 6: D = 30; break;
        case 7: D = 31; break;
        case 8: D = 31; break;
        case 9: D = 30; break;
        case 10: D = 31; break;
        case 11: D = 30; break;
    }

    switch (M)
    {
        case 1: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - yanvar"); ; break;
        case 2: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - fevral"); ; break;
        case 3: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - mart"); break;
        case 4: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - aprel"); break;
        case 5: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - may"); break;
        case 6: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyun"); break;
        case 7: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyul"); break;
        case 8: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - avgust"); break;
        case 9: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - sentabr"); break;
        case 10: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - oktabr"); break;
        case 11: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - noyabr"); break;
        case 0: Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - dekabr"); break;
        default: Console.WriteLine("Xato son kiritdingiz"); break;
    }

}
else
{
    D--;



    switch (M)
    {
        case 1: if (D > 1 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - yanvar"); ; break;
        case 2: if (D > 0 & D < 28) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - fevral"); break;
        case 3: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - mart"); break;
        case 4: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - aprel"); break;
        case 5: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - may"); break;
        case 6: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyun"); break;
        case 7: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - iyul"); break;
        case 8: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - avgust"); break;
        case 9: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - sentabr"); break;
        case 10: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - oktabr"); break;
        case 11: if (D > 0 & D < 30) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - noyabr"); break;
        case 12: if (D > 0 & D < 31) Console.WriteLine("Kiritilgan kundan Bir kun oldingi kun " + D + " - dekabr"); break;
        default: Console.WriteLine("Xato son kiritdingiz"); break;
    }
}
*/

// case 9
/*
short D;
byte M;
Console.WriteLine("Kunni kiriting");
D = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Oyni kiriting");
M = Convert.ToByte(Console.ReadLine());
Console.WriteLine("---------------");

    switch (M)
    {
        case 1: if (D == 31 ){D = 1; M++;}else if(D>0 & D<31){D++;}break;
        case 2:if (D == 28){D = 1; M++;}else if(D>0 & D<28){D++;}break;
        case 3: if (D == 31){D = 1; M++;}else if(D>0 & D<31){D++;}break;
        case 4:if (D == 30){D = 1; M++;}else if(D>0 & D < 30){D++;}break;
        case 5: if (D == 31){D = 1; M++;}else if (D > 0 & D < 31){D++;}break;
        case 6:if (D == 30){D = 1; M++;}else if (D > 0 & D < 30){D++;}break;
        case 7: if (D == 31) { D = 1; M++; } else if (D > 0 & D < 31) { D++; }break;
        case 8:if (D == 31) { D = 1; M++; } else if (D > 0 & D < 31) { D++; }break;
        case 9: if (D == 30) { D = 1; M++; } else if (D > 0 & D < 30) { D++; } break;

        case 10: if (D == 31) { D = 1; M++; } else if (D > 0 & D < 31) { D++; } break;
        case 11: if (D == 30) { D = 1; M++; } else if (D > 0 & D < 30) { D++; } break;
        case 12: if (D == 31) { D = 1; M++; } else if (D > 0 & D < 31) { D++; } break;
        default:Console.WriteLine("Xato son kiritdingiz");break;
}

switch(M)
{
    case 1:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Yanvar");break;
    case 2:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Fevral");break;
    case 3:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Mart");break;
    case 4:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Aprel");break;
    case 5:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" May");break;
    case 6:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Iyun");break;
    case 7:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Iyul");break;
    case 8:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Avgust");break;
    case 9:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Sentabr");break;
    case 10:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Oktabr");break;
    case 11:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Noyabr");break;
    case 12:Console.WriteLine("Siz kiritgan kundan 1 kun keyingi kun "+ D+" Dekabr");break;
    default:Console.WriteLine("Xato kiritdingiz");break;
}

*/

//case 18

/*

int a, b, c;
Console.WriteLine("100 va 999 oraliqda son kiriting");
a=int.Parse(Console.ReadLine());

b = a % 10;
a = a / 10;
c = a % 10;
a = a / 10;
switch(a)
{
    case 1: Console.Write("Bir yuz");break;
    case 2: Console.Write("ikki yuz");break;
    case 3: Console.Write("Uch yuz");break;
    case 4: Console.Write("To'rt yuz");break;
    case 5: Console.Write("Besh yuz");break;
    case 6: Console.Write("Olti yuz");break;
    case 7: Console.Write("Yetti yuz");break;
    case 8: Console.Write("Sakkiz yuz");break;
    case 9: Console.Write("To'qqiz yuz");break;
    default: Console.WriteLine("");break;
}
switch(c)
{
    case 0:Console.Write("");break;
    case 1: Console.Write(" o'n"); break;
    case 2: Console.Write(" yigirma"); break;
    case 3: Console.Write(" o'ttiz"); break;
    case 4: Console.Write(" qirq"); break;
    case 5: Console.Write(" ellik"); break;
    case 6: Console.Write(" oltmish"); break;
    case 7: Console.Write(" yetmish"); break;
    case 8: Console.Write(" sakson"); break;
    case 9: Console.Write(" to'qson"); break;
    default: Console.WriteLine("Xato son kiritdingiz"); break;
}
switch (b)
{
    case 0:Console.Write("");break;
    case 1: Console.Write(" bir"); break;
    case 2: Console.Write(" ikki"); break;
    case 3: Console.Write(" Uch"); break;
    case 4: Console.Write(" to'rt"); break;
    case 5: Console.Write(" besh"); break;
    case 6: Console.Write(" olti"); break;
    case 7: Console.Write(" yetti"); break;
    case 8: Console.Write(" sakkiz"); break;
    case 9: Console.Write(" To'qqiz"); break;
    default: Console.WriteLine("Xato son kiritdingiz"); break;
}

*/

// case 19
/*
long a,k, b;
Console.WriteLine("Yilni kiriting");
a=long.Parse(Console.ReadLine());
if(a>0)
{
    k = a % 12;
    b = (a) % 60;
    if (b > 0 & b < 13) b = 0;
    else
    {
        if ( b < 25) b = 1;
        else
        {
            if (b < 37) b = 2;
            else
            {
                if (b < 49) b = 3;
                else b = 4;
            }
        }
    }
    switch (k)
    {
        case 3: Console.Write("yo'lbars "); break;
        case 4: Console.Write( "quyon "); break;
        case 5: Console.Write( "ajdar "); break;
        case 6: Console.Write( "ilon ") ; break;
        case 7: Console.Write( "ot ") ; break;
        case 8: Console.Write( "qo'y ") ; break;
        case 9: Console.Write("maymun  "); break;
        case 10: Console.Write( "tovuq "); break;
        case 11: Console.Write( "it "); break;
        case 0: Console.Write( "to'ng'iz "); break;
        case 1: Console.Write( "sichqon "); break;
        case 2: Console.Write( "sigir "); break;
        
    }
    switch (b)
    {
        case 0: Console.Write("yashil "); break;
        case 1: Console.Write("qizil "); break;
        case 2: Console.Write("sariq "); break;
        case 3: Console.Write("oq "); break;
        case 4: Console.Write("qora "); break;

    }   
}
*/

// case 20

short D, M;
Console.WriteLine("Kunni kiriting:");
D = short.Parse(Console.ReadLine());
Console.WriteLine("Oyni kiriting");
M = short.Parse(Console.ReadLine());

switch(M)
{
    case 1: if (D > 0 & D < 32) { if (D < 20) Console.WriteLine("Tog' echkisi"); else { Console.WriteLine("Qovg'a"); } }
        else  Console.WriteLine("Yanvar 31 kun") ; break;
    case 2:
        if (D > 0 & D < 30) { if (D < 19) Console.WriteLine("Qovg'a"); else { Console.WriteLine("Baliq"); } }
        else Console.WriteLine("Fevral 29 yoki 28 kun"); break;
    case 3:
        if (D > 0 & D < 32) { if (D < 21) Console.WriteLine("Baliq"); else { Console.WriteLine("Qo'y"); } }
        else Console.WriteLine("Mart 31 kun"); break;
    case 4:
        if (D > 0 & D < 31) { if (D < 20) Console.WriteLine("Qo'y"); else { Console.WriteLine("buzoq"); } }
        else Console.WriteLine("Aprel 30 kun"); break;
    case 5:
        if (D > 0 & D < 32) { if (D < 21) Console.WriteLine("buzoq"); else { Console.WriteLine("Egizaklar"); } }
        else Console.WriteLine("May 31 kun"); break;
    case 6:
        if (D > 0 & D < 31) { if (D < 22) Console.WriteLine("egizaklar"); else { Console.WriteLine("Qisqichbaqa"); } }
        else Console.WriteLine("Iyun 30 kun"); break;
    case 7:
        if (D > 0 & D < 32) { if (D < 23) Console.WriteLine("Qisqichbaqa"); else { Console.WriteLine("Arslon"); } }
        else Console.WriteLine("Iyul 31 kun"); break;
    case 8:
        if (D > 0 & D < 32) { if (D < 24) Console.WriteLine("Arslon"); else { Console.WriteLine("Parizod"); } }
        else Console.WriteLine("Avgust 31 kun"); break;
    case 9:
        if (D > 0 & D < 31) { if (D < 24) Console.WriteLine("Parizod"); else { Console.WriteLine("Chayon"); } }
        else Console.WriteLine("Sentabr 30 kun"); break;
    case 10:
        if (D > 0 & D < 32) { if (D < 24) Console.WriteLine("Chayon"); else { Console.WriteLine("O'qotar"); } }
        else Console.WriteLine("Oktabr 31 kun"); break;
    case 11:
        if (D > 0 & D < 31) { if (D < 24) Console.WriteLine("O'qotar"); else { Console.WriteLine("Tog' echkisi"); } }
        else Console.WriteLine("Noyabr 30 kun"); break;
    case 12:
        if (D > 0 & D < 32) { if (D < 24) Console.WriteLine("Tog' echkisi"); else { Console.WriteLine("Qovg'a"); } }
        else Console.WriteLine("Dekabr 31 kun"); break;
    default: Console.WriteLine("12 ta oy mavjud xolos");break;
}
