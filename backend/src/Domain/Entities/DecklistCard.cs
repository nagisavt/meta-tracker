namespace MetaTracker.Domain.Entities;

public class DecklistCard
{
    public int Id { get; set; }
    public int DecklistId { get; set; }
    public string CardType { get; set; } = string.Empty; // pokemon, trainer, energy
    public int Count { get; set; }
    public string Set { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public Decklist Decklist { get; set; } = null!;
}