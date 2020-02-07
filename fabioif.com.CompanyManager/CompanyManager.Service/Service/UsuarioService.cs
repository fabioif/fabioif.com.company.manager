using CompanyManager.Entities;
using CompanyManager.Repository;
using CompanyManager.Repository.Interfaces;
using CompanyManager.Repository.Repository;
using CompanyManager.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager.Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;
        }

        public UsuarioService()
        {
            usuarioRepository = new UsuarioRepository();
        }

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

        public bool VerificarLoginExiste(string login, string senha)
        {
            return usuarioRepository.VerificarLoginExiste(login, senha);
        }
    }
}
