﻿// See https://aka.ms/new-console-template for more information
using System;
public class Program
{
	public static void Main()
	{
		Double calculo, n1, n2;
	   
		Console.Write("Escolha o primeiro número a ser calculado: ");
		String texto = Console.ReadLine();
		if (Double.TryParse(texto, out  n1)){
			Console.Write("Escolha o segundo número a ser calculado: ");
		String texto1 = Console.ReadLine();
				if (Double.TryParse(texto1,out n2)){
			
				Console.Write("Escolha a operação a ser utilizada (+  -  *  /): ");
				string operador = Console.ReadLine();
				switch(operador)
				{
					case"+": 
					calculo = n1+n2;
						Console.Write("O resultado da soma é:  "+ calculo);
						break;
					case"-":
					calculo = n1-n2;
						Console.Write("O resultado da subtração é "+ calculo);
						break;
					case"*": 
					calculo = n1*n2;
						Console.Write("O resultado da multiplicação é: "+ calculo);
						break;
					case"/": 
						if (n1 == 0)
						{
							Console.Write("Divisão por zero");
						}
						if (n2 == 0)
						{
							Console.Write("Divisão por zero");
						}
						else
						{
						calculo = n1/n2;
						Console.Write("O resultado da divisão é: "+ calculo);
						}
						break;
					default:
						Console.Write("Operação Invalida");
						break;
				}
			
					}
			else
			{
				Console.WriteLine("Número Inválido");
			}
		
		
				}
		else
		{
			Console.WriteLine("Número Inválido");
		}
	}
	}
