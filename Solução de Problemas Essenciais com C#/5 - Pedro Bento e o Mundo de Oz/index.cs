using System;
using System.Linq;
using System.Collections.Generic;

class Program {

  static void Main(string[] args) {
    // Utilize Console.ReadLine para leitura do input de cada linha
    // Utilize Console.WriteLine para fazer o output de cada linha
    string input = Console.ReadLine();
      List<string> tiposJoia = new List<string>();
      do
      {
        if (!string.IsNullOrWhiteSpace(input))
        {
          tiposJoia.Add(input);
          input = Console.ReadLine();
        }
        } while (!string.IsNullOrWhiteSpace(input));
        int tiposDistintos = tiposJoia.Distinct().Count();
        Console.WriteLine(tiposDistintos);
  }
}

/** Desafio
No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo.
Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.

Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.

Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

* Entrada
A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento.
Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

* Saída
Imprima quantos tipos de jóias distintas Pedro Bento possui.

*/