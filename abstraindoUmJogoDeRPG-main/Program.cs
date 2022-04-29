using System;
using DIO.src.Entities;
namespace  dotnet_poo
{
    class Programs
    {
        static void Main(string[] args)
        {  
            Knight arus = new Knight("Arus",1,"Knight", 25, 100);            
            Wizard jennica = new Wizard("Jennica",1, "White Wizard");
            Ninja morpheus = new Ninja("Morpheus","Ninja",1,25, 90);
            Wizard kratos = new Wizard("Kratos",1,"Black Wizard!");

            
            Console.WriteLine();
            Console.WriteLine(arus);
            Console.WriteLine("Vamos derrotar nosso inimigo! Irei utilizar minha espada!");
            Console.WriteLine();
            Console.WriteLine(jennica);
            Console.WriteLine("Vou usar minhas melhores técnicas e magias para poder derrota-lo, sou uma bruxa muito poderosa");
            Console.WriteLine();
            Console.WriteLine(morpheus);
            Console.WriteLine(@"Sou como o silêncio de uma floresta virgem! Atacarei sem piedade e sem que o inimigo perceba!");
            Console.WriteLine();
            Console.WriteLine(kratos);
            Console.WriteLine(@"Venho das profundezas mais obscuras para ajudar-los, sou o maior e melhor Magico Negro!");
            Console.WriteLine();
            Console.WriteLine(kratos.Attack());
            Console.WriteLine();
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine();
            Console.WriteLine(morpheus.Attack());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(@"Após uma batalha dura e sangrenta o inimigo é derrotado por nossos melhores heróis!");

        }
    }
}

