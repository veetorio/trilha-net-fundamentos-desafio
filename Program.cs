using Trabalho.models;

Estacionamento estacionamento = new(100,50);
int initOrExit = 1;
while (initOrExit == 1)
{
    Console.WriteLine(@"
    qual operação deseja executar

    + [adicionar carro]
    + [remover carro]
    + [listar carros]");
    string opt = Console.ReadLine()
        .ToLower()
        .Trim();

    if (!opt.Equals(" "))
    {
        switch (opt)
        {

            case "adicionar carro":
                estacionamento.adicionarVeiculo();
                break;

            case "remover carro":
                estacionamento.removerVeiculo();
                break;

            case "listar carros":
                estacionamento.listarCarros();
                break;

        }
    }



    Console.WriteLine(" 1 : para continuar ; 0 : para sair ;");
    initOrExit = int.Parse(Console.ReadLine());
}
