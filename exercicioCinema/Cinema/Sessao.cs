using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Sessao : IExibicao
    {
        private Filme filme;
        private Sala sala;
        private DateTime dataHora;

        public Sessao(DateTime data, Sala sala, Filme filme)
        {
            this.dataHora = data;
            this.sala = sala;
            this.filme = filme;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Sessão de {filme.Titulo}, Ano: {filme.Ano}, Duração: {filme.Duracao} minutos");
            Console.WriteLine($"Sala: {sala.QuantidadeCadeiras} cadeiras");
            Console.WriteLine($"Data e Hora: {dataHora}");
        }
    }
}
