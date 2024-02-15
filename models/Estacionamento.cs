using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Trabalho.models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        List<string> veiculos = new();


        public Estacionamento(decimal _precoInicial, decimal _precoHora)
        {
            this.precoInicial = _precoInicial;
            this.precoHora = _precoHora;
        }


        public void adicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do carro : ");
            string placa = Console.ReadLine()
                                    .ToLower()
                                    .Trim();
            string estacionado =$"{placa}";

            veiculos.Add(estacionado);
            Console.WriteLine("carro foi estacionado! : " + estacionado);
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do carro : ");
            string placa = Console.ReadLine()
                                    .ToLower()
                                    .Trim();
            if(veiculos.Contains(placa)){
                Console.WriteLine("quantas horas voce fico estacionado ?");
                int horas = int.Parse(Console.ReadLine());

                decimal precoFinal = this.precoInicial + this.precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"Carro da placa {placa} foi removido e ele terá que pagar {precoFinal}R$");
            }else{
                Console.WriteLine("Não foi encontrado");
            }}

        public void listarCarros(){
            int index = 0;
            veiculos.ForEach((veiculo) => {
                Console.WriteLine
                (
                    @$"
                        [
                            estacionado na vaga : {index++} 
                            placa do carro : {veiculo}
                        ]
                    "
                );
            });
        }
    }
}