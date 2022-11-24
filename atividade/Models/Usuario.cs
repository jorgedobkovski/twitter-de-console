using atividade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public abstract class Usuario : IThread
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeUsr { get; set; }
        public string Email { get; set; }
        public bool EhAtivo { get; set; }
        public bool NivelAcc { get; set; }

        public abstract Models.Thread CriarThread(string conteudo);

        public abstract void EditarThread(string novoConteudo, Models.Thread thread);

        public abstract void ExcluirThread(Models.Thread thread);

        public abstract void ResponderThread(string reposta, Models.Thread thread);
       
    }
}
