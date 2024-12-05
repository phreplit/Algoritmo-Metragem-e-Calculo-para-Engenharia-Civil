
//  Author: PHNO - Tecnologo | Pos-Graduado
//  Data Release: 29/11/2024
//  Versao Codigo: 0.0.0.2v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Engenharia Civil, algoritmo desenvolvido em java, desenvolvido para estudantes e profissionais de engenharia civil e areas correlatas, como topografia.

import java.io.IOException;
import java.util.Scanner; // import lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: // choice Menu
while (true) {

  System.out.println("\n");
  System.out.println("\n");
  System.out.println(" Metragem e Calculo para Engenharia Civil ");
  System.out.println("");
  System.out.println("");
  System.out.println("1.Calcular Area de Terreno (4 Lados Iguais)");
  System.out.println("2.Calcular Area de Terreno (4 Lados Diferentes)");
  System.out.println("3.Calcular Perimetro de Imovel (4 Lados Iguais)");
  System.out.println("4.Calcular Perimetro de Imovel (4 L. Diferentes)");
  System.out.println("5.Calcular Quantos Metros Quadrados tem um Muro");
  System.out.println("6.Calcular Quantos Blocos por M² tera um Muro");
  System.out.println("7.Sair\n");
  System.out.println("");
  System.out.println("[8] Info");
  System.out.println("[9] Sobre "); // about
  
  System.out.println("\nDigite sua escolha: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    System.out.println("\nDigite o comprimento do terreno: "); 
    int v1 = scanner.nextInt();
    System.out.println("\nDigite a largura do terreno: "); 
    int v2 = scanner.nextInt();
    int result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nA area do terreno tem " + (result) + " metros quadrados.\n");
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    System.out.println("\nDigite o comprimento do lado 1 do terreno: ");  
    int v3 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite o comprimento do lado 2 do terreno: ");  
    int v4 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a largura do lado 3 do terreno: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a largura do lado 4 do terreno: ");  
    int v6 = scanner.nextInt();
    System.out.println("\n");
    int resultado = (v3 + v4) / 2;
    int resultado2 = (v5 + v6) / 2;
    int resultadofinal = (resultado * resultado2);
    System.out.println("\nA area do terreno com lados diferentes tem " + (resultadofinal) + " metros quadrados.");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:	  
    int v8 = 4;
    System.out.println("\nDigite um lado do imovel:  ");  
    int v7 = scanner.nextInt();
    System.out.println("\n");
    int result2 = v7 * v8;
    System.out.println("\nO perimetro do imovel com lados iguais tem " + (result2) + " metros corridos.");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    System.out.println("\nDigite o comprimento do lado 1 do imovel: ");   
    int v9 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite o comprimento do lado 2 do imovel: ");   
    int v10 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a largura do lado 3 do imovel: ");   
    int v11 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite a largura do lado 4 do imovel: ");   
    int v12 = scanner.nextInt();
    System.out.println("\n");
    int result3 = (v9 + v10);
    int result4 = (v11 + v12);
    int finalresult = (result3 + result4);
    System.out.println("\nO perimetro do imovel com lados diferentes tem " + (finalresult) + " metros corridos.");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
    System.out.println("\nDigite quantos metros de altura tem o muro: ");   
    int v13 = scanner.nextInt();
    System.out.println("\n");
    System.out.println("\nDigite quantos metros de largura tem o muro: ");   
    int v14 = scanner.nextInt();
    System.out.println("\n");
    int result5 = v13 * v14;
    System.out.println("\nO muro tem " + (result5) + " metros quadrados.");
    Scanner scanner5 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter5 = scanner5.nextLine();
    clear(); 
  break;
 case 6:
    int v16 = 25; // sabendo que um metro quadrado tem 25 blocos
    System.out.println("\nDigite quantos metros quadrados tem o muro: ");   
    int v15 = scanner.nextInt();
    System.out.println("\n");
    int result6 = v15 * v16;
    System.out.println("\nSera necessario " + (result6) + " blocos para construir um muro com " + (v15) + " metros quadrados.\n");
    Scanner scanner6 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter6 = scanner6.nextLine();
    clear();
  break;
  case 7:
    System.out.println("\n Algoritmo Finalizado! ");
  break loop;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("Para calcular a area de terreno com lados iguais em metros quadrados utilizamos Largura x Comprimento.");
  System.out.println("Para calcular a area de terreno com lados diferentes somamos dois lados paralelos largura com largura e dividimos por 2 tirando assim a media, e com os valores da media dos lados paralelos multiplicamos os dois e assim obtemos os metros quadrados de um terreno com lados diferentes.");
  System.out.println("");
  System.out.println("Para calcular o perimetro tanto de um imovel com lados iguais quanto de um imovel com lados diferentes basta somar os valores de todos os lados. se ocorrer de um imovel ter mais de 4 lados basta somar mais (N) tantos lados aos 4 lados ja existentes para obter o perimetro.");
  System.out.println("");
  System.out.println("Para Calcular Quantidade de Blocos em Muro:");
  System.out.println("Com base em um bloco de concreto com dimensoes (19Ax19Lx9C) em centimetros em vista de eixo horizontal, e sabendo que calcular um metro quadrado de um muro sera A x L entao 1 bloco de cimento tem 19cm, entao altura com 5 blocos x largura com 5 blocos = 25 blocos, assim um metro quadrado tem 25 blocos entao essa sera a medida padrao. 25 x tantos metros quadrados = a quantidade de blocos para construir um muro.");
  System.out.println("");
  System.out.println("Informacao Importante: ");
  System.out.println("Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.");
  System.out.println("");
  Scanner scanner7 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter7 = scanner7.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algoritmo: Metragem e Calculo para Engenharia Civil");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Data Release: 29/11/2024");
  System.out.println("Versao Codigo: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  default:
    Scanner scanner9 = new Scanner(System.in);
    System.out.println("\n Erro, Opcao Incorreta!");
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter9 = scanner9.nextLine();
    clear();
}
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nErro, falha no sistema!");
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}