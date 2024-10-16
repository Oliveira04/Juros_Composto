﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Solicita ao usuário para inserir os valores
        double P = Convert.ToDouble(Console.ReadLine());
        double i = Convert.ToDouble(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        // Calcula o montante final utilizando a função CalcularJurosCompostos
        double montanteFinal = CalcularJurosCompostos(P, i, n);

        // Exibe o resultado
        Console.WriteLine(montanteFinal);
    }

    public static double CalcularJurosCompostos(double P, double i, int n)
    {
         double montanteFinal = P * Math.Pow(1 + i, n);
        return montanteFinal; // Retorna o montante final
    }
}