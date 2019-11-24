using BeeSafeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeSafeAPI.Repositories.Contracts
{
    public interface IPerfilRepository
    {
        Perfil Login(string Email, string Senha);

        //CRUD
        void Cadastrar(Perfil perfil);
        void Atualizar(Perfil perfil);
        void Excluir(int Id);
        Perfil ObterCliente(int Id);
        IEnumerable<Perfil> ObterTodosClientes();
    }
}
