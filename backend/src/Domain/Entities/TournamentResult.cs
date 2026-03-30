namespace MetaTracker.Domain.Entities;

public class TournamentResult
{
    public int Id { get; set; }
    public string TournamentId { get; set; } = string.Empty;
    public string PlayerId { get; set; } = string.Empty;
    public string? DeckId { get; set; }
    public int? Placing { get; set; }
    public int? Drop { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Ties { get; set; }

    public Tournament Tournament { get; set; } = null!;
    public Player Player { get; set; } = null!;
    public DeckArchetype? Deck { get; set; }
    public Decklist? Decklist { get; set; }
}