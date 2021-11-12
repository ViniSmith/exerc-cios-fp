namespace exercicio_01
{
    class Program
    {
        const int numAlunos = 10;
        static void Main(string[] args)
        {
            int [] idades = new int[numAlunos];
            double media;
    
            LerIdades(idades);

            media = CalcularMedia(idades);

            ImprimeQtAcimaDe(idades, media);


        }

        static void ImprimeQtAcimaDe(int[] idades, double media){
            int qtAcimaMedia = 0;
            for (int i = 0; i < idades.Length; i++){
                if(idades[i] > media) {
                    qtAcimaMedia ++;
                }

            }
            Console.WriteLine("{0} Alunos possuem a idade acima da média que é {1}", qtAcimaMedia, media);
        }

        static double CalcularMedia(int[] idades)
        {   
            int soma = 0;

            for (int i = 0; i < idades.Length ; i++){
                soma += idades[i];
            }

            return Convert.ToDouble(soma) / idades.Length;
        }

        static void LerIdades(int[] idades)
        {
            for (int i = 0; i < idades.Length ; i++){
                Console.Write("A idade do aluno {0}:", i+1);
                idades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
