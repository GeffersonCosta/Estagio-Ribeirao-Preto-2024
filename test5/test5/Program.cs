using System;

class Program
{
    static void Main(string[] args)
    {
        string caracteres = "GEFFERSON"; // conjunto de caracteres

        Console.WriteLine("Conjunto original de caracteres: " + caracteres);

        // Inverte os caracteres
        string caracteresInvertidos = "";
        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            caracteresInvertidos += caracteres[i];
        }

        Console.WriteLine("caracteres invertido: " + caracteresInvertidos);
    }
}