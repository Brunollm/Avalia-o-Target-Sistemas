int val01 = 0, val02 = 1, valSoma = 0, valorUsuario;

Console.Write("Digite um valor: ");
valorUsuario = Convert.ToInt32(Console.ReadLine());

for (; valSoma < valorUsuario;)
{
    valSoma = val01 + val02;
    if (val01 < val02)
    {
        val01 = valSoma;
    }
    else
    {
        val02 = valSoma;
    }

    if (valSoma == valorUsuario)
    {
        Console.WriteLine("Está na sequência de Fibonacci");
        
    }
    if (valSoma > valorUsuario)
    {
        Console.WriteLine("Valor digitado não está na sequência de Fibonacci");
        
    }

}