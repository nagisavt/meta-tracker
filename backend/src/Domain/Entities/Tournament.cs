namespace MetaTracker.Domain.Entities;

public class Tournament
{
    public string Id { get; set; } = string.Empty;
    public string Game { get; set; } = string.Empty;
    public string Format { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public int PlayersCount { get; set; }

    public ICollection<TournamentResult> Results { get; set; } = new List<TournamentResult>();
}