using System.Data;
using System.Data.SQLite;
using Dapper;
using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary;

public class SqlDataAccess
{
    public static List<PlayerModel> LoadPlayers()
    {
        using IDbConnection connection = new SQLiteConnection("Data Source=../database.db;Version=3;");
        var output = connection.Query<PlayerModel>("SELECT * FROM AspNetUsers", new DynamicParameters());
        return output.ToList();
    }
        
    public static void SavePlayer(PlayerModel player)
    {
        using IDbConnection connection = new SQLiteConnection("Data Source=./database.db;Version=3;");
        connection.Execute("INSERT INTO AspNetUsers (UserName, GamesPLayed, Points) VALUES (@PlayerTag, @GamesPlayed, @Points) ", player);
    }
}