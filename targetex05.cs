string stringOriginal = "abc";
string stringReversa = "";
int tamanhoArray;

tamanhoArray = stringOriginal.Length - 1;

while (tamanhoArray >= 0)
{
    stringReversa = stringReversa + stringOriginal[tamanhoArray];
    tamanhoArray--;
}
Console.WriteLine(stringReversa);