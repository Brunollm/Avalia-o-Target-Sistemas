using System.Xml;

decimal valorMenorFaturamento = 0, valorMaiorFaturamento = 0, valorTemp = 0, valorMedia = 0;
int diaMenorFaturamento = 0, diaMaiorFaturamento = 0, diaAtual = 0, qtdDias, diasSemValor = 0, contMaiorMedia = 0;
decimal[] valoresDoMes = new decimal[31];
bool menorFaturamentoRecebido = false;

XmlTextReader xmlReader = new XmlTextReader("dados.xml");

for (int i = 0; xmlReader.Read();)
{
    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "dia")
    {
        diaAtual = xmlReader.ReadElementContentAsInt();
    }

    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "valor")
    {
        valorTemp = xmlReader.ReadElementContentAsDecimal();
        valoresDoMes[i] = valorTemp;
        i++;

        if (valorTemp != 0 && menorFaturamentoRecebido == false)
        {
            diaMenorFaturamento = diaAtual;
            valorMenorFaturamento = valorTemp;
            menorFaturamentoRecebido = true;
        }

        if (valorTemp != 0 && valorTemp < valorMenorFaturamento)
        {
            diaMenorFaturamento = diaAtual;
            valorMenorFaturamento = valorTemp;
        }

        if (valorTemp == 0)
        {
            diasSemValor++;
        }
        valorMedia += valorTemp;

        if (valorTemp > valorMaiorFaturamento)
        {
            diaMaiorFaturamento = diaAtual;
            valorMaiorFaturamento = valorTemp;
        }
    }
}

xmlReader.Close();
qtdDias = diaAtual - diasSemValor;
valorMedia = valorMedia / qtdDias;


foreach (decimal valor in valoresDoMes)
{
    if (valor > valorMedia)
    {
        contMaiorMedia++;
    }
}

Console.WriteLine("O valor da média mensal foi de: " + valorMedia.ToString("#.##"));
Console.WriteLine("Quantidade de dias em que o valor foi maior: " + contMaiorMedia + "\n");
Console.WriteLine("Dia com menor faturamento foi: Dia " + diaMenorFaturamento + "\nNeste dia foi faturado: R$ " + valorMenorFaturamento + "\n");
Console.WriteLine("Dia com maior faturamento foi: Dia " + diaMaiorFaturamento + "\nNeste dia foi faturado: R$ " + valorMaiorFaturamento);
Console.ReadLine();