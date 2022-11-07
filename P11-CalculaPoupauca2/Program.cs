using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 11 - Calculando Poupança");

        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + "você terá R$" + investimento);

            // mes = mes +1 || mes += 1;
            mes++;
        } */

        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você terá R$" + investimento);
        }

        Console.WriteLine("Tecle enter para fechar..");
        Console.ReadLine();
    }
}