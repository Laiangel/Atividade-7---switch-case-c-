using System;

namespace CalculadoraDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita o salário do usuário
            Console.WriteLine("Digite o seu salário:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salario) || salario < 0)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um valor válido para o salário.");
                return;
            }

            // Declaração da variável de imposto
            decimal imposto;

            // Calcula o imposto de acordo com a faixa salarial
            if (salario <= 1500)
            {
                imposto = salario * 0.05m;  // Imposto de 5%
            }
            else if (salario <= 3000)
            {
                imposto = salario * 0.10m;  // Imposto de 10%
            }
            else
            {
                imposto = salario * 0.15m;  // Imposto de 15%
            }

            // Exibe o valor do imposto
            Console.WriteLine($"O imposto a ser pago é: R${imposto:F2}");
        }
    }
}

