using System;
using celular_2;

namespace celular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular1 iphone = new Celular1();
            iphone.modelo  ="x";
            iphone.tamanho =10f;
            Console.WriteLine("Ligar o celular?");
            iphone.ligado = Boolean.Parse(Console.ReadLine());

            if(iphone.ligado){
                while (iphone.ligado)
                {
                    Console.WriteLine("O que deseja fazer? \n 1-Ligação\n 2-Mensagem \n 3-Desligar");
                    int resposta =Int32.Parse(Console.ReadLine());

                    switch (resposta)
                    {
                        case 1:
                        Console.WriteLine(iphone.Ligar());
                        break;

                        case 2:
                        Console.WriteLine(iphone.Mensagem());
                        break;

                        case 3:
                        Console.WriteLine(iphone.Desligar());
                        break;

                        default:
                        Console.WriteLine(iphone.Ligar());
                        break;
                    }
                }
            }else{
                Console.WriteLine("Celular Desligado");
            }
        }
    }

}

