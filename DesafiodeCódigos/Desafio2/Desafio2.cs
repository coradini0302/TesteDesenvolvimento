namespace Desafio2
{
    class Desafio2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Cáculo de Volume:");
                Console.Write("Raio da esfera: ");
                var input1 = Console.ReadLine();
                if (input1.Contains(".") && input1 != null)
                {
                    input1 = input1.Replace(".", ",");
                }
                double.TryParse(input1, out double raio);
                if (raio < 0)
                {
                    while (raio < 0)
                    {
                        Console.WriteLine("O raio não pode ser negativo");
                        input1 = Console.ReadLine();
                        double.TryParse(input1, out raio);
                    }

                }
               
                var resultado = VolumeEsfera(raio);
                Console.WriteLine("VOLUME = {0} ", resultado);

            }
            catch
            {
                Console.WriteLine("Presentation Error");
            }



        }

        static double VolumeEsfera(double raio)
        {
            var pi = 3.14159;
            var R = Math.Pow(raio, 3);
            var volume = (4 * pi * R)/3 ; 
            var arredondamento = Math.Round(volume, 3);
            return arredondamento;
        }
    }
}