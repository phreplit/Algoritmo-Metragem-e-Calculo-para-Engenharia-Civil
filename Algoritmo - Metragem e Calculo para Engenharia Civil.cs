
//  Author: PHNO - Tecnólogo | Pós-Graduado
//  Data Release: 29/11/2024
//  Versão Código: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Engenharia Civil, algoritmo desenvolvido em c sharp, desenvolvido para estudantes e profissionais de engenharia civil e areas correlatas, como topografia.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Algoritmo_Metragem_e_Calculo_para_Engenharia_Civil
    {
        class Program
        { // classe

            public static void Main(string[] args)
            {

                while (true)
                {
                    // class, method, string
                    Console.WriteLine("\n");
                    Console.WriteLine(" Metragem e Calculo para Engenharia Civil ");
                    Console.WriteLine("");
                    Console.WriteLine("\n\t     Menu    \n");
                    Console.WriteLine("");
                    Console.WriteLine("1.Calcular Area de Terreno (4 Lados Iguais)");
                    Console.WriteLine("2.Calcular Area de Terreno (4 Lados Diferentes)");
                    Console.WriteLine("3.Calcular Perimetro de Imovel (4 Lados Iguais)");
                    Console.WriteLine("4.Calcular Perimetro de Imovel (4 L. Diferentes)");
                    Console.WriteLine("5.Calcular Quantos Metros Quadrados tem um Muro");
                    Console.WriteLine("6.Calcular Quantos Blocos por M² tera um Muro");
                    Console.WriteLine("7.Sair");
                    Console.WriteLine("");
                    Console.WriteLine("[8] Info");
                    Console.WriteLine("[9] Sobre");

                    Console.WriteLine("\nDigite sua escolha: "); // choice

                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Digite o comprimento do terreno: ");
                                int v1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a largura do terreno:  ");
                                int v2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                int resultado = v1 * v2;
                                Console.WriteLine("A area do terreno tem " + (resultado) + " metros quadrados.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 2:
                                Console.WriteLine("Digite o comprimento do lado 1 do terreno: ");
                                int v3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite o comprimento do lado 2 do terreno: ");
                                int v4 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a largura do lado 3 do terreno: ");
                                int v5 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a largura do lado 4 do terreno: ");
                                int v6 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado1 = (v3 + v4) / 2;
                                int resultado2 = (v5 + v6) / 2;
                                int resultadofinal = (resultado1 * resultado2);
                                Console.WriteLine();
                                Console.WriteLine("A area do terreno com lados diferentes tem " + (resultadofinal) + " metros quadrados.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 3:
                                int v8 = 4;
                                Console.WriteLine("Digite um lado do imovel: ");
                                int v7 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado3 = v7 * v8;
                                Console.WriteLine();
                                Console.WriteLine("O perimetro do imovel com lados iguais tem " + (resultado3) + " metros corridos.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 4:
                                Console.WriteLine("Digite o comprimento do lado 1 do imovel: ");
                                int v9 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite o comprimento do lado 2 do imovel: ");
                                int v10 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a largura do lado 3 do imovel: ");
                                int v11 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite a largura do lado 4 do imovel: ");
                                int v12 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado4 = (v9 + v10);
                                int resultado5 = (v11 + v12);
                                int resultadofinal1 = (resultado4 + resultado5);
                                Console.WriteLine();
                                Console.WriteLine("O perimetro do imovel com lados diferentes tem " + (resultadofinal1) + " metros corridos.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 5:                                
                                Console.WriteLine("Digite quantos metros de altura tem o muro: ");
                                int v13 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                Console.WriteLine("Digite quantos metros de largura tem o muro: ");
                                int v14 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado6 = v13 * v14;
                                Console.WriteLine();
                                Console.WriteLine("O muro tem " + (resultado6) + " metros quadrados.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 6:
                                int v16 = 25; // sabendo que um metro quadrado tem 25 blocos
                                Console.WriteLine("Digite quantos metros quadrados tem o muro: ");
                                int v15 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n");
                                int resultado7 = v15 * v16;
                                Console.WriteLine();
                                Console.WriteLine("Sera necessario " + (resultado7) + " blocos para construir um muro com " + (v15) + " metros quadrados.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 7:
                                Exit();
                                break;
                            case 8:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Info");
                                Console.WriteLine();
                                Console.WriteLine("Para calcular a area de terreno com lados iguais em metros quadrados utilizamos Largura x Comprimento.");
                                Console.WriteLine("Para calcular a area de terreno com lados diferentes somamos dois lados paralelos largura com largura e dividimos por 2 tirando assim a media, ");
                                Console.WriteLine("e com os valores da media dos lados paralelos multiplicamos os dois e assim obtemos os metros quadrados de um terreno com lados diferentes.");
                                Console.WriteLine("Para calcular o perimetro tanto de um imovel com lados iguais quanto de um imovel com lados diferentes basta somar os valores de todos os lados. ");
                                Console.WriteLine("se ocorrer de um imovel ter mais de 4 lados basta somar mais (N) tantos lados aos 4 lados ja existentes para obter o perimetro.");
                                Console.WriteLine("Para Calcular Quantidade de Blocos em Muro:");
                                Console.WriteLine("Com base em um bloco de concreto com dimensoes (19Ax19Lx9C) em centimetros em vista de eixo horizontal, e sabendo que calcular um metro quadrado de um muro sera A x L entao 1 bloco de cimento tem 19cm, ");
                                Console.WriteLine("entao altura com 5 blocos x largura com 5 blocos = 25 blocos, assim um metro quadrado tem 25 blocos entao essa sera a medida padrao. 25 x tantos metros quadrados = a quantidade de blocos para construir um muro.");
                                Console.WriteLine("Informacao Importante: ");
                                Console.WriteLine();
                                Console.WriteLine("Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            case 9:
                                Clear();
                                Console.WriteLine();
                                Console.WriteLine("Algoritmo: Metragem e Calculo para Engenharia Civil");
                                Console.WriteLine();
                                Console.WriteLine("Author: PHNO");
                                Console.WriteLine("Data Release: 29/11/2024");
                                Console.WriteLine("Versao Codigo: 0.0.0.2v");
                                Console.WriteLine("Replit: @PHNO, @PHREPLIT");
                                Console.WriteLine("E-mail: phreplit@gmail.com");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                            default:
                                Console.WriteLine("Erro, Opcao Incorreta! ");
                                Console.WriteLine();
                                Console.WriteLine("Teclar enter para retornar ao menu...");
                                Console.ReadKey();
                                Clear();
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro, falha no sistema.");
                        Console.WriteLine();
                        Console.WriteLine("Teclar enter para retornar ao menu...");
                        Console.ReadKey();
                        Clear();
                    }
                }
            }
            public static void Exit()
            { // exit method
                Console.WriteLine();
                Console.WriteLine(" Algoritmo Finalizado! ");
                System.Environment.Exit(-1);
                return;
            }
            public static void Clear()
            { // method 
                Console.Clear();
                return;
            }
        }
    }
