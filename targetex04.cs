float totalSoma;
float[] cidade = new float[] { 67836.43f, 36678.66f, 29229.88f, 27165.48f, 19849.53f };
string[] nomeCidade = new string[] { "São Paulo", "Rio de Janeiro", "Minas Gerais", "Espírito Santo", "Outros" };

totalSoma = cidade[0] + cidade[1] + cidade[2] + cidade[3] + cidade[4];

Console.WriteLine("Total da Soma de todas as cidades: " + totalSoma);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Valor percentual na cidade de " + nomeCidade[i] + " é de: " + ((cidade[i] * 100) / totalSoma).ToString("#.##") + "%");
}
Console.ReadLine();