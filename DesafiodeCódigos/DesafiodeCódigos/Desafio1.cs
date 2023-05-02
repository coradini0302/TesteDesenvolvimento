namespace Desafio1
{
    class Desafio1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite as notas do aluno abaixo:");
                Console.Write("Nota 1: ");
                var input1 = Console.ReadLine();
                if (input1.Contains(".") && input1 != null)
                {
                    input1 = input1.Replace(".", ",");
                }
                double.TryParse(input1, out double nota1);
                if (nota1 > 10)
                {
                    while (nota1 > 10)
                    {
                        Console.WriteLine("Nota não pode ser maior que 10.0");
                        input1 = Console.ReadLine();
                        double.TryParse(input1, out nota1);
                    }

                }
                Console.Write("Nota 2: ");
                var input2 = Console.ReadLine();
                if (input2.Contains(".") && input2 != null)
                {
                    input2 = input2.Replace(".", ",");
                }
                double.TryParse(input2, out double nota2);
                if (nota2 > 10)
                {
                    while (nota2 > 10)
                    {
                        Console.WriteLine("Nota não pode ser maior que 10.0");
                        input2 = Console.ReadLine();
                        double.TryParse(input2, out nota2);
                    }

                }
                Console.Write("Nota 3: ");
                var input3 = Console.ReadLine();
                if (input3.Contains(".") && input3 != null)
                {
                    input3.Replace(".", ",");
                }
                double.TryParse(input1, out double nota3);
                if (nota3 > 10)
                {
                    while (nota3 > 10)
                    {
                        Console.WriteLine("Nota não pode ser maior que 10.0");
                        input1 = Console.ReadLine();
                        double.TryParse(input3, out nota3);
                    }

                }
                var resultado = MediaNotas(nota1, nota2, nota3);
                Console.WriteLine(" MEDIA = {0} ", resultado);

            }
            catch
            {
                Console.WriteLine("Presentation Error");
            }



        }

        static double MediaNotas(double nota1, double nota2, double nota3)
        {
            var media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10; // Somatoria de pesos == 3+ 2+ 5 = 10;
            var arredondamento = Math.Round(media, 1);
            return arredondamento;
        }
    }
}