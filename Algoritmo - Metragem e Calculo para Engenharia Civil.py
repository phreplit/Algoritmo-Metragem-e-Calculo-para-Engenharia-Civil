
'''  Author: PHNO - Tecnologo | Pos-Graduado
    Data Release: 29/11/2024
    Versao Codigo: 0.0.0.2v
    Replit: @PHNO, @PHREPLIT
    E-mail: phreplit@gmail.com  '''

''' Algoritmo: Metragem e Calculo para Engenharia Civil, algoritmo desenvolvido em python, desenvolvido para estudantes e profissionais de engenharia civil e areas correlatas, como topografia. '''

import os # import lib - os clear
import sys
import json

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print('Metragem e Calculo para Engenharia Civil')
  print('')
  print('')
  print('1.Calcular Area de Terreno (4 Lados Iguais)')
  print('2.Calcular Area de Terreno (4 Lados Diferentes)')
  print('3.Calcular Perimetro de Imovel (4 Lados Iguais)')
  print('4.Calcular Perimetro de Imovel (4 L. Diferentes)')
  print('5.Calcular Quantos Metros Quadrados tem um Muro')
  print('6.Calcular Quantos Blocos por M² tera um Muro')
  print('7.Sair')
  print('')
  print('[8] Info')
  print('[9] Sobre')
  print('')
  op = int(input('Digite sua escolha: '))
  if op == 1:
   print('')
   v1 = int(input('Digite o comprimento do terreno: '))
   print('')
   v2 = int(input('Digite a largura do terreno: '))
   result = v1 * v2
   print('')
   print('A area do terreno tem {} metros quadrados.'.format(result))
   print('')
   print('Teclar enter para retornar ao menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   print('')
   v1 = int(input('Digite o comprimento do lado 1 do terreno: '))
   print('')
   v2 = int(input('Digite o comprimento do lado 2 do terreno: '))
   print('')
   v3 = int(input('Digite a largura do lado 3 do terreno: '))
   print('')
   v4 = int(input('Digite a largura do lado 4 do terreno: '))
   resultado = int((v1 + v2) / 2)
   resultado2 = int((v3 + v4) / 2)
   resultadofinal = int(resultado * resultado2)
   print('')
   print('A area do terreno com lados diferentes tem {} metros quadrados.'.format(resultadofinal))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   v6 = int(4)
   print('')
   v5 = int(input('Digite um lado do imovel: '))
   print('')
   result3 = v5 * v6
   print('')
   print('O perimetro do imovel com lados iguais tem {} metros corridos.'.format(result3))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 4:
   print('')
   v1 = int(input('Digite o comprimento do lado 1 do imovel: '))
   print('')
   v2 = int(input('Digite o comprimento do lado 2 do imovel: '))
   print('')
   v3 = int(input('Digite a largura do lado 3 do imovel: '))
   print('')
   v4 = int(input('Digite a largura do lado 4 do imovel: '))
   resultado = int(v1 + v2)
   resultado2 = int(v3 + v4)
   resultadofinal = int(resultado + resultado2)
   print('')
   print('O perimetro do imovel com lados diferentes tem {} metros corridos.'.format(resultadofinal))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 5:    
   print('')
   v1 = int(input('Digite quantos metros de altura tem o muro: '))
   print('')
   v2 = int(input('Digite quantos metros de largura tem o muro: '))
   result5 = v1 * v2
   print('')
   print('O muro tem {} metros quadrados.'.format(result5))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 6:
   v12 = int(25) # sabendo que um metro quadrado tem 25 blocos
   print('')
   v11 = int(input('Digite quantos metros quadrados tem o muro: '))
   print('')
   result6 = v11 * v12
   print('')
   print('Sera necessario {} blocos para construir um muro com {} metros quadrados.'.format(result6,v11))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 7:
   print('')
   print('Algoritmo Finalizado!')
   print('')
   break
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')
   print('Para calcular a area de terreno com lados iguais em metros quadrados utilizamos Largura x Comprimento.')
   print('Para calcular a area de terreno com lados diferentes somamos dois lados paralelos largura com largura e dividimos por 2 tirando assim a media, e com os valores da media dos lados paralelos multiplicamos os dois e assim obtemos os metros quadrados de um terreno com lados diferentes.')
   print('Para calcular o perimetro tanto de um imovel com lados iguais quanto de um imovel com lados diferentes basta somar os valores de todos os lados. se ocorrer de um imovel ter mais de 4 lados basta somar mais (N) tantos lados aos 4 lados ja existentes para obter o perimetro.')
   print('')
   print('Para Calcular Quantidade de Blocos em Muro:')
   print('Com base em um bloco de concreto com dimensoes (19Ax19Lx9C) em centimetros em vista de eixo horizontal, e sabendo que calcular um metro quadrado de um muro sera A x L entao 1 bloco de cimento tem 19cm, entao altura com 5 blocos x largura com 5 blocos = 25 blocos, assim um metro quadrado tem 25 blocos entao essa sera a medida padrao. 25 x tantos metros quadrados = a quantidade de blocos para construir um muro.')
   print('')
   print('Informacao Importante:')
   print('')
   print('Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.')
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algoritmo: Metragem e Calculo para Engenharia Civil')
   print('')
   print('Author: PHNO')
   print('Data Release: 29/11/2024')
   print('Versao Codigo: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text()
  else: 
   print('')
   print('Erro. Opcao Incorreta!')
   print('')
   print('Teclar enter para retornar ao menu...')
   a6 = str(input(''))
   reset_text()