using System;

class Program
{
    public static void Main(string[] args)
    {
        string opcao = "S";
        do
        {
            Console.WriteLine("Sistema De Controle De Abastecimento");
            Console.WriteLine(" ");
            Console.WriteLine("Forneça o valor do alcool");
            float alcool = float.Parse(Console.ReadLine());
            Console.WriteLine("Forneça o valor da gasolina ");
            float gasolina = float.Parse(Console.ReadLine());
            float combustivel_apropriado = alcool / gasolina;

            if (combustivel_apropriado > 0.7)
            {
                Console.WriteLine("Mais vantajoso abastecer com gasolina");
            }
            else if (combustivel_apropriado < 0.7)
            {

                Console.WriteLine("Mais vantajoso abastecer com alcool");

            }
            else
            {
                Console.WriteLine("Tanto faz abastecer com alcool ou gasolina");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Deseja uma nova consulta? S/N");
            opcao = Console.ReadLine();
        } while (opcao == "s" || opcao == "S");
        Console.Write("Programa finalizado.");


    }
}
