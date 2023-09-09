using System;
using Cinema;

   
        class Program
    {
        static void Main(string[] args)
        {
            Sala sala1 = new Sala { QuantidadeCadeiras = 100 };
            Filme filme1 = new FilmeConcreto("Filme 1", 2023, 120);

            Sessao sessao1 = new Sessao(DateTime.Now, sala1, filme1);
            sessao1.MostrarDados();

            // Você pode criar outras sessões e filmes conforme necessário
        }
    }

