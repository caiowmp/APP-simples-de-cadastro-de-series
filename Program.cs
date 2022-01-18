using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Menu(){
            Console.WriteLine();
			Console.WriteLine("Bem vindo!!!");
			Console.WriteLine("Escolha uma opção:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("6- Limpar Tela");
			Console.WriteLine("0- Sair");
			Console.WriteLine();

			int escolha = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			return escolha;
        }
    }
}
