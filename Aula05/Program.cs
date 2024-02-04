// See https://aka.ms/new-console-template for more information
//Aula EstruturasCondicionaisCondicionais

//Criar uma variavel inteira com valor 0
int valorM = 10;
int valorC = 20;
int valor = 0;

//Solicitar uma opção ao usuario
Console.WriteLine("Qual o é o tipo do seu veiculo. (M) para MOTO e (C) para Carro");
//Captura o valor digitado e coloca dentro de uma variavel do tipo string
string veiculos = Console.ReadLine();

//Solicitar uma opção ao usuario
Console.WriteLine("\nQuantas horas você deixará seu veiculo.");
//Captura o valor digitado e coloca dentro de uma variavel do tipo string
string horas = Console.ReadLine();

if (veiculos == "M")
{
    //Mostra ao usuario sua opção e pede sua confirmação.
    Console.WriteLine("\nVoce Selecionou a OPção (" + veiculos + ") - MOTO por " + horas + " horas Estacionado. Confirma o Opção, Selecione (S) para Sim e (N) para Nao");
    //Captura o valor digitado e coloca dentro de uma variavel do tipo string
    string confirmacao = Console.ReadLine();

    if(confirmacao == "S")
    {
        valor = valorM * int.Parse(horas);

        Console.WriteLine(
            "Você Pagara pelo estacionamento da Moto, por" + horas + " o valor de R$ " + valor);
            }

}else if (veiculos == "C")
    {
    //Mostra ao usuario sua opção e pede sua confirmação.
    Console.WriteLine("\nVoce Selecionou a OPção (" + veiculos + ") - CARRO por " + horas + " horas Estacionado. Confirma o Opção, Selecione (S) para Sim e (N) para Nao");
    //Captura o valor digitado e coloca dentro de uma variavel do tipo string
    string confirmacao1 = Console.ReadLine();

    if (confirmacao1 == "S")
    {
        valor = valorC * int.Parse(horas);

        Console.WriteLine(
            "Você Pagara pelo estacionamento do Carro, por" + horas + " o valor de R$ " + valor );
    }

}
else 
{
    Console.WriteLine("Nosso Estacionamento não trabalha com este tipo de veiculo");
}