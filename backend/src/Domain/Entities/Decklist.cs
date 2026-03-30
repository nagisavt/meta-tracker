namespace MetaTracker.Domain.Entities;

public class Decklist
{
    public int Id { get; set; }
    public int ResultId { get; set; }

    public TournamentResult Result { get; set; } = null!;
    public ICollection<DecklistCard> Cards { get; set; } = new List<DecklistCard>();
}