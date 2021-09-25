using System.Collections.Generic;
using System.Threading.Tasks;
using SQLDataLibrary.Models;

namespace SQLDataLibrary
{
    public interface IPlayerData
    {
        Task<List<PlayerModel>> GetPlayers();
        Task InsertPlayer(PlayerModel player);
    }
}