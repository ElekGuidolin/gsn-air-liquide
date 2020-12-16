using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gsn.AirLiquide.Web.Services
{
    public interface IDataHelper<T> where T : class
    {
        IEnumerable<T> BuscarTodos();
        T BuscarPorCliente(Guid idCliente);
        T Incluir(T entidade);
        T Atualizar(T entidade);
        bool Excluir(Guid id);
        
    }
}
