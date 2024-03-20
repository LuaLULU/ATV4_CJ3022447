namespace ATV4_CJ3022447
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("//////////////////////////// \ndigite qual operação voce deseja realizar?\n1-divisão " +
                "\n2-multiplicação\n3-soma\n4-subtração \n//////////////////////////////////");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("escreva o numero que deseja dividir e o dividor.");
                    int n1, n2;
                    float result;
                    n1 = int.Parse(Console.ReadLine());
                    n2 = int.Parse(Console.ReadLine());
                    result = n1 / n2;
                    Console.WriteLine("o resultado é {0}", result);
                    break; 
                 case 2:
                    Console.WriteLine("escreva os numeros que deseja multiplicar ");
                    int n3, n4;
                    float result1;
                    n3 = int.Parse(Console.ReadLine());
                    n4 = int.Parse(Console.ReadLine());
                    result1 = n3 * n4;
                    Console.WriteLine("o resultado é {0}", result1);
                    break;
                case 3:
                    Console.WriteLine("escreva os numero que deseja somar.");
                    int n5, n6;
                    float result2;
                    n5 = int.Parse(Console.ReadLine());
                    n6 = int.Parse(Console.ReadLine());
                    result2 = n5 + n6;
                    Console.WriteLine("o resultado é {0}", result2);
                    break;
                case 4:
                    Console.WriteLine("escreva os numeros que deseja subtrair.");
                    int n7, n8;
                    float result3;
                    n7 = int.Parse(Console.ReadLine());
                    n8 = int.Parse(Console.ReadLine());
                    result3 = n7 - n8;
                    Console.WriteLine("o resultado é {0}", result3);
                    break;
            }
        }
    }
}
