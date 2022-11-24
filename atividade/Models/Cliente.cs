using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public class Cliente : Usuario
    {
        public Cliente(string nome, string nomeUsr, string email)
        {
            Console.WriteLine("Criando CLIENTE.");
            Random rd = new Random();
            Id = rd.Next();
            Nome = nome;
            NomeUsr = nomeUsr;
            Email = email;
            EhAtivo = true;
            NivelAcc = false;
        }
        public override Models.Thread CriarThread(string conteudo)
        {
            Console.WriteLine("Criando uma thread");
            return new Models.Thread(this, conteudo);
        }

        public override void EditarThread(string novoConteudo, Thread thread)
        {
            if (thread.ValidarUsuario(this))
            {
                Console.WriteLine("Editando uma thread");
                thread.Conteudo = novoConteudo;
            }
            else
            {
                Console.WriteLine("401: Permissão negada");
            }            
        }

        public override void ExcluirThread(Models.Thread thread)
        {
            if (thread.ValidarUsuario(this))
            {                
                Console.WriteLine("Excluindo uma thread");
                thread = null;
            }
            else
            {
                Console.WriteLine("401: Permissão negada");
            }
        }

        public override void ResponderThread(string reposta, Models.Thread thread)
        {
            Console.WriteLine("Respondendo uma thread");
            thread.Respostas.Add(reposta);
        }
    }
}
