class Program
{
    static void Main(string[] args)
    {
      
            Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            bool Fibonacci = false;

            while (a <= num)
            {
                if (a == num)
                {
                    Fibonacci = true;
                    break;
                }
                int temp = a;
                a = b;
                b = temp + b;
            }

            if (Fibonacci)
            {
                Console.WriteLine("O número " +num+ " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine("O número " +num+" não pertence à sequência de Fibonacci.");
            }
        }
    
    }
