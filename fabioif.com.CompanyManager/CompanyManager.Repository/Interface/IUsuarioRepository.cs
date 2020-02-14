using CompanyManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Repository.Interfaces
{
    public interface IUsuarioRepository : IDisposable
        {
            Usuario ObterPorId(int Id);
            List<Usuario> ObterTodos();
            void Incluir(Usuario usuario);
            void Remover(Usuario usuario);
            void Atualizar(Usuario usuario);
            Usuario Login(string Login, string Senha);
    }
}
