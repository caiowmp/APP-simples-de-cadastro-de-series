using System;
using Projeto.Enum;

namespace Projeto.Classes
{
    public class Serie : Base
    {
        // Atributos
		private Genero genero { get; set; }
		private string titulo { get; set; }
		private string descricao { get; set; }
		private int ano { get; set; }
        private bool excluido {get; set;}

        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.id = id;
			this.genero = genero;
			this.titulo = titulo;
			this.descricao = descricao;
			this.ano = ano;
            this.excluido = false;
		}

        public override string ToString()
        {
            string mensagem = "";
            mensagem += "Gênero: " + this.genero + "\n";
            mensagem += "Título: " + this.titulo + "\n";
            mensagem += "Descrição: " + this.descricao + "\n";
            mensagem += "Ano de início: " + this.ano + "\n";
            mensagem += "Excluído: " + this.excluido;

            return mensagem;
        }

        public int getId()
        {
            return this.id;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public bool getExcluido()
        {
            return this.excluido;
        }
        
        public void Excluir()
        {
            this.excluido = true;
        }
    }
}