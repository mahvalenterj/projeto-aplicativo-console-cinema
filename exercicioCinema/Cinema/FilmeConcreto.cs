using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class FilmeConcreto : Filme
    {
        public FilmeConcreto(string titulo, int ano, int duracao)
        {
            Titulo = titulo;
            Ano = ano;
            Duracao = duracao;
        }
    }
}
