namespace _3_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(idade);

            Console.WriteLine("Execução finalizada... tecle enter para sair");
            Console.ReadLine();
        }
    }
}