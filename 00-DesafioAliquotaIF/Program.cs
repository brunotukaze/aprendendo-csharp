﻿using System;
class Programa
{
    static void Main(string[] args )
    {
        Console.WriteLine("Executando Desafio alíquota com ifs");

        double salario = 4200.02;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("A sua aliquota é de 7.5%");
            Console.WriteLine("Você pode deduzir até R$ 142");
        }

        if (salario >= 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }

        if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("A sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir até R$ 636");
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}