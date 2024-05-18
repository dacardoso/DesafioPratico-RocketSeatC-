using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace DesafioPratico.Exercicios
{
    public class Exercicios
    {
        //Exercicio 1
        //Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
        public void Exercicio1()
        {
            Console.WriteLine("\nExercicio 1");
            Console.WriteLine("Por favor, digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        }

        //Exercicio 2
        //Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
        public void Exercicio2()
        {
            Console.WriteLine("\nExercicio 2");
            Console.WriteLine("Digite seu Nome:");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite seu Sobrenome:");
            string sobrenome = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"{nome} {sobrenome}");
        }

        //Exercicio 3
        //Crie um programa com 2 valores do tipo double já declarados que retorne:
        //- A soma entre esses dois números;
        //- A subtração entre os dois números;
        //- A multiplicação entre os dois números;
        //- A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
        //- A média entre os dois números.
        public void Exercicio3()
        {
            Console.WriteLine("\nExercicio 3");
            Console.WriteLine("Digite o valor 1:");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 2:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Soma: {valor1 + valor2}");
            Console.WriteLine($"Subtração: {valor1 - valor2}");
            Console.WriteLine($"Multiplicação: {valor1 * valor2}");
            
            if (valor2 == 0)
                Console.WriteLine("Divisão Erro: Divisão por zero não é permitida.");
            else
                Console.WriteLine($"Divisão: {valor1 / valor2}");

            Console.WriteLine($"Média: {(valor1 + valor2) / 2}");
        }

        //Exercicio 4
        //Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
        public void Exercicio4()
        {
            Console.WriteLine("\nExercicio 4");
            Console.WriteLine("Digite uma ou mais palavras espaços não serão considerados: ");
            string texto = Convert.ToString(Console.ReadLine()).Trim();
            Console.WriteLine($"A quantidade de caracteres é {texto.Length}");
        }

        //Exercicio 5
        //Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        //- A placa deve ter 7 caracteres alfanuméricos;
        //- Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
        //- Os quatro últimos caracteres são números;   
        //Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
        public void Exercicio5()
        {
            Console.WriteLine("\nExercicio 5");
            Console.WriteLine("Digite a placa do veículo: ");
            string placa = Convert.ToString(Console.ReadLine());
            string padrao = @"^[a-zA-Z]{3}[0-9][A-Za-z0-9][0-9]{2}$";
            Regex regex = new Regex(padrao);
            if (regex.IsMatch(placa))
                Console.WriteLine("A placa é válida.");
            else
                Console.WriteLine("A placa é inválida.");
        }

        //Exercicio 6
        //Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        //- Formato completo (dia da semana, dia do mês, mês, ano, hora, //minutos, segundos).
        //- Apenas a data no formato "01/03/2024".
        //- Apenas a hora no formato de 24 horas.
        //- A data com o mês por extenso.
        public void Exercicio6()
        {
            Console.WriteLine("\nExercicio 6");
            DateTime data = DateTime.Now;

            string formatoCompleto = data.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
            Console.WriteLine("Formato completo: " + formatoCompleto);

            string formatoData = data.ToString("dd/MM/yyyy");
            Console.WriteLine("Apenas a data no formato 01/03/2024: " + formatoData);

            string formatoHora = data.ToString("HH:mm:ss");
            Console.WriteLine("Apenas a hora no formato de 24 horas: " + formatoHora);

            string formatoMesPorExtenso = data.ToString("dd 'de' MMMM 'de' yyyy");
            Console.WriteLine("A data com o mês por extenso: " + formatoMesPorExtenso);
        }
    }


}

