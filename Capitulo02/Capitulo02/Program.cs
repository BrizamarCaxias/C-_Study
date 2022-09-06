namespace Capitulo02
{
    class Program
    {
        static void Main(String[] args)
        {
            Instituicao instituicao = new Instituicao();
            System.Console.WriteLine("Informe o nome da instituição:");
            instituicao.Nome = System.Console.ReadLine();
            System.Console.WriteLine("Informe o endereco da instituição:");
            instituicao.Endereco = System.Console.ReadLine();

            System.Console.WriteLine("#####################################################");
            System.Console.WriteLine($"Obrigado por informar os dados para a instituição {instituicao.Nome}");
            System.Console.WriteLine("Pressione qualquer tecla para sair.");
            System.Console.ReadKey();
        }
    }

}