int veiculo = 0,hora_total = 0,qtd_veiculo = 0,qtd_carro = 0,qtd_moto = 0, qtd_excedente = 0;
double des_veiculo,total_dia;
int ver_veiculo = 1;

while (ver_veiculo == 1)
{
    
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Deseja cadastrar um entrada de veiculo?:");
    Console.WriteLine(" 1 - Sim \n 2 - Encerrar dia ");
    ver_veiculo = int.Parse(Console.ReadLine());
    Console.WriteLine("---------------------------------------");

    if (ver_veiculo == 1)
    {
        Console.WriteLine("Deseja cadastrar qual tipo de veiculo?:");
        Console.WriteLine(" 1 - Carro \n 2 - Moto ");
        veiculo = int.Parse(Console.ReadLine());
        if (veiculo==1)
        {
            Console.WriteLine("Quanto tempo esse carro ficou no estacionamento?: ");
            hora_total = int.Parse(Console.ReadLine());
            if (hora_total<=2)
            {
                des_veiculo = hora_total*15;
            }
            else
            {
                des_veiculo = (hora_total-2)*5;
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
            if (hora_total<=2)
            {
                des_veiculo = hora_total*8;
            }
            else
            {
                des_veiculo = (hora_total-2)*3;
                des_veiculo += 8; 
                qtd_excedente++;
            }
            Console.WriteLine($"Valor a ser pago pelo Cliente é: {des_veiculo}");
            qtd_moto++;
        }
        qtd_veiculo++;

    }
}

Console.WriteLine(qtd_carro);
Console.WriteLine(qtd_moto);
Console.WriteLine(qtd_veiculo);
Console.WriteLine(qtd_excedente);