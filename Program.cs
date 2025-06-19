using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone iphone = new Iphone("123456", "iPhone 14", "IMEI123456", 128);
        Smartphone nokia = new Nokia("654321", "Nokia Tijolão", "IMEI654321", 32);

        Console.WriteLine("=== Teste com iPhone ===");
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
        iphone.InstalarAplicativo("WhatsApp");
        iphone.ListarAplicativos();
        iphone.DesinstalarAplicativo("Instagram");
        iphone.ListarAplicativos();

        Console.WriteLine("\n=== Teste com Nokia ===");
        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
        nokia.ListarAplicativos();
        nokia.DesinstalarAplicativo("Snake");
        nokia.ListarAplicativos();
    }
}