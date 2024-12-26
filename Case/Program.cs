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