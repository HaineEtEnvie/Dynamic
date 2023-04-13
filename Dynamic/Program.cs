// Net 6.0
using Dynamic;
using System.Dynamic;
class Program
{
    internal static void Main()
    {
        
        // вид занятия
        static void Print(dynamic vidZanyatiya)
        {
            Console.Write("Название вида занятия: ");
            Console.WriteLine(vidZanyatiya.Name);
        }
        var vidzanyatia = CreateVidZanyatiya();
        Print(vidzanyatia);

        // оборудование
        static void Print1(dynamic oborudovanie)
        {
            Console.WriteLine("\nДанные оборудования: ");
            Console.WriteLine($"Название:{oborudovanie.Nazvanie} \nЦена:{oborudovanie.Stoimost} \nДата постановки:{oborudovanie.Postanovka}");

        }
        var oborudovanie = CreateOborudovanie();
        Print1(oborudovanie);

        // korpus
        static void Print2(dynamic korpus)
        {
            Console.WriteLine("\nДанные корпуса: ");
            Console.WriteLine($"{korpus.Name} {korpus.Adress}");
            Console.WriteLine(korpus.Sotrydnik);
            Console.WriteLine(korpus.Organizacia);
        }
        var korpus = CreateKorpus();
        Print2(korpus);

        // KTP
        static void Print3(dynamic ktp)
        {
            Console.WriteLine("\nДанные КТP: ");
            Console.WriteLine(ktp.Paragraf);
            Console.WriteLine(ktp.VidZanyatiya);
            Console.WriteLine(ktp.Materiali);
            Console.WriteLine(ktp.Nomer);
            Console.WriteLine(ktp.Chasi);
        }
        var ktp = CreateKtp();
        Print3(ktp);
    }


    static ExpandoObject CreateVidZanyatiya()
    {
        dynamic vidzanyatiya = new ExpandoObject();
        Console.Write("Введите название вида занятия: ");
        vidzanyatiya.Name = Console.ReadLine() ?? "Net znach";
        return vidzanyatiya;
    }
    static ExpandoObject CreateOborudovanie()
    {
        dynamic oborudovanie = new ExpandoObject();
        Console.Write("\nВведите название оборудования: ");
        oborudovanie.Nazvanie = Console.ReadLine() ?? "Net znach";
        Console.Write("Введите стоимость оборудования: ");
        oborudovanie.Stoimost = Console.ReadLine() ?? "Net znach";
        Console.Write("Введите дату постановки оборудования: ");
        oborudovanie.Postanovka = Console.ReadLine() ?? "Net znach";
        return oborudovanie;
    }
    static ExpandoObject CreateKorpus()
    {
        dynamic korpus = new ExpandoObject();
        Console.Write("\nВведите название корпуса: ");
        korpus.Name = Console.ReadLine() ?? "Net znach";
        Console.Write("Введите адрес корпуса: ");
        korpus.Adress = Console.ReadLine() ?? "Net znach";
        korpus.Sotrydnik = CreateSotrydnik();
        korpus.Organizacia = CreateOrganizacia();
        return korpus;
    }
    static ExpandoObject CreateKtp()
    {
        dynamic ktp = new ExpandoObject();
        Console.WriteLine();
        ktp.Paragraf = CreateParagraf();
        ktp.VidZanyatiya = "Praktika";
        ktp.Materiali = CreateMateriali();
        Console.Write("\nВведите номер занятия: ");
        ktp.Nomer = Console.ReadLine() ?? "Net znach";
        Console.Write("Введите количество часов занятия: ");
        ktp.Chasi = Console.ReadLine() ?? "Net znach";
        return ktp;
    }
    
    static Organizacia CreateOrganizacia()
    {
        return new Organizacia();
    }
    static Sotrydnik CreateSotrydnik()
    {
        return new Sotrydnik();
    }
    static Paragraf CreateParagraf()
    {
        return new Paragraf();
    }
    static Materiali CreateMateriali()
    {
        return new Materiali();
    }
}
