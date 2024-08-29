using Encapsulation;

public class Program
{
    public static void Main()
    {
        // Geçerli kapı sayısı ile araba nesnesi oluşturulması
        Araba araba1 = new Araba("Reno", "Captur", "Turuncu", 4);
        Console.WriteLine($"Marka: {araba1.Marka}");
        Console.WriteLine($"Model: {araba1.Model}");
        Console.WriteLine($"Renk: {araba1.Renk}");
        Console.WriteLine($"Kapı Sayısı: {araba1.KapıSayısı}");

        // Geçersiz kapı sayısı ile araba nesnesi oluşturulması
        Araba araba2 = new Araba("BMW", "X5", "Siyah", 3);
        Console.WriteLine($"Marka: {araba2.Marka}");
        Console.WriteLine($"Model: {araba2.Model}");
        Console.WriteLine($"Renk: {araba2.Renk}");
        Console.WriteLine($"Kapı Sayısı: {araba2.KapıSayısı}");
    }
}