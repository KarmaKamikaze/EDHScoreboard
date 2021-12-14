using System.Data;
using System.Data.SQLite;
using Dapper;
using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary;

public static class SqlDataAccess
{
    public static IEnumerable<PlayerModel> LoadPlayers()
    {
        using IDbConnection connection = new SQLiteConnection("Data Source=../database.db;Version=3;");
        IEnumerable<PlayerModel>? output =
            connection.Query<PlayerModel>("SELECT * FROM AspNetUsers", new DynamicParameters());
        return output;
    }
    
    public static void SavePlayer(PlayerModel player)
    {
        using IDbConnection connection = new SQLiteConnection("Data Source=./database.db;Version=3;");
        connection.Execute(
            "INSERT INTO AspNetUsers (UserName, GamesPLayed, Points) VALUES (@PlayerTag, @GamesPlayed, @Points)",
            player);
    }
}