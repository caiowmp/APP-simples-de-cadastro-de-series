using System;
using Projeto.Classes;
using Projeto.Enum;

namespace Projeto
{
    class Program
    {
        //Instanciando nosso banco de dados
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            int escolha = Menu();

            while (escolha != 0)
			{
				switch (escolha)
				{
					case 1:
						ListarSeries();
						break;
					case 2:
						AdicionarSerie();
						break;
					case 3:
						AtualizarSerie();
						break;
					case 4:
						ExcluirSerie();
						break;
					case 5:
						VisualizarSerie();
						break;
					case 6:
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				escolha = Menu();
			}

			Console.WriteLine("Obrigado!!");
			Console.ReadLine();
        }

        private static int Menu(){
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

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

			var listaSeries = repositorio.Lista();

            if(listaSeries.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada");
            }
            else
            {
                foreach(var item in listaSeries)
                {
                    System.Console.WriteLine("ID({0}) - {1}", item.getId(), item.getTitulo());
                }
            }

        }

        private static void AdicionarSerie()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Adicionar nova série");

            foreach(int chave in Genero.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", chave, Genero.GetName(typeof(Genero), chave));
            }

            System.Console.WriteLine("Escolha o gênero da série: ");
            int chaveGenero = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite o título da série: ");
            string titulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano de início da série: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            Serie nova = new Serie(repositorio.ProximoId(),(Genero)chaveGenero,titulo,descricao,ano);

            repositorio.Insere(nova);

        }

        private static void AtualizarSerie()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Atualizar série");
        
            System.Console.WriteLine("Digite o ID da série: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach(int chave in Genero.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} - {1}", chave, Genero.GetName(typeof(Genero), chave));
            }

            System.Console.WriteLine("Escolha o gênero da série: ");
            int chaveGenero = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite o título da série: ");
            string titulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano de início da série: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite a descrição da série: ");
            string descricao = Console.ReadLine();

            Serie atualizada = new Serie(repositorio.ProximoId(),(Genero)chaveGenero,titulo,descricao,ano);

            repositorio.Atualiza(id,atualizada);
        }

        private static void ExcluirSerie()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Excluir série");

            System.Console.WriteLine("Digite o ID da série: ");
            int id = Convert.ToInt32(Console.ReadLine());

            repositorio.Exclui(id);
        }

        private static void VisualizarSerie()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Vizualizar série");

            System.Console.WriteLine("Digite o ID da série: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var serie = repositorio.RetornaPorId(id);

            System.Console.WriteLine(serie);
        }
    }
}
