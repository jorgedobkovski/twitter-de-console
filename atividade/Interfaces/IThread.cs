using atividade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Interfaces
{
    public interface IThread
    {
        public Models.Thread CriarThread(string conteudo);
        public void EditarThread(string novoConteudo, Models.Thread thread);
        public void ResponderThread(string reposta, Models.Thread thread);
        public void ExcluirThread(Models.Thread thread);
    }
}
