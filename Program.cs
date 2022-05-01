using System; //quais os pacotes que ainda vamos utilizar

namespace exercicio001 //agrupador de instruções
{
    class Program //modelo de um objeto
    {
        static void Main(string[] args) {

            // calculadora
            /**
            double d;
            d = 12 + 3; // soma     
            d = 12 - 3; // subtração
            d = 12 * 3;// multiplicação
            d = 12 / 3; //divisão
            Console.WriteLine(d);
            */

            double num1, num2;
            string tmp;
            Console.WriteLine("Digite um número:");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;
            resultado = num1 + num2;
            Console.WriteLine("Soma:" + resultado);

            resultado = num1 - num2;
            Console.WriteLine("Subtração:" + resultado);

            resultado = num1 * num2;
            Console.WriteLine("Multiplicação:" + resultado);

            resultado = num1 / num2;
            Console.WriteLine("Divisão:" + resultado);

            
    }

}
 }