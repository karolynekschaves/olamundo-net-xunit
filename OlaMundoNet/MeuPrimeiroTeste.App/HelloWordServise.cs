using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuPrimeiroTeste.App
{
    public class HelloWordServise
    {
        public string GerarSaudacao(string? nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return "Olá, Mundo!";
            }
            else
            {
                return $"Olá, {nome}!";
            }
        }
    }
}