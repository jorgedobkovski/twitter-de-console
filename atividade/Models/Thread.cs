using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade.Models
{
    public class Thread
    {
        public Thread(Usuario usuarioAutor, string conteudo)
        {
            Id = Guid.NewGuid();
            Conteudo = conteudo;
            Usuario = usuarioAutor;
            Respostas = new List<string>();
        }

        public Guid Id { get; set; }
        public string Conteudo { get; set; }
        public Usuario Usuario { get; set; }
        public List<string> Respostas { get; set;}

        public bool ValidarUsuario(Usuario usuario)
        {
            return (usuario == Usuario || usuario.NivelAcc == true) ? true : false;
        }

    }
}
