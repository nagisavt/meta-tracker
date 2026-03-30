namespace MetaTracker.Domain.Entities;

public class Player
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    public ICollection<TournamentResult> Results { get; set; } = new List<TournamentResult>();
}