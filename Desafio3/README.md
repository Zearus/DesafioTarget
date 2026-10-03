# Desafio 3 — Calculadora de Juros

## Descrição

O objetivo deste desafio é desenvolver um programa em **C#** capaz de calcular os juros de uma dívida que esteja em atraso.

O programa solicita ao usuário:

* Valor da dívida;
* Data de vencimento.

A partir dessas informações, o sistema verifica se a dívida está atrasada. Caso esteja, calcula a quantidade de dias de atraso e aplica uma taxa de juros diária de **2,5%** sobre o valor original.

Ao final, o programa apresenta no console:

* Valor original da dívida;
* Data de vencimento;
* Data atual;
* Quantidade de dias de atraso;
* Taxa diária aplicada;
* Valor dos juros;
* Valor final a pagar.

## Regras de cálculo

A taxa de juros utilizada pelo programa é de **2,5% ao dia**.

O cálculo dos juros é realizado através da fórmula:

```text
Juros = Valor × 0,025 × Dias de atraso
```

O valor final é calculado da seguinte forma:

```text
Valor final = Valor original + Juros
```

## Validações

O programa realiza algumas validações durante a entrada dos dados:

* O valor informado não pode ser negativo;
* O valor deve ser informado utilizando o formato numérico brasileiro;
* A data de vencimento deve seguir o formato `dd/MM/yyyy`;
* Caso a data de vencimento seja igual ou posterior à data atual, o programa informa que a dívida não está atrasada e não calcula juros.

## Como executar

Certifique-se de que o **.NET SDK** esteja instalado na máquina.

Depois, execute o projeto através do comando:

```bash
dotnet run
```

O programa será iniciado no console e solicitará as informações necessárias.

## Exemplo de execução

```text
===== CALCULADORA DE JUROS =====

Digite o valor: 1000

Digite a data de vencimento (dd/MM/yyyy): 20/09/2026

===== RESULTADO =====
Valor original: R$ 1000,00
Vencimento: 20/09/2026
Data atual: 03/10/2026
Dias de atraso: 13
Taxa diária: 2,5%
Juros: R$ 325,00
Valor final: R$ 1325,00
```

## Tecnologias utilizadas

* **C#**
* **.NET**
* `System.Globalization` para tratamento de valores monetários e datas no padrão utilizado pelo programa.

## Estrutura do funcionamento

1. O usuário informa o valor da dívida.
2. O programa valida o valor informado.
3. O usuário informa a data de vencimento.
4. O programa valida a data.
5. A data de vencimento é comparada com a data atual.
6. Caso exista atraso, o programa calcula a quantidade de dias.
7. É aplicada a taxa de juros de 2,5% ao dia.
8. O programa calcula o valor final.
9. Os resultados são exibidos no console.
