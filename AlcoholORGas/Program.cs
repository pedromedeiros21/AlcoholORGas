using System;

namespace AlcoholORGas
{
    class Program
    {
        static void Main(string[] args)
        {
            double gasolina, alcool;
            double divisao;
            var reiniciar = true;

            while (reiniciar)
            {
                Console.WriteLine("Digite o preço da gasolina");
                gasolina = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o preço do álcool");
                alcool = Convert.ToDouble(Console.ReadLine());

                divisao = alcool / gasolina;

                if (divisao > 0.7)
                {
                    Console.WriteLine("Vale a pena abastecer com gasolina");
                }
                else if (divisao < 0.7)
                {
                    Console.WriteLine("Vale a pena abastecer com álcool");
                }
                else
                {
                    Console.WriteLine("Tanto faz com qual abastecer");
                }

                Console.Write("Deseja continuar? Sim/Não: ");
                if (Console.ReadLine() == "Não")
                {
                    Console.WriteLine("Encerrando...");
                    reiniciar = false;
                }
                else
                {
                    Console.WriteLine("Reiniciando...");
                    Console.WriteLine();
                }
            }
        }
    }
}
