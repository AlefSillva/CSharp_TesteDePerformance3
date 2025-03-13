# Menu de Exercícios
Este é um programa desenvolvido para testar diferentes exercícios do **Teste De Performance 3** da matéria de **Fundamentos de Desenvolvimento com C#**. O código é estruturado de forma modular, com várias classes que podem ser executadas a partir de um menu interativo no console.

## Funcionalidade
O programa oferece um menu interativo para o usuário escolher qual exercício deseja testar. Cada exercício está relacionado a uma classe específica do sistema e ao selecionar o número correspondente, o programa executará a lógica dessa classe. O menu apresenta as seguintes opções:

- 1 - Testar Classe Carro
- 2 - Testar Classe Ingresso
- 3 - Testar Classe Matrícula
- 4 - Testar Classe Figuras
- 0 - Sair

## Classe Ingresso
A classe AppIngresso permite que o usuário interaja com um objeto da classe Ingresso e visualize diferentes formas de alterar as informações de um ingresso, seja usando os métodos **AlterarPreco() e AlterarQuantidade()** ou usando **getters e setters**.

## Funcionalidade:
- **Criar um ingresso:** O programa cria um objeto **Ingresso** com informações como nome do show, preço e quantidade de ingressos disponíveis.
- **Exibir informações:** O método **ExibirInformacoes()** mostra as informações do ingresso antes de qualquer alteração.
  
**Alterar informações:** O usuário pode escolher entre dois tipos de alteração:
- **Alteração normal:** Usando os métodos **AlterarPreco() e AlterarQuantidade()**.
- **Alteração com Getters e Setters:** Usando métodos **Get e Set** para alterar as propriedades do ingresso.

### Como Usar:
Após selecionar a opção "Testar Classe Ingresso", o programa apresentará um menu para o usuário escolher como visualizar as alterações. O menu de opções será o seguinte:

```
=================================================
       ALTERAR INFORMAÇÕES DO INGRESSO     
=================================================

*** Escolha o método de alteração que deseja visualizar ***

1 - Visualizar Alteração Normal (AlterarPreco() e AlterarQuantidade())
2 - Visualizar Alteração com Getters e Setters
3 - Voltar ao Menu Principal
0 - Sair

Digite o número da opção desejada:
```

## Como Executar o Projeto
- Clone ou baixe este repositório em sua máquina.
- Abra o projeto no Visual Studio (ou em sua IDE preferida).
- Compile e execute o código.
- O menu será exibido no console.
- Escolha um número correspondente ao exercício que deseja testar ou digite "0" para sair.
