namespace DiamatesDeX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int NumLetras, espacos;
           

            while (true)
            {
                Console.Clear();
                Console.Write("Digite um número impar: ");
                numero = Convert.ToInt32(Console.ReadLine());


                if (numero % 2 == 1)
                {
                    NumLetras = 1;
                    espacos = (numero - 1) / 2;
                    for (int linha = 1; espacos > 0; linha++)
                    {


                        for (int count = 1; count <= espacos; count++)
                        {
                            Console.Write(" ");
                        }


                        for (int count = 1; count <= NumLetras; count++)
                        {
                            Console.Write("x");
                        }

                        espacos--;
                        NumLetras += 2;
                        Console.WriteLine();
                        
                    }


                    for (int linha = 1; NumLetras > 0; linha++)
                    {


                        for (int count = 1; count <= espacos; count++)
                        {
                            Console.Write(" ");
                        }


                        for (int count = 1; count <= NumLetras; count++)
                        {
                            Console.Write("x");
                        }

                        espacos++;
                        NumLetras -= 2;
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("Não é Impar! ");
                }
                Console.ReadLine();
                continue;
            }


        }
    }
}