using CompanyManager.Entities;
using CompanyManager.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Repository.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Incluir(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Remover(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Usuario Login(string Login, string Senha)
        {
            Usuario user = new Usuario();
            user.Email = "fabioif@live.com";
            user.Senha = "12345678";

            return user;
        }
    }
}
