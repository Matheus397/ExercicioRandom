using System;

public class Multiplication
{
    public static void Main(string[] args)
    {
        Random randomNumbers = new Random(); // gerador de numberos aleatórios
        int n1 = randomNumbers.Next(1, 11);
        int n2 = randomNumbers.Next(1, 11);
        int value = 0;

        while (true)
        {
            if (value != -1)
            {
                Console.Write("Please enter the answer to {0} x {1} = ?", n1, n2);
                int produto = n1 * n2;
                Console.WriteLine();
                int resposta = Convert.ToInt32(Console.ReadLine());

                while (produto != resposta)
                {
                    Console.WriteLine("Incorrect, enter another guess: ");
                    resposta = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Correto. Sua resposta foi {0} \n {1} x {2} = {3} Muito bom!",
                    resposta, n1, n2, produto);
                //Mantenha o console aberto 
                Console.WriteLine();
                Console.WriteLine("Press - 1 to exit");
                value = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                break;
            }
        }
    }
}