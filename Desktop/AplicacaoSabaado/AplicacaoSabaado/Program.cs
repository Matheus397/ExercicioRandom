using System;
using System.Globalization;

namespace AplicacaoSabaado

{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flex;
            char s;

            Carro veiculo = new Carro("Golf", Convert.ToDateTime("18/06/2019"), 278, 8, 4, "Volkswagen", "Alemanha");

            Console.WriteLine(DateTime.Now);

            double km = 160.6; 
            double litro = 74.5;

            Console.WriteLine("O carro é flex? (s/n)");
            s = Convert.ToChar(Console.ReadLine());

            if (s == 's' || s == 'S')

                flex = true;

            else

                flex = false;

            Console.Write("O Cálculo da quilometragem por litro do veículo resulta em: ");
            Console.WriteLine(veiculo.CalculoKilometragem(km, litro).ToString("F3", CultureInfo.InvariantCulture));

            Console.WriteLine(flex);

            Console.WriteLine($"Modelo: {veiculo.Nome}\n" + $"Data Fabricação: {veiculo.DataDeFabricacao}\n" 
           + $"Velocidade máxima: {veiculo.Velocidade()}\n" + $"Capacidade do tanque: {veiculo.CapacidadeTanque}\n" 
           + $"Kilometragem po Litro {veiculo.kmLitro}\n" +  $"Quantidade de portas: {veiculo.QuantPortas}\n"  
           + $"Marca: {veiculo.Marca}\n" + $"Pais de Origem: {veiculo.PaisDeOrigem}\n");

        }
    }
}
