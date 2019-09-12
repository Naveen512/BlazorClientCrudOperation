
using System.Threading.Tasks;
using Blazor.CRUD.Sample.Models;
using System.Collections.Generic;

namespace Blazor.CRUD.Sample.Logics
{
    public interface IPlayersLogic
    {
        Task<bool> CreatePlayer(Player player);
        Task<IList<Player>> GetAll();
        Task<Player> GetById(int id);

        Task<bool> UpdatePlayer(Player player);
        Task<List<Player>> DeleteById(int id);
    }
}
