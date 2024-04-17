int Cont;

do
{
    Console.WriteLine("Seja bem-vindo, me informe seu nome por favor.");
    string? nome = Console.ReadLine();

    Console.WriteLine("Me informe sua idade.");
    int idade = Convert.ToInt32(Console.ReadLine());

    string faixaEtaria;

    if (idade <= 11)
    {
        faixaEtaria = "Criança";
    }
    else if (idade >= 12 && idade <= 19)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 20 && idade <= 64)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    Console.WriteLine("Me informe sua altura em METROS!");
    float altura = float.Parse(Console.ReadLine());

    Console.WriteLine("Me informe seu peso em KG");
    double peso = Convert.ToDouble(Console.ReadLine());

    float IMC = (float)(peso / (altura * altura));

    if (IMC < 18.5f)
    {
        Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e se encaixa na faixa etária de {faixaEtaria}. Seu IMC é: {IMC}. Você está abaixo do peso ideal.");
    }
    else if (IMC >= 18.5f && IMC <= 24.9f)
    {
        Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e se encaixa na faixa etária de {faixaEtaria}. Seu IMC é: {IMC}. Você está com peso normal.");
    }
    else if (IMC >= 25f && IMC <= 29.9f)
    {
        Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e se encaixa na faixa etária de {faixaEtaria}. Seu IMC é: {IMC}. Você está com sobrepeso.");
    }
    else if (IMC < 0)
    {
        Console.WriteLine("Seu IMC ficou abaixo de 0, preencha as informações corretamente de acordo com as medidas solicitadas. Caso o erro persista, tente usar , ao invés de .");
    }
    else
    {
        Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e se encaixa na faixa etária de {faixaEtaria}. Seu IMC é: {IMC}. Você está com obesidade.");
    }

    Console.WriteLine("Digite 1 para sair ou qualquer outro número para continuar:");
    Cont = Convert.ToInt32(Console.ReadLine());

} while (Cont != 1);