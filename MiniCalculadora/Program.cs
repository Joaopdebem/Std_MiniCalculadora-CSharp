using MiniCalculadora.basicOperations;
using MiniCalculadora.Calculo;
using MiniCalculadora;

FazerConta calculo = new FazerConta();

Console.WriteLine("A soma é: " + calculo.Soma.Calcular(10, 10));
Console.WriteLine("A divisao é: " + calculo.Divisao.Calcular(9, 3))