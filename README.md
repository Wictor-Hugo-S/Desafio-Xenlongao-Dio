# Desafio-Xenlongao-Dio

Bom esse desafio foi bastante interessante.
Ele pede para:
abrir uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas 
cujo o número de divisores da quantidade de estrelas da esfera sejam par.

Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas, pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas para invocar Xenlongão.

Dado de entrada:
1
7
Saída esperada:
5


E para o seguinte problema proposto podemos fazer a seguinte resposta.

Vamos fazer uma função matemática.
(c - Math.Floor(Math.Sqrt(c))

usamos primeiro o SQRT para tirarmos a raiz quadrada do número 7 por exemplo. Que daria = 2.64

E logo em seguida usamos o Math Floor para arredondar e pegar apenas a parte inteira.
Como funciona o Math floor? Ele sempre busca pegar o menor valor ou igual ao seu ponto flutuante,neste caso seria 2.64 e que se tornaria igual a 2.
Caso fosse -2.64 se tornaria -3.
depois de extrair a Raiz quadrada e usar o Math.Floor, vamos calcular o valor de entrada C que no caso é 7 - 2. Que daria a resposta 5.





Para saber mais sobre o Math.Floor Acesse aqui https://docs.microsoft.com/pt-br/dotnet/api/system.math.floor?view=net-6.0

