using System;
using System.Data.Common;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****
        
        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <10; contadorColuna++)
            {
                Console.Write("1");
                if (contadorColuna >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.Write(contadorColuna + 1);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

