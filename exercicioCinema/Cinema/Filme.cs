using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public abstract class Filme
    {
        public string Titulo { get; set; }
        public int Ano  { get; set; }
        public int Duracao { get; set; }

    }
}
