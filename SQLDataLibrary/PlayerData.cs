using System.Collections.Generic;
using System.Threading.Tasks;
using SQLDataLibrary.Models;

namespace SQLDataLibrary
{
    public class PlayerData : IPlayerData
    {
        private readonly ISQLDataAccess _db;

        public PlayerData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PlayerModel>> GetPlayers()
        {
            string sql = "select * from dbo.Players";

            return _db.LoadData<PlayerModel, dynamic>(sql, new { });
        }

        public Task InsertPlayer(PlayerModel player)
        {
            string sql = @"insert into dbo.Players (PlayerTag, GamesPlayed, Points)
                            values (@PlayerTag, @GamesPlayed, @Points);";

            return _db.SaveData(sql, player);
        }
    }
}