# Desafio 2 — Controle de Estoque

## Descrição

O objetivo deste desafio é desenvolver um programa em **C#** capaz de realizar o controle de estoque de produtos a partir de um arquivo JSON.

Cada produto possui:

* Código do produto;
* Descrição do produto;
* Quantidade disponível em estoque.

O programa permite realizar **entradas e saídas de produtos**, consultar o estoque atual e visualizar o histórico de movimentações realizadas.

As movimentações registram:

* ID da movimentação;
* Código do produto;
* Tipo da movimentação (Entrada ou Saída);
* Quantidade movimentada;
* Descrição da movimentação.

O sistema também verifica se existe quantidade suficiente em estoque antes de realizar uma saída.

## Como executar

Certifique-se de que o arquivo `estoque.json` esteja no diretório correto do projeto.

Depois, execute:

```bash
dotnet run
```

O programa irá carregar automaticamente os produtos do arquivo `estoque.json` e apresentar um menu de controle no console.

## Funcionalidades

O sistema disponibiliza as seguintes opções:

```text
1 - Entrada
2 - Saída
3 - Consultar estoque
4 - Consultar movimentações
0 - Sair
```

### Entrada

Permite adicionar uma determinada quantidade a um produto existente no estoque. A movimentação é registrada como **Entrada**.

### Saída

Permite retirar uma quantidade de um produto existente. O sistema verifica se há quantidade suficiente disponível antes de realizar a operação.

### Consultar estoque

Exibe o código, a descrição e a quantidade atual de cada produto cadastrado.

### Consultar movimentações

Exibe o histórico das movimentações realizadas durante a execução do programa, incluindo ID, produto, tipo, quantidade e descrição.

## Dados iniciais

O arquivo `estoque.json` contém os produtos inicialmente cadastrados no sistema, incluindo Caneta Azul, Caderno Universitário, Borracha Branca, Lápis Preto HB e Marcador de Texto Amarelo.
