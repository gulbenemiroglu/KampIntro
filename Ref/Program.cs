using System;

class Program
{

    static void Main()
    {

        int sayimiz = 3;

        Console.WriteLine("Başlangıç değeri: " + sayimiz);

        Kare(sayimiz);
        Console.WriteLine("Kare() sonrası: " + sayimiz);

        Kare2(ref sayimiz);
        Console.WriteLine("Kare2() sonrası: " + sayimiz);
    }

    static int Kare(int sayi)
    {
        return (sayi * sayi);
    }

    static int Kare2(ref int sayi)
    {
        return (sayi * sayi);
    }
}