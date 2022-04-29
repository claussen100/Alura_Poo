using System;

namespace Alura_Poo
{
    class Program
{
    public static void Main(string[] args)
    {
        ContaCorrente contaPatrick = new ContaCorrente();

        contaPatrick.titular = "Patrick Claussen";
        contaPatrick.agencia = 9590;
        contaPatrick.numero = 123;
        contaPatrick.saldo = 2500.30;

        Console.WriteLine($"\nNome: {contaPatrick.titular}");
        Console.WriteLine($"Numero agencia: {contaPatrick.agencia}");
        Console.WriteLine($"Numero conta: {contaPatrick.numero}");
        Console.WriteLine($"Saldo: {contaPatrick.saldo}\n");
    }
}
}
