using DHL.Courier.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHL.WebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Cоздать КН");
            Console.WriteLine("2. Список КН");

            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            if(num == 1)
            {

                exDelivery delivery = new exDelivery();

                Console.Write("Введите ContentId: ");
                delivery.ContentId = int.Parse(Console.ReadLine());
                Console.Write("Введите KindTariffId:");
                delivery.KindTariffId = int.Parse(Console.ReadLine());
                Console.Write("Введите PhoneSender: ");
                delivery.PhoneSender = Console.ReadLine();
                Console.Write("Введите SenderName: ");
                delivery.SenderName = Console.ReadLine();
                Console.Write("Введите SchemeDeliver: ");
                delivery.SchemeDeliver = Console.ReadLine();
                Console.Write("Введите WeightActual: ");
                delivery.WeightActual = int.Parse(Console.ReadLine());
                Console.Write("Введите WeightVolume: ");
                delivery.WeightVolume = int.Parse(Console.ReadLine());
                


                ServiceCourier courier = new ServiceCourier("exDelivery.db");
                bool result = courier.CreateExDelivery(delivery);
                if(result == true)
                    Console.WriteLine("КН успешно добавлена");
                else
                    Console.WriteLine("КН успешно не добавлена");

            }
            else if(num == 2)
            {
                Console.WriteLine("Список КН");
               
                ServiceCourier cour = new ServiceCourier("exDelivery.db");
                List<exDelivery> del = cour.GetEverything();
                foreach (exDelivery item in del)
                {
                    Console.WriteLine("Id КН: " + item.Id);
                    Console.WriteLine("KindTariffId КН: " + item.KindTariffId);
                    Console.WriteLine("PhoneSender: " + item.PhoneSender);
                    Console.WriteLine("SchemeDeliver: " + item.SchemeDeliver);
                    Console.WriteLine("SenderName: " + item.SenderName);
                    Console.WriteLine("----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Такого варианта нету!");
            }
            
        }
    }
}
