namespace MetaTracker.Domain.Entities;

public class DeckArchetype
{
    public string Id { get; set; } = string.Empty; // ex: lucario-hariyama
    public string Name { get; set; } = string.Empty;

    public ICollection<DeckIcon> Icons { get; set; } = new List<DeckIcon>();
    public ICollection<TournamentResult> Results { get; set; } = new List<TournamentResult>();
}