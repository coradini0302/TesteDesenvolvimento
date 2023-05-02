namespace Desafio3
{
    class Desafio3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hora de saída: ");
                var input1 = Console.ReadLine();
                int.TryParse(input1, out int hora);
                if (hora <= 0 || hora >= 23)
                {
                    while (hora <= 0 || hora >= 23)
                    {
                        Console.WriteLine("Hora não pode ser menor igual que 0 ou maior igual a 23");
                        input1 = Console.ReadLine();
                        int.TryParse(input1, out hora);
                    }

                }
                Console.Write("Tempo de viagem: ");
                var input2 = Console.ReadLine();
                int.TryParse(input1, out int tempo);
                if (tempo <= 1 || tempo >= 12)
                {
                    while (tempo <= 1 || tempo >= 12)
                    {
                        Console.WriteLine("Tempo de viagem não pode ser menor igual que 1 ou maior igual a 12");
                        input2 = Console.ReadLine();
                        int.TryParse(input2, out tempo);
                    }

                }
                var input3 = Console.ReadLine();
                int.TryParse(input3, out int fuso);
                if (fuso <= -5 || hora >= 5)
                {
                    while (fuso <= -5 || hora >= 5)
                    {
                        Console.WriteLine("Hora não pode ser menor igual a -5 ou maior igual a 5");
                        input3 = Console.ReadLine();
                        int.TryParse(input3, out fuso);
                    }

                }
                var resultado = HoraPrevista(hora, tempo, fuso);
                if(resultado == 24)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(" {0} ", resultado);
                }
                

            }
            catch
            {
                Console.WriteLine("Presentation Error");
            }



        }

        static double HoraPrevista(int hora, int tempo, int fuso)
        {
            var somatorio = hora + tempo + (fuso); // Somatoria de pesos == 3+ 2+ 5 = 10;
            if(somatorio > 24)
            {
                somatorio = somatorio - 24;
            }

            return somatorio;
        }
    }
}