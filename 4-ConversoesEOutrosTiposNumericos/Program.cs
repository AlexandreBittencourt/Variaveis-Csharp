namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 PROJETO");

            double salario;
            salario = 1200.50;
            //32/bits
            int salarioInteiro;
            salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //64bits
            long idadeUniverso;
            idadeUniverso = 13000000000;
            Console.WriteLine(idadeUniverso);

            //16bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);


            Console.WriteLine("Execução finalizada... tecle enter para sair");
            Console.ReadLine();
        }
    }
}