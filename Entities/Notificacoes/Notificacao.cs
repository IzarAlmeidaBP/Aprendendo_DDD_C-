using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Notificacoes
{
    public class Notificacao
    {


        public Notificacao()
        {
            Notifica = new List<Notificacao>();
        }



        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }


        [NotMapped]
        public List<Notificacao> Notifica;

        public bool ValidaPropriedadeString(string Valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(Valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {

                Notifica.Add(new Notificacao
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;

            }
            return true;
        }
        public bool ValidaPropriedadeInt(int Valor, string nomePropriedade)
        {
            if (Valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {

                Notifica.Add(new Notificacao
                {
                    Mensagem = "O valor deve ser maior do que 0",
                    NomePropriedade = nomePropriedade
                });

                return false;

            }
            return true;
        }
        public bool ValidaPropriedadeDecimal(decimal Valor, string nomePropriedade)
        {
            if (Valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {

                Notifica.Add(new Notificacao
                {
                    Mensagem = "O valor deve ser maior do que 0",
                    NomePropriedade = nomePropriedade
                });

                return false;

            }
            return true;
        }
    }
}
