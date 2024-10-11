
//  Author: PHNO - Tecnólogo | Pós-Graduado
//  Data Release: 04/11/2023
//  Versão Código: 2.0.1v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Engenharia Civil, algoritmo desenvolvido em c, desenvolvido para estudantes e profissionais de engenharia civil e areas correlatas, como topografia.

#include <stdio.h> // importa lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // cabecalho
void op2(); 
void op3();
void op4();
void op5();
void op6();
void op8();
int menu_desenvolvedor();

int menu() { // Funcao Menu  
int op, c;

printf("\n\t Metragem e Calculo para Engenharia Civil \n");

printf("\n");
printf("\n\t     Menu    \n");
printf("\n");

printf("\n1.Calcular Area de Terreno (4 Lados Iguais)");
printf("\n2.Calcular Area de Terreno (4 Lados Diferentes)");
printf("\n3.Calcular Perimetro de Imovel (4 Lados Iguais)");
printf("\n4.Calcular Perimetro de Imovel (4 L. Diferentes)");
printf("\n5.Calcular Quantos Metros Quadrados tem um Muro");
printf("\n6.Calcular Quantos Blocos por M² tera um Muro");
printf("\n7.Sair\n");
printf("\n[8] Info\n");
printf("\n[9] Sobre \n");

printf("\nDigite sua escolha: ");
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {
} // limpar o buffer do teclado.   
return op; 
}

int main() { // Funcao principal

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // funcao 
break; 
case 2: 
op2(); // funcao 
break; 
case 3: 
op3(); // funcao 
break;
case 4:
op4(); // funcao
break;
case 5:
op5(); // funcao
break;
case 6:
op6(); // funcao
break;
case 7:
printf("\n");
printf("\n Algoritmo Finalizado! \n"); // Ao Sair
printf("\n");
return 0;
break;
case 8:
op8(); // funcao
break;
case 9:
menu_desenvolvedor(); // funcao
break; 
default: 
printf("\n");
printf("Opcao Incorreta!\n");
printf("\n");
//printf("\n");
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
} 
} 
return 0; 
} 

void op1() { // Funcao calcular area terreno com lados iguais
int v1;
int v2;
int resultado;
printf("\n");
printf("\nDigite o comprimento do terreno: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nDigite a largura do terreno: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nA area do terreno tem %d metros quadrados.\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
//printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op2() { // // Funcao calcular area terreno com lados diferentes
int v1;
int v2;
int v3;
int v4;
int resultado;
int resultado2;
int resultadofinal;

printf("\n");
printf("\nDigite o comprimento do lado 1 do terreno: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nDigite o comprimento do lado 2 do terreno: ");
scanf("%d", &v2, stdin);
printf("\n");
printf("\nDigite a largura do lado 3 do terreno: ");
scanf("%d", &v3, stdin);
printf("\n");
printf("\nDigite a largura do lado 4 do terreno: ");
scanf("%d", &v4, stdin);

resultado = (v1 + v2) / 2;
resultado2 = (v3 + v4) / 2;
resultadofinal = (resultado * resultado2);

printf("\nA area do terreno com lados diferentes tem %d metros quadrados.\n", resultadofinal);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op3() { // Funcao calcular perimetro imovel
int v1;
int v2 = 4;
int resultado;
printf("\n");
printf("\nDigite um lado do imovel: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = v1 * v2;
printf("\nO perimetro do imovel com lados iguais tem %d metros.\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op4() { // Funcao calcular perimetro imovel lados diferentes

int v1;
int v2;
int v3;
int v4;
int resultado;
int resultado2;
int resultadofinal;

printf("\n");
printf("\nDigite o comprimento do lado 1 do imovel: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nDigite o comprimento do lado 2 do imovel: ");
scanf("%d", &v2, stdin);
printf("\n");
printf("\nDigite a largura do lado 3 do imovel: ");
scanf("%d", &v3, stdin);
printf("\n");
printf("\nDigite a largura do lado 4 do imovel: ");
scanf("%d", &v4, stdin);

resultado = (v1 + v2);
resultado2 = (v3 + v4);
resultadofinal = (resultado + resultado2);

printf("\nO perimetro do imovel com lados diferentes tem %d metros.\n", resultadofinal);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op5() { // Funcao calcular metro quadrado de muro
int v1;
int v2;
int resultado;
printf("\n");
printf("\nDigite quantos metros de altura tem o muro: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nDigite quantos metros de largura tem o muro: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nO muro tem %d metros quadrados. \n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op6() { // Funcao calcular blocos para construir muro
int v1;
int v2 = 25; // sabendo que um metro quadrado tem 25 blocos
int resultado;
printf("\n");
printf("\nDigite quantos metros quadrados tem o muro: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = v1 * v2;
printf("\nSera necessario %d blocos para construir um muro com %d metros quadrados. \n", resultado, v1);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op8() {
system("clear");      // linux
system("tput reset"); // linux
printf("\nInfo\n");
printf("\nEste algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.\n");
printf("\nPara calcular a area de terreno com lados iguais em metros quadrados utilizamos Largura x Comprimento.\n");
printf("\nPara calcular a area de terreno com lados diferentes somamos dois lados paralelos largura com largura e dividimos por 2 tirando assim a media, e com os valores da media dos lados paralelos multiplicamos os dois e assim obtemos os metros quadrados de um terreno com lados diferentes.\n");
printf("\nPara calcular o perimetro tanto de um imovel com lados iguais quanto de um imovel com lados diferentes basta somar os valores de todos os lados. se ocorrer de um imovel ter mais de 4 lados basta somar mais (N) tantos lados aos 4 lados ja existentes para obter o perimetro.\n");
printf("\nPara Calcular Quantidade de Blocos em Muro:\n");
printf("\nCom base em um bloco de concreto com dimensoes (19Ax19Lx9C) em centimetros em vista de eixo horizontal, e sabendo que calcular um metro quadrado de um muro sera A x L entao 1 bloco de cimento tem 19cm, entao altura com 5 blocos x largura com 5 blocos = 25 blocos, assim um metro quadrado tem 25 blocos entao essa sera a medida padrao. 25 x tantos metros quadrados = a quantidade de blocos para construir um muro. \n");
printf("\nTeclar enter para retornar ao menu...\n ");
getchar();
scanf("c\n");
system("clear");      // linux
system("tput reset"); // linux
return;
}

int menu_desenvolvedor(){
  system("clear");      // linux
  system("tput reset"); // linux
  printf("\n Algoritmo: Metragem e Calculo para Engenharia Civil \n");
  printf("\n Author: PHNO ");
  printf("\n Data Release: 04/11/2023 ");
  printf("\n Versao Codigo: 2.0.1v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Teclar enter para retornar ao menu...\n ");
  getchar();
  scanf("c\n");
  system("clear");      // linux
  system("tput reset"); // linux
  return 0;
}
