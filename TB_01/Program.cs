int veiculo = 0, hora_total = 0, qtd_veiculo = 0, qtd_carro = 0, qtd_moto = 0, qtd_excedente = 0;
double des_veiculo, total_dia;

Console.WriteLine("Quantos veiculos deseja cadastrar:");
int ver_veiculo = int.Parse(Console.ReadLine());


for (int i = 0; i < ver_veiculo; i++)

{

    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Deseja cadastrar qual tipo de veiculo?:");
    Console.WriteLine(" 1 - Carro \n 2 - Moto ");
    Console.WriteLine("---------------------------------------");
    veiculo = int.Parse(Console.ReadLine());


    if (veiculo == 1)
    {
        Console.WriteLine("Quanto tempo esse carro ficou no estacionamento?: ");
        hora_total = int.Parse(Console.ReadLine());
        if (hora_total <= 2)
        {
            des_veiculo = hora_total * 15;
        }
        else
        {
            des_veiculo = (hora_total - 2) * 5;
            des_veiculo += 15;
            qtd_excedente++;
        }
        Console.WriteLine($"Valor a ser pago pelo Cliente é: {des_veiculo}");
        qtd_carro++;
    }

    else
    {
        Console.WriteLine("Quanto tempo essa moto ficou no estacionamento?: ");
        hora_total = int.Parse(Console.ReadLine());
        if (hora_total <= 2)
        {
            des_veiculo = hora_total * 8;
        }
        else
        {
            des_veiculo = (hora_total - 2) * 3;
            des_veiculo += 8;
            qtd_excedente++;
        }
        Console.WriteLine($"Valor a ser pago pelo Cliente é: {des_veiculo}");
        qtd_moto++;
    }
    qtd_veiculo++;

}

Console.WriteLine($"Foram atendidos {qtd_veiculo} veiculos no total.");
Console.WriteLine($"Foram atendidos {qtd_carro} carros.");
Console.WriteLine($"Foram atendidas {qtd_moto} motos.");
Console.WriteLine($"Foram {qtd_excedente} veiculos que excederam as 2 horas.");