namespace SqlDataAccessLibrary.Models;

public class PlayerModel : IComparable<PlayerModel>
{
    public string? UserName { get; set; }
    public int GamesPlayed { get; set; }
    public int Points { get; set; }

    public int CompareTo(PlayerModel? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return Points.CompareTo(other.Points);
    }
}