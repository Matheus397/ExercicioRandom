using System;

namespace AplicacaoSabaado
{
    public class Carro
    {
        public string Nome, Marca, PaisDeOrigem;
        public DateTime DataDeFabricacao;       
        public int QuantPortas, CapacidadeTanque, kmLitro;      
           
        public Carro(string nome, DateTime datafabricacao,int capacidade_tanque, int km_litro, int quant_portas, string marca, string pais_de_origem)
        {
            Nome = nome;
            Marca = marca;
            PaisDeOrigem = pais_de_origem;
            DataDeFabricacao = datafabricacao;
            CapacidadeTanque = capacidade_tanque;
            kmLitro = km_litro;
            QuantPortas = quant_portas;
            FuncaoPrivada();

        }

        public int Velocidade() => 220;

        public void FuncaoPrivada() { Nome = Nome.ToLower(); }

        public double CalculoKilometragem (double km, double litro) { return km / litro; }
    }
}
