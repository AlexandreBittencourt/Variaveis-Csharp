namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'A';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)64;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2022;

            string cursosProgramacao = " - .NET" +
                " - Java" +
                " - Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);



            Console.ReadLine();
        }
    }
}