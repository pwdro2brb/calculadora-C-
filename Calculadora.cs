
namespace calculadora
 {

    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int resultado;

            string resposta;

            Console.WriteLine("Olá!!, bem vindo ao programa Calculadora em C#");
            Console.WriteLine("Por favor, digite o primeiro número.");

            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.WriteLine("Por favor, digite o seu segundo número. ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que tipo de operação você gostaia de fazer? ");
            Console.WriteLine("Por favor, digite a para adição, b para subtração, c para multiplicação e qualquer outra tecla para divisão.");

            resposta = Console.ReadLine();

            if(resposta == "a")
            {
                resultado = num1 + num2;
            }
            else if(resposta == "b")
            {
                resultado = num1 - num2;
            }
            else if(resposta == "c")
            {
                resultado = num1 * num2;
            }
            else
            {
                resultado = num1 / num2;
            }

            Console.WriteLine("O resultado é " + resultado);
            Console.WriteLine("Obrigado por utilizar o meu programa de calculadora");

        }

    }
 }