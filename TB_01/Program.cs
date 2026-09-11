int veiculo = 0, hora_total = 0, qtd_carro = 0, qtd_moto = 0, qtd_excedente = 0, qtd_veiculo = 0;
double des_veiculo = 0 ,total_dia = 0;

Console.Write("Quantos veículos deseja cadastrar: ");
int cad_veiculo = int.Parse(Console.ReadLine());


for (int i = 1; i <= cad_veiculo; i++)

{

    Console.WriteLine("---------------------------------------");
    Console.WriteLine($"Qual o tipo do {i}° veículo a ser cadastrado?: ");
    Console.WriteLine(" 1 - Carro \n 2 - Moto \n");
    veiculo = int.Parse(Console.ReadLine());
    

    if (veiculo == 1)
    {
        Console.Write("Quantas horas esse carro ficou no estacionamento?: ");
        hora_total = int.Parse(Console.ReadLine());

        if (hora_total <= 2)
        {
            des_veiculo =  15;
        }
        else
        {
            des_veiculo = (hora_total - 2) * 5;
            des_veiculo += 15;
            qtd_excedente++;
        }
        Console.WriteLine($"Valor a ser pago pelo cliente é: R$ {des_veiculo :f2}.");
        qtd_carro++;
    }

    else if (veiculo == 2)
    {
        Console.Write("Quantas horas essa moto ficou no estacionamento?: ");
        hora_total = int.Parse(Console.ReadLine());
        if (hora_total <= 2)
        {
            des_veiculo = 8;
        }
        else
        {
            des_veiculo = (hora_total - 2) * 3;
            des_veiculo += 8;
            qtd_excedente++;
        }
        Console.WriteLine($"Valor a ser pago pelo Cliente é: R$ {des_veiculo :f2}.");
        qtd_moto++;
    }
    else
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Veículo inválido");
        break;
    }

    total_dia += des_veiculo;
    qtd_veiculo++;

}

Console.WriteLine("---------------------------------------");
Console.WriteLine($"Foram cadastrados {qtd_veiculo} veiculos no total.");
Console.WriteLine($"Valor total do dia: R$ {total_dia :f2} ");
Console.WriteLine($"{qtd_carro} carros, {qtd_moto} motos.");
Console.WriteLine($"{qtd_excedente} veiculos excederam as 2 horas.");