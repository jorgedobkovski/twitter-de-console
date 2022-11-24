using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public class Admin : Usuario
    {
        public Admin(string nome, string nomeUsr, string email)
        {
            Console.WriteLine("Criando ADMIN.");
            Random rd = new Random();
            Id = rd.Next();
            Nome = nome;
            NomeUsr = nomeUsr;
            Email = email;
            EhAtivo = true;
            NivelAcc = true;
        }
        public void FornecerAcesso(Usuario cliente)
        {
            if (NivelAcc)
            {
                cliente.NivelAcc = true;
                Console.WriteLine("Acesso fornecido ao usuário " + cliente.Nome);
            }
            else
            {
                Console.WriteLine("401: Permissão negada");
            }
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
