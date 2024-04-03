using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Nokia nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "1234567890", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("'WhatsApp'");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");
            Iphone iphone = new Iphone(numero: "4987", modelo: "iPhone 15", imei: "1098765", memoria: 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("'Telegram'");
        }
    }
}